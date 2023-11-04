
namespace Administrador_Tareas.Proyecto
{
    partial class Hilos
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
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            this.lblNumHilos = new MetroFramework.Controls.MetroLabel();
            this.cmbNumHilos = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.lblContadorBinario = new MetroFramework.Controls.MetroLabel();
            this.lblContadorBinario2 = new MetroFramework.Controls.MetroLabel();
            this.lblContadorBinario3 = new MetroFramework.Controls.MetroLabel();
            this.lblContadorBinario4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(171, 397);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 33);
            this.btnCerrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIniciar.Location = new System.Drawing.Point(23, 397);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 33);
            this.btnIniciar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseCustomBackColor = true;
            this.btnIniciar.UseSelectable = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblNumHilos
            // 
            this.lblNumHilos.AutoSize = true;
            this.lblNumHilos.Location = new System.Drawing.Point(23, 75);
            this.lblNumHilos.Name = "lblNumHilos";
            this.lblNumHilos.Size = new System.Drawing.Size(112, 19);
            this.lblNumHilos.TabIndex = 20;
            this.lblNumHilos.Text = "Número de Hilos:";
            // 
            // cmbNumHilos
            // 
            this.cmbNumHilos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNumHilos.FormattingEnabled = true;
            this.cmbNumHilos.ItemHeight = 23;
            this.cmbNumHilos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbNumHilos.Location = new System.Drawing.Point(142, 72);
            this.cmbNumHilos.Name = "cmbNumHilos";
            this.cmbNumHilos.Size = new System.Drawing.Size(121, 29);
            this.cmbNumHilos.TabIndex = 21;
            this.cmbNumHilos.UseSelectable = true;
            this.cmbNumHilos.SelectedIndexChanged += new System.EventHandler(this.cmbNumHilos_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 173);
            this.listBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(213, 160);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(158, 173);
            this.listBox2.TabIndex = 23;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(400, 160);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(158, 173);
            this.listBox3.TabIndex = 24;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(603, 160);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(158, 173);
            this.listBox4.TabIndex = 25;
            // 
            // lblContadorBinario
            // 
            this.lblContadorBinario.AutoSize = true;
            this.lblContadorBinario.Location = new System.Drawing.Point(66, 336);
            this.lblContadorBinario.Name = "lblContadorBinario";
            this.lblContadorBinario.Size = new System.Drawing.Size(69, 19);
            this.lblContadorBinario.TabIndex = 26;
            this.lblContadorBinario.Text = " Contador";
            // 
            // lblContadorBinario2
            // 
            this.lblContadorBinario2.AutoSize = true;
            this.lblContadorBinario2.Location = new System.Drawing.Point(260, 336);
            this.lblContadorBinario2.Name = "lblContadorBinario2";
            this.lblContadorBinario2.Size = new System.Drawing.Size(65, 19);
            this.lblContadorBinario2.TabIndex = 27;
            this.lblContadorBinario2.Text = "Contador";
            // 
            // lblContadorBinario3
            // 
            this.lblContadorBinario3.AutoSize = true;
            this.lblContadorBinario3.Location = new System.Drawing.Point(448, 336);
            this.lblContadorBinario3.Name = "lblContadorBinario3";
            this.lblContadorBinario3.Size = new System.Drawing.Size(65, 19);
            this.lblContadorBinario3.TabIndex = 28;
            this.lblContadorBinario3.Text = "Contador";
            // 
            // lblContadorBinario4
            // 
            this.lblContadorBinario4.AutoSize = true;
            this.lblContadorBinario4.Location = new System.Drawing.Point(653, 336);
            this.lblContadorBinario4.Name = "lblContadorBinario4";
            this.lblContadorBinario4.Size = new System.Drawing.Size(65, 19);
            this.lblContadorBinario4.TabIndex = 29;
            this.lblContadorBinario4.Text = "Contador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administrador_Tareas.Properties.Resources._200;
            this.pictureBox1.Location = new System.Drawing.Point(619, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContadorBinario4);
            this.Controls.Add(this.lblContadorBinario3);
            this.Controls.Add(this.lblContadorBinario2);
            this.Controls.Add(this.lblContadorBinario);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbNumHilos);
            this.Controls.Add(this.lblNumHilos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Hilos";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.Hilos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCerrar;
        private MetroFramework.Controls.MetroButton btnIniciar;
        private MetroFramework.Controls.MetroLabel lblNumHilos;
        private MetroFramework.Controls.MetroComboBox cmbNumHilos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private MetroFramework.Controls.MetroLabel lblContadorBinario;
        private MetroFramework.Controls.MetroLabel lblContadorBinario2;
        private MetroFramework.Controls.MetroLabel lblContadorBinario3;
        private MetroFramework.Controls.MetroLabel lblContadorBinario4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}