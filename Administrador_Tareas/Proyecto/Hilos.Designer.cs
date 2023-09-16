
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
            this.cmbNumHilos.FormattingEnabled = true;
            this.cmbNumHilos.ItemHeight = 23;
            this.cmbNumHilos.Location = new System.Drawing.Point(142, 72);
            this.cmbNumHilos.Name = "cmbNumHilos";
            this.cmbNumHilos.Size = new System.Drawing.Size(121, 29);
            this.cmbNumHilos.TabIndex = 21;
            this.cmbNumHilos.UseSelectable = true;
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
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContadorBinario);
            this.Controls.Add(this.cmbNumHilos);
            this.Controls.Add(this.lblNumHilos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Hilos";
            this.Text = "s";
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
    }
}