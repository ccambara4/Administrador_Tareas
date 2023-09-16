
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
            this.lblContadorBinario = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(160, 394);
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
            this.btnIniciar.Location = new System.Drawing.Point(23, 394);
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
            "5"});
            this.cmbNumHilos.Location = new System.Drawing.Point(142, 72);
            this.cmbNumHilos.Name = "cmbNumHilos";
            this.cmbNumHilos.Size = new System.Drawing.Size(121, 29);
            this.cmbNumHilos.TabIndex = 21;
            this.cmbNumHilos.UseSelectable = true;
            this.cmbNumHilos.SelectedIndexChanged += new System.EventHandler(this.cmbNumHilos_SelectedIndexChanged);
            // 
            // lblContadorBinario
            // 
            this.lblContadorBinario.AutoSize = true;
            this.lblContadorBinario.Location = new System.Drawing.Point(441, 407);
            this.lblContadorBinario.Name = "lblContadorBinario";
            this.lblContadorBinario.Size = new System.Drawing.Size(65, 19);
            this.lblContadorBinario.TabIndex = 22;
            this.lblContadorBinario.Text = "Contador";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(594, 130);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Hilos No. 4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(413, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Hilos No. 3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(231, 130);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Hilos No. 2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Silver;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(49, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Hilos No. 1";
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(564, 152);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(154, 199);
            this.listBox4.TabIndex = 30;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(384, 152);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(154, 199);
            this.listBox3.TabIndex = 29;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(205, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 199);
            this.listBox2.TabIndex = 28;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 199);
            this.listBox1.TabIndex = 27;
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblContadorBinario);
            this.Controls.Add(this.cmbNumHilos);
            this.Controls.Add(this.lblNumHilos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Hilos";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.Hilos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCerrar;
        private MetroFramework.Controls.MetroButton btnIniciar;
        private MetroFramework.Controls.MetroLabel lblNumHilos;
        private MetroFramework.Controls.MetroComboBox cmbNumHilos;
        private MetroFramework.Controls.MetroLabel lblContadorBinario;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}