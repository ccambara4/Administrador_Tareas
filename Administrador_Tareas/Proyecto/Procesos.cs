using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Administrador_Tareas
{
    public partial class Procesos : MetroFramework.Forms.MetroForm//Plantilla
    {
        //Declaración de variables miembro de la clase.
        private List<ProcesoEstado> estados = new List<ProcesoEstado>();
        private bool ejecucionEnCurso = false;
        private DateTime inicioEjecucion;
        private int currentIndex = 0;

        //Constructor de la clase Procesos.
        public Procesos()
        {
            InitializeComponent();
        }

        //Evento Load del formulario.
        private void Procesos_Load(object sender, EventArgs e)
        {

        }

        private void crearEstadoButton_Click(object sender, EventArgs e)//Este botón sirve para crear el proceso e ingresarlo a la listbox de "Procesos"
        {
            //Obtiene el nombre y la operación del proceso a crear a partir de la interfaz de usuario.
            string nombreEstado = nombreEstadoTextBox.Text;
            string operacion = operacionComboBox.SelectedItem.ToString();

            //Crea un objeto ProcesoEstado y lo agrega a la lista de estados.
            ProcesoEstado estado = new ProcesoEstado(nombreEstado, operacion);
            estados.Add(estado);

            //Agrega el estado a la ListBox para mostrarlo al usuario.
            estadosListBox.Items.Add(estado);

            //Limpia el cuadro de texto del nombre del estado.
            nombreEstadoTextBox.Clear();
        }

        private void iniciarButton_Click(object sender, EventArgs e)//Este botón inicia el procedimiento donde el proceso creado pasara por cada estado
        {
            //Verifica si ya hay una ejecución en curso o si no hay estados en la lista.
            if (ejecucionEnCurso || estados.Count == 0)
                return;

            //Inicia la ejecución de procesos en un hilo separado.
            ejecucionEnCurso = true;
            inicioEjecucion = DateTime.Now;
            iniciarButton.Enabled = false;

            //Crea un nuevo hilo para ejecutar los procesos.
            Thread procesoThread = new Thread(EjecutarProceso);
            procesoThread.Start();


        }

        private void EjecutarProceso()
        {
            while (currentIndex < estados.Count)//En este se utilizan hilos para mostrar los estados del proceso den la listbox de "Procesos"
            {
                ProcesoEstado estado = estados[currentIndex];

                // Cambia el estado del proceso y actualiza la interfaz de usuario.
                estado.EstadoActual = EstadoProceso.Iniciado;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                Thread.Sleep(1000);

                estado.EstadoActual = EstadoProceso.Ejecutado;
                Invoke((MethodInvoker)delegate { estadosListBox.Refresh(); });
                Thread.Sleep(1000);

                if (estado.EsOperacion)
                {
                    //Si el estado representa una operación, realiza la operación y actualiza el resultado.
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

                //Agrega el estado al historial.
                AgregarAlHistorial(estado);

                currentIndex++;
            }

            //Finaliza la ejecución y muestra el tiempo transcurrido.
            ejecucionEnCurso = false;
            TimeSpan tiempoTranscurrido = DateTime.Now - inicioEjecucion;
            MostrarTiempoTranscurrido(tiempoTranscurrido);

            this.Invoke((MethodInvoker)delegate { iniciarButton.Enabled = true; });
        }

        private double RealizarOperacion(ProcesoEstado estado)//Este realiza la operación de los números ingresados
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

        //Método para mostrar un cuadro de diálogo de entrada y obtener un número
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

            return double.NaN; //Valor predeterminado en caso de error.
        }

        private double PedirNumeros(string mensaje1, string mensaje2, Func<double, double, double> operacion)//Error por si no se dan caracteres no validos al momento de ingresarlos en las operaciones
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

        private void AgregarAlHistorial(ProcesoEstado estado)//Agregar los procesos a la bitácora y mostrar el resultado
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

        private void MostrarTiempoTranscurrido(TimeSpan tiempo)//Mostrar el tiempo transcurrido
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
