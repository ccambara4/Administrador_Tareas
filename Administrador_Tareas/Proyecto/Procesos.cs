using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Administrador_Tareas
{
    public partial class Procesos : MetroFramework.Forms.MetroForm
    {
        private List<ProcesoEstado> estados = new List<ProcesoEstado>();
        private bool ejecucionEnCurso = false;
        private DateTime inicioEjecucion;
        private int currentIndex = 0;


        public Procesos()
        {
            InitializeComponent();
        }

        private void Procesos_Load(object sender, EventArgs e)
        {

        }

        private void crearEstadoButton_Click(object sender, EventArgs e)//Este botón sirve para crear el proceso e ingresarlo a la listbox de "Procesos"
        {
            string nombreEstado = nombreEstadoTextBox.Text;
            string operacion = operacionComboBox.SelectedItem.ToString();

            ProcesoEstado estado = new ProcesoEstado(nombreEstado, operacion);
            estados.Add(estado);
            estadosListBox.Items.Add(estado);

            nombreEstadoTextBox.Clear();
        }

        private void iniciarButton_Click(object sender, EventArgs e)//Este botón inicia el procedimiento donde el proceso creado pasara por cada estado
        {
            if (ejecucionEnCurso || estados.Count == 0)
                return;

            ejecucionEnCurso = true;
            inicioEjecucion = DateTime.Now;
            iniciarButton.Enabled = false;

            Thread procesoThread = new Thread(EjecutarProceso);
            procesoThread.Start();


        }

        private void EjecutarProceso()
        {
            while (currentIndex < estados.Count)//En este se utilizan hilos para mostrar los estados del proceso den la listbox de "Procesos"
            {
                ProcesoEstado estado = estados[currentIndex];

                estado.EstadoActual = EstadoProceso.Iniciado;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                Thread.Sleep(1000);

                estado.EstadoActual = EstadoProceso.Ejecutado;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                Thread.Sleep(1000);

                if (estado.EsOperacion)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        double resultado = RealizarOperacion(estado);
                        estado.Resultado = resultado;
                        estado.EstadoActual = EstadoProceso.Bloqueado;
                        Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                        Thread.Sleep(1000);
                    });
                }

                estado.EstadoActual = EstadoProceso.Listo;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                Thread.Sleep(1000);

                estado.EstadoActual = EstadoProceso.Finalizado;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });

                AgregarAlHistorial(estado);

                currentIndex++;
            }

            ejecucionEnCurso = false;
            TimeSpan tiempoTranscurrido = DateTime.Now - inicioEjecucion;
            MostrarTiempoTranscurrido(tiempoTranscurrido);

            this.Invoke((MethodInvoker)delegate { iniciarButton.Enabled = true; });
        }

        private double RealizarOperacion(ProcesoEstado estado)//Este realiza la operación de los número ingresados
        {
            double resultado = 0;
            string operacion = estado.Operacion;

            if (operacion == "Suma")
            {
                resultado = PedirNumeros("Ingrese el primer número:", "Ingrese el segundo número:", (num1, num2) => num1 + num2);
            }
            else if (operacion == "Resta")
            {
                resultado = PedirNumeros("Ingrese el primer número:", "Ingrese el segundo número:", (num1, num2) => num1 - num2);
            }
            else if (operacion == "Multiplicación")
            {
                resultado = PedirNumeros("Ingrese el primer número:", "Ingrese el segundo número:", (num1, num2) => num1 * num2);
            }
            else if (operacion == "División")
            {
                resultado = PedirNumeros("Ingrese el primer número:", "Ingrese el segundo número (distinto de 0):", (num1, num2) => num2 != 0 ? num1 / num2 : double.NaN);
            }

            return resultado;
        }

        private double MostrarCuadroDialogoEntrada(string mensaje)
        {
            Form cuadroDialogo = new Form();
            cuadroDialogo.Text = mensaje;

            Label label = new Label();
            label.Text = "Ingrese un número:";
            label.SetBounds(10, 10, 200, 20);

            TextBox textBox = new TextBox();
            textBox.SetBounds(10, 40, 200, 20);

            Button aceptarButton = new Button();
            aceptarButton.Text = "Aceptar";
            aceptarButton.DialogResult = DialogResult.OK;
            aceptarButton.SetBounds(10, 70, 75, 30);

            Button cancelarButton = new Button();
            cancelarButton.Text = "Cancelar";
            cancelarButton.DialogResult = DialogResult.Cancel;
            cancelarButton.SetBounds(100, 70, 75, 30);

            cuadroDialogo.Controls.Add(label);
            cuadroDialogo.Controls.Add(textBox);
            cuadroDialogo.Controls.Add(aceptarButton);
            cuadroDialogo.Controls.Add(cancelarButton);

            double resultado = 0;
            if (cuadroDialogo.ShowDialog() == DialogResult.OK)
            {
                if (double.TryParse(textBox.Text, out resultado))
                {
                    return resultado;
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return double.NaN; // Valor predeterminado en caso de error.
        }

        private double PedirNumeros(string mensaje1, string mensaje2, Func<double, double, double> operacion)//Error por si no se dan números validos al momento de ingresarlos
        {
            double resultado = 0;

            double num1 = MostrarCuadroDialogoEntrada(mensaje1);
            double num2 = MostrarCuadroDialogoEntrada(mensaje2);

            if (!double.IsNaN(num1) && !double.IsNaN(num2))
            {
                resultado = operacion(num1, num2);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        private void AgregarAlHistorial(ProcesoEstado estado)//Agregar los procesos a la bitácora y mopstrar el resultado
        {
            string mensaje = $"{estado.ID}: {estado.Nombre}: {estado.EstadoActual}";

            if (estado.EsOperacion)
            {
                mensaje += $" ({estado.Operacion}: {estado.Resultado})";
            }

            mensaje += $" - {DateTime.Now}";
            historialListBox.Invoke((MethodInvoker)delegate
            {
                historialListBox.Items.Add(mensaje);
            });



        }

        private void MostrarTiempoTranscurrido(TimeSpan tiempo)
        {
            tiempoTranscurridoTextBox.Invoke((MethodInvoker)delegate
            {
                tiempoTranscurridoTextBox.Text = $" Tiempo transcurrido: {tiempo.TotalSeconds} segundos";
            });

        }

        private void operacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void historialListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estadosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
