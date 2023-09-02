using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
