
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Imge = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lblHora.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHora.Location = new System.Drawing.Point(1008, 707);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(94, 19);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "metroLabel1";
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
            this.lblFecha.Location = new System.Drawing.Point(993, 726);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "metroLabel1";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(196, 707);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 38);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseCustomBackColor = true;
            this.btnApagar.UseSelectable = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // comboBoxFormularios
            // 
            this.comboBoxFormularios.FormattingEnabled = true;
            this.comboBoxFormularios.Items.AddRange(new object[] {
            "Menu",
            "Spotify",
            "Google Chrome",
            "Correo",
            "Word"});
            this.comboBoxFormularios.Location = new System.Drawing.Point(11, 710);
            this.comboBoxFormularios.Name = "comboBoxFormularios";
            this.comboBoxFormularios.Size = new System.Drawing.Size(179, 21);
            this.comboBoxFormularios.TabIndex = 11;
            // 
            // buttonAbrirSolucion
            // 
            this.buttonAbrirSolucion.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAbrirSolucion.Location = new System.Drawing.Point(290, 707);
            this.buttonAbrirSolucion.Name = "buttonAbrirSolucion";
            this.buttonAbrirSolucion.Size = new System.Drawing.Size(75, 38);
            this.buttonAbrirSolucion.TabIndex = 12;
            this.buttonAbrirSolucion.Text = "Abrir";
            this.buttonAbrirSolucion.UseCustomBackColor = true;
            this.buttonAbrirSolucion.UseSelectable = true;
            this.buttonAbrirSolucion.Click += new System.EventHandler(this.buttonAbrirSolucion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Administrador_Tareas.Properties.Resources.desktop_cb63bc3f_3347_4720_a7d1_478063b4ecd6;
            this.pictureBox3.Location = new System.Drawing.Point(937, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Administrador_Tareas.Properties.Resources.original;
            this.pictureBox4.Location = new System.Drawing.Point(629, 707);
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
            this.pictureBox5.Location = new System.Drawing.Point(565, 707);
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
            this.pictureBox6.Location = new System.Drawing.Point(504, 707);
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
            this.pictureBox2.Location = new System.Drawing.Point(446, 707);
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
            this.Imge.Location = new System.Drawing.Point(385, 707);
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
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1116, 704);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 746);
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
            this.Name = "Menu_Inicio";
            this.RightToLeftLayout = true;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Menu_Inicio_Load);
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
    }
}