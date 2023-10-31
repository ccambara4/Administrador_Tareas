using Administrador_Tareas.Proyecto;
using System;

namespace Administrador_Tareas
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Administrador ventana = new Administrador();
            ventana.Visible = true;
        }

        private void Estados1_Click(object sender, EventArgs e)
        {
            Procesos ventana = new Procesos();
            ventana.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHilos_Click(object sender, EventArgs e)
        {
            Hilos ventana = new Hilos();
            ventana.Visible = true;
        }
        private void btnSwap_Click_1(object sender, EventArgs e)
        {
            Swapping ventana = new Swapping();
            ventana.Visible = true;
        }

        private void Explorador_Click(object sender, EventArgs e)
        {
            Explorador_Archivos ventana = new Explorador_Archivos();
            ventana.Visible = true;
        }

        
    }
}
