using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador_Tareas
{
    public partial class Form1 : MetroFramework.Forms.MetroForm//Aquí se coloca la librería para darle estilo a la ventana
    {
        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
        }

        private void UpdateProcessList()//Actualizar la ventana
        {
            dgvAdministrador.Rows.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgvAdministrador.Rows.Add();
                dgvAdministrador.Rows[n].Cells[0].Value = p.ProcessName;//Nombre del Proceso
                dgvAdministrador.Rows[n].Cells[1].Value = p.Id;
                dgvAdministrador.Rows[n].Cells[2].Value = p.WorkingSet64;//Memoria Física
                dgvAdministrador.Rows[n].Cells[3].Value = p.VirtualMemorySize64;//Memoria Virtual
                dgvAdministrador.Rows[n].Cells[4].Value = p.SessionId;//Uso de CPU

            }
            txtContador.Text = "Procesos Actuales: " + dgvAdministrador.Rows.Count.ToString();//Mensaje

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();//Mostrar el proceso del label
        }

        private void btnActualizar_Click(object sender, EventArgs e)//Boton Actualizar
        {
            UpdateProcessList();//Aqí llamamos a la subclase para actualizasar la ventana
        }

        private void btnDetener_Click(object sender, EventArgs e)//Detener
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName == txtProceso.Text)
                    {
                        p.Kill();//Eliminar Proceso
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("No ha seleccionado ningún proceso " + x, "Error al eliminar", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)//Salir
        {
            Close();
        }
    }
}
