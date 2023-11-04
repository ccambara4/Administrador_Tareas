using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_Tareas.Proyecto
{
    public partial class Menu_Inicio : MetroFramework.Forms.MetroForm
    {
        public Menu_Inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Menu_Inicio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void Imge_Click(object sender, EventArgs e)
        {
            Explorador_Archivos ventana = new Explorador_Archivos();
            ventana.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("spotify:");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAbrirSolucion_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxFormularios.SelectedIndex;

            // Verifica si se ha seleccionado un índice válido en el ComboBox.
            if (selectedIndex >= 0)
            {
                // Abre el formulario correspondiente basado en el índice seleccionado.
                switch (selectedIndex)
                {
                    case 0:
                        // Abre el formulario "Menu".
                        Menu menuForm = new Menu();
                        menuForm.Show();
                        break;
                    case 1:
                        System.Diagnostics.Process.Start("spotify:");
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("chrome");
                        break;
                    case 3:
                        System.Diagnostics.Process.Start("mailto:");
                        break;
                    case 4:
                        System.Diagnostics.Process.Start("winword.exe");
                        break;

                    case 5:
                        Explorador_Archivos exploraForm = new Explorador_Archivos();
                        exploraForm.Show();
                        break;
                       
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un formulario antes de abrir.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Visible = true;
        }

        private void comboBoxFormularios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
