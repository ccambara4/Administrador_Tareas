using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Administrador_Tareas.Proyecto
{
    public partial class Swapping: MetroFramework.Forms.MetroForm
    {
        private List<string> listaPrincipal = new List<string>();
        private List<string> listaLetraSeleccionada = new List<string>();
        private Dictionary<string, IntPtr> memoriaRam = new Dictionary<string, IntPtr>();

        /*No utiliza punteros, pero simula el uso de memoria 
         * RAM utilizando un diccionario para realizar un 
         * seguimiento de la memoria asignada y liberada.*/


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
                MessageBox.Show("Por favor, ingrese un número válido.");//Mensaje de Error
                return;
            }

            string elemento = $"{letra} - {numero}";
            listaPrincipal.Add(elemento);

            //Simular el uso de memoria RAM y obtener la dirección del puntero
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)));
            memoriaRam[elemento] = ptr;

            ActualizarListBoxPrincipal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

            for (int i = listBoxLetraSeleccionada.Items.Count - 1; i >= 0; i--)
            {
                string elemento = listBoxLetraSeleccionada.Items[i].ToString();
                if (elemento.StartsWith(letra))
                {
                    listBoxLetraSeleccionada.Items.RemoveAt(i);
                    listaPrincipal.Add(elemento);
                    listBoxPrincipal.Items.Add(elemento);
                }
            }
            ActualizarListBoxPrincipal();
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

        private void ActualizarListBoxLetraSeleccionada()//Actauliza la listbox de donde se baja el poroceso
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
    }
}
