
namespace Administrador_Tareas.Proyecto
{
    partial class Explorador_Archivos
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
            this.listViewContent = new MetroFramework.Controls.MetroListView();
            this.btnAtras = new MetroFramework.Controls.MetroButton();
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewContent
            // 
            this.listViewContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewContent.FullRowSelect = true;
            this.listViewContent.Location = new System.Drawing.Point(23, 92);
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.OwnerDraw = true;
            this.listViewContent.Size = new System.Drawing.Size(613, 807);
            this.listViewContent.TabIndex = 0;
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.UseSelectable = true;
            this.listViewContent.View = System.Windows.Forms.View.List;
            this.listViewContent.SelectedIndexChanged += new System.EventHandler(this.listViewContent_SelectedIndexChanged);
            this.listViewContent.DoubleClick += new System.EventHandler(this.listViewContent_DoubleClick);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAtras.Location = new System.Drawing.Point(18, 905);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(171, 61);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseCustomBackColor = true;
            this.btnAtras.UseSelectable = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(381, 905);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(171, 61);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administrador_Tareas.Properties.Resources.HNWT6DgoBc14riaEeLCzGYopkqYBKxpGKqfNWfgr368M9Wbc2mPg5qHxhnPM8zfB8kwegedjUrd4Kft9qVNUSNpjVheDqPjbVPZ2LY9tV2kUAoa7z8LMnG9Bazh;
            this.pictureBox1.Location = new System.Drawing.Point(658, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 425);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Explorador_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 1006);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.listViewContent);
            this.Name = "Explorador_Archivos";
            this.Text = "Explorador de Archivos";
            this.Load += new System.EventHandler(this.Explorador_Archivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewContent;
        private MetroFramework.Controls.MetroButton btnAtras;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}