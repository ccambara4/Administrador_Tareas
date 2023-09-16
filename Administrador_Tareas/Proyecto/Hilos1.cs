using System;
using System.Windows.Forms;
using System.Threading;

namespace Administrador_Tareas.Proyecto
{
    public partial class Hilos1 : MetroFramework.Forms.MetroForm
    {
        public Hilos1()
        {
            InitializeComponent();
        }

        private void Hilos1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmbNumHilos.Text, out int numHilos))
            {
                // Limpiar ListBox y reiniciar contador binario
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                lblContadorBinario.Text = "00001";

                // Iniciar hilos
                for (int i = 0; i < numHilos; i++)
                {
                    Thread thread = new Thread(ProcesoLargo);
                    thread.Start();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un número válido de hilos.");
            }
        }

        private void ProcesoLargo()
        {
            // Generar un ID de hilo al azar
            Random random = new Random();
            int threadId = random.Next(1, 1000);

            // Agregar el ID del hilo actual a uno de los ListBox al azar
            int listBoxIndex = random.Next(1, 5);
            ListBox selectedListBox = GetRandomListBox(listBoxIndex);

            // Realizar el proceso que dura 10 segundos
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000); // Esperar un segundo
                // Actualizar el ListBox con el ID del hilo y el contador binario
                selectedListBox.Invoke((MethodInvoker)(() => selectedListBox.Items.Add($"Hilo {threadId}: {i:D2}")));

                // Actualizar el contador binario
                lblContadorBinario.Invoke((MethodInvoker)(() =>
                {
                    int contador = Convert.ToInt32(lblContadorBinario.Text, 2);
                    contador++;
                    lblContadorBinario.Text = Convert.ToString(contador, 2).PadLeft(5, '0');
                }));
            }
        }

        private ListBox GetRandomListBox(int index)
        {
            // Devuelve el ListBox correspondiente al índice
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
    }
}
