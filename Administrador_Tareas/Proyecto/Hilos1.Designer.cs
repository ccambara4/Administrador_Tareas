
namespace Administrador_Tareas.Proyecto
{
    partial class Hilos1
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
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblNumHilos = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.cmbNumHilos = new MetroFramework.Controls.MetroComboBox();
            this.lblContadorBinario = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnIniciar.Location = new System.Drawing.Point(23, 378);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 33);
            this.btnIniciar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseCustomBackColor = true;
            this.btnIniciar.UseSelectable = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(564, 163);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(154, 199);
            this.listBox4.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(384, 163);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(154, 199);
            this.listBox3.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(205, 163);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 199);
            this.listBox2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 199);
            this.listBox1.TabIndex = 8;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(606, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Hilos No. 4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(425, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Hilos No. 3";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(243, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Hilos No. 2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Silver;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(61, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Hilos No. 1";
            // 
            // lblNumHilos
            // 
            this.lblNumHilos.AutoSize = true;
            this.lblNumHilos.Location = new System.Drawing.Point(23, 80);
            this.lblNumHilos.Name = "lblNumHilos";
            this.lblNumHilos.Size = new System.Drawing.Size(112, 19);
            this.lblNumHilos.TabIndex = 16;
            this.lblNumHilos.Text = "Número de Hilos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(160, 378);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 33);
            this.btnCerrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
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
            this.cmbNumHilos.Location = new System.Drawing.Point(141, 70);
            this.cmbNumHilos.Name = "cmbNumHilos";
            this.cmbNumHilos.Size = new System.Drawing.Size(121, 29);
            this.cmbNumHilos.TabIndex = 18;
            this.cmbNumHilos.UseSelectable = true;
            // 
            // lblContadorBinario
            // 
            this.lblContadorBinario.AutoSize = true;
            this.lblContadorBinario.Location = new System.Drawing.Point(508, 392);
            this.lblContadorBinario.Name = "lblContadorBinario";
            this.lblContadorBinario.Size = new System.Drawing.Size(65, 19);
            this.lblContadorBinario.TabIndex = 19;
            this.lblContadorBinario.Text = "Contador";
            // 
            // Hilos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContadorBinario);
            this.Controls.Add(this.cmbNumHilos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNumHilos);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Hilos1";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.Hilos1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnIniciar;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblNumHilos;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private MetroFramework.Controls.MetroComboBox cmbNumHilos;
        private MetroFramework.Controls.MetroLabel lblContadorBinario;
    }
}