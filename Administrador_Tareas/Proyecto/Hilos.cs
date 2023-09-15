using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Administrador_Tareas
{
    public partial class Hilos : MetroFramework.Forms.MetroForm
    {
        public Hilos()
        {
            InitializeComponent();
        }

        private void Hilos_Load(object sender, EventArgs e)
        {
            //Iniciar el contador binario al cargar la aplicación
            Thread contadorThread = new Thread(MostrarModal);
            contadorThread.Start();

            //Configurar la apariencia y el diseño del formulario principal
            this.Text = "Ejecución de Hilos";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            //Configurar el TextBox y el Label
            Label lblNumHilos = new Label();
            lblNumHilos.Text = "Número de Hilos:";
            lblNumHilos.Location = new Point(20, 20);
            TextBox txtNumHilos = new TextBox();
            txtNumHilos.Name = "txtNumHilos";
            txtNumHilos.Location = new Point(140, 20);

            //Configurar el botón "Iniciar"
            Button btnIniciar = new Button();
            btnIniciar.Text = "Iniciar";
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Location = new Point(20, 60);
            btnIniciar.Click += btnIniciar_Click;

            //Agregar los controles al formulario principal
            this.Controls.Add(lblNumHilos);
            this.Controls.Add(txtNumHilos);
            this.Controls.Add(btnIniciar);

            //Configurar los ListBox
            ListBox listBox1 = new ListBox();
            ListBox listBox2 = new ListBox();
            ListBox listBox3 = new ListBox();
            ListBox listBox4 = new ListBox();

            //Configurar la ubicación y el tamaño de los ListBox
            listBox1.Location = new Point(20, 100);
            listBox2.Location = new Point(140, 100);
            listBox3.Location = new Point(260, 100);
            listBox4.Location = new Point(380, 100);

            listBox1.Size = new Size(100, 150);
            listBox2.Size = new Size(100, 150);
            listBox3.Size = new Size(100, 150);
            listBox4.Size = new Size(100, 150);

            //Agregar los ListBox al formulario principal
            this.Controls.Add(listBox1);
            this.Controls.Add(listBox2);
            this.Controls.Add(listBox3);
            this.Controls.Add(listBox4);

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Solicitar al usuario la cantidad de hilos
            int numHilos;
            if (int.TryParse(txtNumHilos.Text, out numHilos))
            {
                // Limpiar ListBox
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();

                //Iniciar hilos
                for (int i = 0; i < numHilos; i++)
                {
                    Thread thread = new Thread(ProcesoLargo);
                    thread.Start();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido de hilos.");
            }
        }

        private void ProcesoLargo()
        {
            //Simular un proceso largo
            Thread.Sleep(10000);

            //Mostrar mensaje cuando se complete el proceso
            MessageBox.Show("Proceso largo completado.");

            //Actualizar ListBox con un mensaje
            listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add("Hilo completado")));
        }

        private void MostrarModal()
        {
            using (Form modalForm = new Form())
            {
                modalForm.Text = "Contador Binario";
                modalForm.Size = new Size(200, 100);
                modalForm.StartPosition = FormStartPosition.CenterParent;
                modalForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                modalForm.MaximizeBox = false;
                modalForm.MinimizeBox = false;

                Label contadorLabel = new Label();
                contadorLabel.Text = "00001";
                contadorLabel.TextAlign = ContentAlignment.MiddleCenter;
                contadorLabel.Dock = DockStyle.Fill;

                modalForm.Controls.Add(contadorLabel);

                //Simular el contador binario (puedes implementar la lógica real aquí)
                int contador = 1;
                while (contador <= 31)
                {
                    string contadorBinario = Convert.ToString(contador, 2).PadLeft(5, '0');
                    contadorLabel.Text = contadorBinario;
                    Thread.Sleep(1000); //Actualizar cada segundo
                    contador++;
                }

                modalForm.ShowDialog();
            }
        }
    }
}
