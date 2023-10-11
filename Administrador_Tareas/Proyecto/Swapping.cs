using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Administrador_Tareas.Proyecto
{
    public partial class Swapping: MetroFramework.Forms.MetroForm
    {
        private List<string> listaPrincipal = new List<string>();
        private List<string> listaLetraSeleccionada = new List<string>();
        private Dictionary<string, IntPtr> memoriaRam = new Dictionary<string, IntPtr>();
        /*Lleva un registro de las asignaciones de memoria 
         * no administrada hechas en la aplicación*/


        public Swapping()
        {
            InitializeComponent();
            _ = comboBoxLetra.SelectedIndex;
        }

        private void Swapping_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string letra = comboBoxLetra.SelectedItem.ToString();
            int numero;

            if (!int.TryParse(textBoxNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                return;
            }

            string elemento = $"{letra} - {numero}";
            listaPrincipal.Add(elemento);

            //Uso de punteros para asignar el número de espacio en la memoria RAM
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)));/*se utiliza para asignar un bloque de memoria no administrada 
                                                                            * del tamaño de un entero (int) en la memoria no administrada 
                                                                            * y obtener un puntero a esa memoria*/

            memoriaRam[elemento] = ptr;//Se utiliza para almacenar un puntero en un diccionario llamado memoriaRam

            ActualizarListBoxPrincipal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)//Eliminar el proceso ingresado
        {
            string letra = comboBoxLetra.SelectedItem.ToString();

            for (int i = listaPrincipal.Count - 1; i >= 0; i--)
            {
                string elemento = listaPrincipal[i];
                if (elemento.StartsWith(letra))
                {
                    listaPrincipal.RemoveAt(i);
                    IntPtr ptr = memoriaRam[elemento];
                    memoriaRam.Remove(elemento);
                    Marshal.FreeHGlobal(ptr);
                }
            }


            ActualizarListBoxPrincipal();
        }




        private void btnMoverAListaLetraSeleccionada_Click(object sender, EventArgs e)//Este es para bajar los procesos
        {
            string letra = comboBoxLetra.SelectedItem.ToString();
            int numero;

            if (!int.TryParse(textBoxNumero.Text, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");//Mensaje de Error
                return;
            }

            string elemento = $"{letra} - {numero}";
            listaPrincipal.Remove(elemento);
            listBoxPrincipal.Items.Remove(elemento);

            listaLetraSeleccionada.Add(elemento);
            ActualizarListBoxLetraSeleccionada();
            ActualizarListBoxPrincipal();
        }

        private void btnDevolverAListaPrincipal_Click(object sender, EventArgs e)//Este sube de nuevo los procesos 
        {
            string letra = comboBoxLetraDevolver.SelectedItem.ToString();

            for (int i = listaLetraSeleccionada.Count - 1; i >= 0; i--)
            {
                string elemento = listaLetraSeleccionada[i];
                if (elemento.StartsWith(letra))
                {
                    listaLetraSeleccionada.RemoveAt(i);
                    listaPrincipal.Add(elemento);
                    ActualizarListBoxPrincipal();

                    //Liberar la memoria asignada al elemento devuelto
                    IntPtr ptr = memoriaRam[elemento];
                    Marshal.FreeHGlobal(ptr);
                }
            }
            ActualizarListBoxPrincipal();
            ActualizarListBoxLetraSeleccionada();
        }


        private void ActualizarListBoxPrincipal()//Actualiza la listbox Principal
        {
            listBoxPrincipal.Items.Clear();
            foreach (var elemento in listaPrincipal)
            {
                IntPtr ptr = memoriaRam[elemento];
                listBoxPrincipal.Items.Add($"{elemento} (Memoria RAM: 0x{ptr.ToInt64():X})");
            }
        }

        private void ActualizarListBoxLetraSeleccionada()//Actualiza la listbox de donde se baja el poroceso
        {
            listBoxLetraSeleccionada.Items.Clear();
            foreach (var letra in listaLetraSeleccionada)
            {
                listBoxLetraSeleccionada.Items.Add(letra);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)//Guarda los procesos bajados
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllLines(filePath, listaLetraSeleccionada);
            }

            ActualizarListBoxLetraSeleccionada();
        }

        private void btnMostrarDatos_Click_1(object sender, EventArgs e)//Muestra el archivo txt
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de Texto|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    string contenido = string.Join(Environment.NewLine, lines);
                    MessageBox.Show("Contenido del archivo:\n\n" + contenido, "Datos del Archivo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El archivo está vacío.", "Archivo Vacío",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            ActualizarListBoxLetraSeleccionada();
        }
    }
}
