
namespace Administrador_Tareas
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
            this.txtNumHilos = new MetroFramework.Controls.MetroTextBox();
            this.lblNumHilos = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtNumHilos
            // 
            // 
            // 
            // 
            this.txtNumHilos.CustomButton.Image = null;
            this.txtNumHilos.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txtNumHilos.CustomButton.Name = "";
            this.txtNumHilos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumHilos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumHilos.CustomButton.TabIndex = 1;
            this.txtNumHilos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumHilos.CustomButton.UseSelectable = true;
            this.txtNumHilos.CustomButton.Visible = false;
            this.txtNumHilos.Lines = new string[0];
            this.txtNumHilos.Location = new System.Drawing.Point(144, 78);
            this.txtNumHilos.MaxLength = 32767;
            this.txtNumHilos.Name = "txtNumHilos";
            this.txtNumHilos.PasswordChar = '\0';
            this.txtNumHilos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumHilos.SelectedText = "";
            this.txtNumHilos.SelectionLength = 0;
            this.txtNumHilos.SelectionStart = 0;
            this.txtNumHilos.ShortcutsEnabled = true;
            this.txtNumHilos.Size = new System.Drawing.Size(86, 23);
            this.txtNumHilos.TabIndex = 0;
            this.txtNumHilos.UseSelectable = true;
            this.txtNumHilos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumHilos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumHilos
            // 
            this.lblNumHilos.AutoSize = true;
            this.lblNumHilos.Location = new System.Drawing.Point(24, 78);
            this.lblNumHilos.Name = "lblNumHilos";
            this.lblNumHilos.Size = new System.Drawing.Size(112, 19);
            this.lblNumHilos.TabIndex = 1;
            this.lblNumHilos.Text = "Número de Hilos:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 199);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(206, 171);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 199);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(385, 171);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(154, 199);
            this.listBox3.TabIndex = 4;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(565, 171);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(154, 199);
            this.listBox4.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Highlight = true;
            this.btnIniciar.Location = new System.Drawing.Point(24, 395);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 33);
            this.btnIniciar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseSelectable = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Hilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNumHilos);
            this.Controls.Add(this.txtNumHilos);
            this.Name = "Hilos";
            this.Text = "Hilos";
            this.Load += new System.EventHandler(this.Hilos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNumHilos;
        private MetroFramework.Controls.MetroLabel lblNumHilos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private MetroFramework.Controls.MetroButton btnIniciar;
    }
}