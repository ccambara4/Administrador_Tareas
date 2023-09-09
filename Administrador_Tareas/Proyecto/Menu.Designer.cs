
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Admin = new MetroFramework.Controls.MetroButton();
            this.Estados1 = new MetroFramework.Controls.MetroButton();
            this.btnCerrar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Yellow;
            this.Admin.Location = new System.Drawing.Point(62, 143);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(154, 44);
            this.Admin.Style = MetroFramework.MetroColorStyle.Blue;
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Administrador";
            this.Admin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Admin.UseCustomBackColor = true;
            this.Admin.UseSelectable = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Estados1
            // 
            this.Estados1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Estados1.Location = new System.Drawing.Point(62, 211);
            this.Estados1.Name = "Estados1";
            this.Estados1.Size = new System.Drawing.Size(154, 44);
            this.Estados1.Style = MetroFramework.MetroColorStyle.Green;
            this.Estados1.TabIndex = 1;
            this.Estados1.Text = "Estado de Procesos";
            this.Estados1.UseSelectable = true;
            this.Estados1.UseStyleColors = true;
            this.Estados1.Click += new System.EventHandler(this.Estados1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveControl = null;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Location = new System.Drawing.Point(62, 344);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 42);
            this.btnCerrar.Style = MetroFramework.MetroColorStyle.Red;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(47, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Escoja un opción:";
            // 
            // Menu
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Estados1);
            this.Controls.Add(this.Admin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.RightToLeftLayout = true;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Menú";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Admin;
        private MetroFramework.Controls.MetroButton Estados1;
        private MetroFramework.Controls.MetroTile btnCerrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}