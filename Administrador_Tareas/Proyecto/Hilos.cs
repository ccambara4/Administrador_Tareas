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

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Solicitar al usuario la cantidad de hilos
            int numHilos;
            if (int.TryParse(txtNumHilos.Text, out numHilos))
            {
                //Limpiar ListBox
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
            //Generar un ID de hilo al azar
            Random random = new Random();
            int threadId = random.Next(1, 1000);

            //Agregar el ID del hilo actual a uno de los ListBox al azar
            int listBoxIndex = random.Next(1, 5);
            ListBox selectedListBox = GetRandomListBox(listBoxIndex);

            //Simular un proceso largo
            int numIteraciones = 0;
            this.Invoke((MethodInvoker)(() => numIteraciones = int.Parse(txtNumHilos.Text)));
            for (int i = 1; i <= numIteraciones; i++)
            {
                Thread.Sleep(1000); //Esperar un segundo
                //Actualizar el ListBox con el ID del hilo y el contador binario
                selectedListBox.Invoke((MethodInvoker)(() => selectedListBox.Items.Add($"Hilo {threadId}: {i:D2}")));
            }
        }

        private ListBox GetRandomListBox(int index)
        {
            //Devuelve el ListBox correspondiente al índice
            switch (index)
            {
                case 1:
                    return listBox1;
                case 2:
                    return listBox2;
                case 3:
                    return listBox3;
                case 4:
                    return listBox4;
                default:
                    return listBox1;
            }
        }

        private void MostrarModal()
        {
            using (Form modalForm = new Form())
            {
                modalForm.Text = "Contador Binario";
                modalForm.Size = new System.Drawing.Size(200, 100);
                modalForm.StartPosition = FormStartPosition.CenterScreen;
                modalForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                modalForm.MaximizeBox = false;
                modalForm.MinimizeBox = false;

                Label contadorLabel = new Label();
                contadorLabel.Text = "00001";
                contadorLabel.TextAlign = ContentAlignment.MiddleCenter;
                contadorLabel.Dock = DockStyle.Fill;

                modalForm.Controls.Add(contadorLabel);

                int contador = 1;
                while (contador <= 31)
                {
                    string contadorBinario = Convert.ToString(contador, 2).PadLeft(5, '0');
                    contadorLabel.Text = contadorBinario;
                    Thread.Sleep(1000);
                    contador++;
                }

                modalForm.ShowDialog();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumHilos_Click(object sender, EventArgs e)
        {

        }

        private void lblNumHilos_Click(object sender, EventArgs e)
        {

        }
    }
}
