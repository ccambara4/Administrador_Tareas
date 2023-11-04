
namespace Administrador_Tareas.Proyecto
{
    partial class Menu_Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHora = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnApagar = new MetroFramework.Controls.MetroButton();
            this.comboBoxFormularios = new System.Windows.Forms.ComboBox();
            this.buttonAbrirSolucion = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Imge = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Black;
            this.lblHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHora.Location = new System.Drawing.Point(1799, 1040);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(94, 19);
            this.lblHora.Style = MetroFramework.MetroColorStyle.White;
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "metroLabel1";
            this.lblHora.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblHora.UseCustomBackColor = true;
            this.lblHora.UseStyleColors = true;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFecha.Location = new System.Drawing.Point(1784, 1059);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 19);
            this.lblFecha.Style = MetroFramework.MetroColorStyle.White;
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "metroLabel1";
            this.lblFecha.UseCustomBackColor = true;
            this.lblFecha.UseStyleColors = true;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(339, 1037);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 41);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnApagar.UseCustomBackColor = true;
            this.btnApagar.UseSelectable = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // comboBoxFormularios
            // 
            this.comboBoxFormularios.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormularios.FormattingEnabled = true;
            this.comboBoxFormularios.Items.AddRange(new object[] {
            "Menu",
            "Spotify",
            "Google Chrome",
            "Correo",
            "Word",
            "Explorador de Archivos"});
            this.comboBoxFormularios.Location = new System.Drawing.Point(14, 1040);
            this.comboBoxFormularios.Name = "comboBoxFormularios";
            this.comboBoxFormularios.Size = new System.Drawing.Size(179, 21);
            this.comboBoxFormularios.TabIndex = 11;
            this.comboBoxFormularios.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormularios_SelectedIndexChanged);
            // 
            // buttonAbrirSolucion
            // 
            this.buttonAbrirSolucion.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAbrirSolucion.Location = new System.Drawing.Point(199, 1037);
            this.buttonAbrirSolucion.Name = "buttonAbrirSolucion";
            this.buttonAbrirSolucion.Size = new System.Drawing.Size(120, 38);
            this.buttonAbrirSolucion.TabIndex = 12;
            this.buttonAbrirSolucion.Text = "Abrir";
            this.buttonAbrirSolucion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonAbrirSolucion.UseCustomBackColor = true;
            this.buttonAbrirSolucion.UseSelectable = true;
            this.buttonAbrirSolucion.Click += new System.EventHandler(this.buttonAbrirSolucion_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Black;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(1638, 1037);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "ESP";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Black;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(1638, 1059);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "LAA";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Administrador_Tareas.Properties.Resources._0cbf2f5c3fb37d033c0bc791ae196dbb;
            this.pictureBox10.Location = new System.Drawing.Point(0, 573);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1915, 505);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Administrador_Tareas.Properties.Resources.pngtree_wifi_vector_icon_png_image_963352;
            this.pictureBox9.Location = new System.Drawing.Point(1728, 1040);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 35);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Administrador_Tareas.Properties.Resources._5f477fa71490460004d4eca5;
            this.pictureBox8.Location = new System.Drawing.Point(1691, 1040);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Administrador_Tareas.Properties.Resources._588a64fed06f6719692a2d14;
            this.pictureBox7.Location = new System.Drawing.Point(773, 1037);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(39, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Administrador_Tareas.Properties.Resources.desktop_cb63bc3f_3347_4720_a7d1_478063b4ecd6;
            this.pictureBox3.Location = new System.Drawing.Point(1728, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Administrador_Tareas.Properties.Resources.original;
            this.pictureBox4.Location = new System.Drawing.Point(1081, 1037);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Administrador_Tareas.Properties.Resources._60922486_icono_del_sobre_enviar_correo_electrónico_la_muestra_del_mensaje_símbolo_de_correo_de_internet;
            this.pictureBox5.Location = new System.Drawing.Point(1017, 1037);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Administrador_Tareas.Properties.Resources._300221;
            this.pictureBox6.Location = new System.Drawing.Point(956, 1037);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Administrador_Tareas.Properties.Resources._174872;
            this.pictureBox2.Location = new System.Drawing.Point(898, 1037);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Imge
            // 
            this.Imge.Image = global::Administrador_Tareas.Properties.Resources._3767084;
            this.Imge.Location = new System.Drawing.Point(837, 1037);
            this.Imge.Name = "Imge";
            this.Imge.Size = new System.Drawing.Size(39, 38);
            this.Imge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imge.TabIndex = 4;
            this.Imge.TabStop = false;
            this.Imge.Click += new System.EventHandler(this.Imge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administrador_Tareas.Properties.Resources.imagenes_de_paisajes_hermosos_4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1915, 1034);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1081);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonAbrirSolucion);
            this.Controls.Add(this.comboBoxFormularios);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Imge);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox10);
            this.Name = "Menu_Inicio";
            this.RightToLeftLayout = true;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Menu_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private System.Windows.Forms.PictureBox Imge;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private MetroFramework.Controls.MetroButton btnApagar;
        private System.Windows.Forms.ComboBox comboBoxFormularios;
        private MetroFramework.Controls.MetroButton buttonAbrirSolucion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}