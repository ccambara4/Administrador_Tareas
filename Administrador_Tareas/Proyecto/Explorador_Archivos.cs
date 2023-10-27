using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Administrador_Tareas.Proyecto
{
    public partial class Explorador_Archivos : MetroFramework.Forms.MetroForm
    {
        
        public Explorador_Archivos()
        {
            InitializeComponent();
            InitializeListView();
            PopulateDriveList();
        }

        private void Explorador_Archivos_Load(object sender, EventArgs e)
        {

        }

        private void InitializeListView()//Agregar iconos
        {
            listViewContent.View = View.Details;
            listViewContent.Columns.Add("Nombre", 300);
            listViewContent.Columns.Add("Tamaño", 100);
            listViewContent.Columns.Add("Tipo", 100);

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.DriveIcon);
            imageList.Images.Add(Properties.Resources.FolderIcon);
            imageList.Images.Add(Properties.Resources.FileIcon);

            listViewContent.SmallImageList = imageList;
        }

        private void PopulateDriveList()//Esto describe si es un disco o no
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                ListViewItem item = new ListViewItem(drive.Name);
                item.SubItems.Add("");
                item.SubItems.Add("Unidad de disco");
                item.ImageIndex = 0; //Ícono de disco
                item.Tag = drive.RootDirectory;
                listViewContent.Items.Add(item);
            }
        }

        private void PopulateDirectory(string path)//Aquí se describe si es una carpeta o archivo los datos dentro del disco
        {
            listViewContent.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(path);

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                ListViewItem item = new ListViewItem(subDir.Name);
                item.SubItems.Add("");
                item.SubItems.Add("Carpeta");
                item.ImageIndex = 1; //Ícono de carpeta
                item.Tag = subDir;
                listViewContent.Items.Add(item);
            }

            foreach (FileInfo file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Length.ToString());
                item.SubItems.Add("Archivo");
                item.ImageIndex = 2; //Ícono de archivo
                item.Tag = file;
                listViewContent.Items.Add(item);
            }
        }

        

        private void listViewContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContent.SelectedItems.Count > 0)
            {
                object selectedItem = listViewContent.SelectedItems[0].Tag;

                if (selectedItem is DriveInfo)
                {
                    PopulateDirectory((selectedItem as DriveInfo).RootDirectory.FullName);
                }
                else if (selectedItem is DirectoryInfo)
                {
                    PopulateDirectory((selectedItem as DirectoryInfo).FullName);
                }
                else if (selectedItem is FileInfo)
                {
                    //Si es un archivo, se abrirá con el programa predeterminado
                    FileInfo file = selectedItem as FileInfo;
                    Process.Start(file.FullName);
                }
            }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            PopulateDriveList();
            InitializeListView();

        }

        private void listViewContent_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
