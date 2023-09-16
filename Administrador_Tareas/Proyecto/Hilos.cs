using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Administrador_Tareas.Proyecto
{
    public partial class Hilos : MetroFramework.Forms.MetroForm
    {
        public Hilos()
        {
            InitializeComponent();
        }

        private void Hilos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmbNumHilos.Text, out int numHilos))
            {
                //Limpiar ListBox y reiniciar contador binario
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                lblContadorBinario.Text = "00001";
                lblContadorBinario2.Text = "00001";
                lblContadorBinario3.Text = "00001";
                lblContadorBinario4.Text = "00001";

                //Crear y ejecutar tareas en paralelo
                Task.WhenAll(GenerarTareas(numHilos));
            }
            else
            {
                MessageBox.Show("Seleccione un número válido de hilos.");
            }
        }

        private Task[] GenerarTareas(int numHilos)
        {
            var tasks = new Task[numHilos];

            for (int i = 1; i <= numHilos; i++)
            {
                int id = i;
                tasks[i - 1] = ProcesoLargo(id);
            }

            return tasks;
        }

        private async Task ProcesoLargo(int id)
        {
            //Obtener la cantidad de iteraciones desde el ComboBox
            int numIteraciones = 0;
            this.Invoke((MethodInvoker)(() => numIteraciones = int.Parse(cmbNumHilos.Text)));

            // Realizar el proceso que dura 10 segundos
            for (int i = 1; i <= numIteraciones; i++)
            {
                await Task.Delay(1000); // Esperar un segundo

                // Actualizar los ListBox con el ID del hilo y el contador binario
                ActualizarListBox(id, i);

                // Actualizar el contador binario
                ActualizarContadorBinario();
            }
        }

        private void ActualizarListBox(int id, int valor)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                listBox1.Items.Add($"Hilo {id}: {valor:D2}");
                listBox2.Items.Add($"Hilo {id}: {valor:D2}");
                listBox3.Items.Add($"Hilo {id}: {valor:D2}");
                listBox4.Items.Add($"Hilo {id}: {valor:D2}");
            }));
        }

        private void ActualizarContadorBinario()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                int contador = Convert.ToInt32(lblContadorBinario.Text, 2);
                contador++;
                lblContadorBinario.Text = Convert.ToString(contador, 2).PadLeft(5, '0');
            }));

            this.Invoke((MethodInvoker)(() =>
            {
                int contador = Convert.ToInt32(lblContadorBinario2.Text, 2);
                contador++;
                lblContadorBinario2.Text = Convert.ToString(contador, 2).PadLeft(5, '0');
            }));

            this.Invoke((MethodInvoker)(() =>
            {
                int contador = Convert.ToInt32(lblContadorBinario3.Text, 2);
                contador++;
                lblContadorBinario3.Text = Convert.ToString(contador, 2).PadLeft(5, '0');
            }));

            this.Invoke((MethodInvoker)(() =>
            {
                int contador = Convert.ToInt32(lblContadorBinario4.Text, 2);
                contador++;
                lblContadorBinario4.Text = Convert.ToString(contador, 2).PadLeft(5, '0');
            }));
        }

        private void cmbNumHilos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
