
namespace Administrador_Tareas
{
    partial class Menu
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
            this.Admin = new MetroFramework.Controls.MetroButton();
            this.Estados1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Red;
            this.Admin.Location = new System.Drawing.Point(53, 97);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(132, 44);
            this.Admin.Style = MetroFramework.MetroColorStyle.Green;
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Administrador";
            this.Admin.UseSelectable = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Estados1
            // 
            this.Estados1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Estados1.Location = new System.Drawing.Point(53, 172);
            this.Estados1.Name = "Estados1";
            this.Estados1.Size = new System.Drawing.Size(132, 44);
            this.Estados1.Style = MetroFramework.MetroColorStyle.Orange;
            this.Estados1.TabIndex = 1;
            this.Estados1.Text = "Estado de Procesos";
            this.Estados1.UseSelectable = true;
            this.Estados1.Click += new System.EventHandler(this.Estados1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Estados1);
            this.Controls.Add(this.Admin);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Admin;
        private MetroFramework.Controls.MetroButton Estados1;
    }
}