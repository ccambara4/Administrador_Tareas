using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Administrador_Tareas.Proyecto
{
    public partial class Swapping : MetroFramework.Forms.MetroForm
    {
        private List<char> procesosCargados = new List<char>();
        public Swapping()
        {
            InitializeComponent();
            InicializarComboBox();
        }

        private void Swapping_Load(object sender, EventArgs e)
        {

        }

        private void InicializarComboBox()
        {
            // Llena el ComboBox con letras de A a G
            for (char c = 'A'; c <= 'G'; c++)
            {
                comboBoxProcesos.Items.Add(c);
                comboBoxProcesosCargados.Items.Add(c);
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCargarProceso_Click(object sender, EventArgs e)
        {
            char proceso = (char)comboBoxProcesos.SelectedItem;
            string datosProceso = textBoxDatosProceso.Text;
            string direccionMemoria = GenerarDireccionMemoria();

            // Agrega el proceso a la lista de procesos cargados
            procesosCargados.Add(proceso);

            // Muestra el proceso actual en el Label
            labelProcesoActual.Text = proceso.ToString();

            // Muestra los datos del proceso y la dirección de memoria
            textBoxDatosProcesoActual.Text = datosProceso;
            textBoxDireccionMemoria.Text = direccionMemoria;

            // Actualiza los TextBox de procesos cargados
            ActualizarTextBoxProcesosCargados();

            // Limpia los controles para el próximo proceso
            comboBoxProcesos.SelectedIndex = -1;
            textBoxDatosProceso.Clear();
        }

        private void ActualizarTextBoxProcesosCargados()
        {
            for (int i = 0; i < procesosCargados.Count && i < 5; i++)
            {
                TextBox textBox = Controls.Find($"textBoxProceso{i + 1}", true)[0] as TextBox;
                textBox.Text = procesosCargados[i].ToString();
            }
        }

        private string GenerarDireccionMemoria()
        {
            // Simplemente genera una dirección de memoria aleatoria
            Random random = new Random();
            return $"0x{random.Next(0x1000, 0xFFFF):X4}";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            char procesoSeleccionado = (char)comboBoxProcesosCargados.SelectedItem;
            procesosCargados.Remove(procesoSeleccionado);

            // Actualiza los TextBox de procesos cargados
            ActualizarTextBoxProcesosCargados();

            // Limpia los controles relacionados con el proceso eliminado
            labelProcesoActual.Text = "";
            textBoxDatosProcesoActual.Clear();
            textBoxDireccionMemoria.Clear();
        }
    }
}
