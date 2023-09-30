
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
            this.btnHilos = new MetroFramework.Controls.MetroButton();
            this.btnSwap = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Yellow;
            this.Admin.Location = new System.Drawing.Point(108, 167);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(176, 51);
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
            this.Estados1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Estados1.Location = new System.Drawing.Point(108, 245);
            this.Estados1.Name = "Estados1";
            this.Estados1.Size = new System.Drawing.Size(176, 51);
            this.Estados1.Style = MetroFramework.MetroColorStyle.Green;
            this.Estados1.TabIndex = 1;
            this.Estados1.Text = "Estado de Procesos";
            this.Estados1.UseCustomBackColor = true;
            this.Estados1.UseSelectable = true;
            this.Estados1.Click += new System.EventHandler(this.Estados1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ActiveControl = null;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Location = new System.Drawing.Point(623, 438);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(122, 37);
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
            this.metroLabel1.Location = new System.Drawing.Point(22, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Escoja un opción:";
            // 
            // btnHilos
            // 
            this.btnHilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHilos.Location = new System.Drawing.Point(108, 324);
            this.btnHilos.Name = "btnHilos";
            this.btnHilos.Size = new System.Drawing.Size(176, 51);
            this.btnHilos.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnHilos.TabIndex = 5;
            this.btnHilos.Text = "Hilos";
            this.btnHilos.UseCustomBackColor = true;
            this.btnHilos.UseSelectable = true;
            this.btnHilos.Click += new System.EventHandler(this.btnHilos_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSwap.Location = new System.Drawing.Point(330, 167);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(176, 51);
            this.btnSwap.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSwap.TabIndex = 6;
            this.btnSwap.Text = "Proceso en Ram";
            this.btnSwap.UseCustomBackColor = true;
            this.btnSwap.UseSelectable = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click_1);
            // 
            // Menu
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackMaxSize = 5;
            this.ClientSize = new System.Drawing.Size(858, 537);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btnHilos);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Estados1);
            this.Controls.Add(this.Admin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(26, 69, 26, 23);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
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
        private MetroFramework.Controls.MetroButton btnHilos;
        private MetroFramework.Controls.MetroButton btnSwap;
    }
}