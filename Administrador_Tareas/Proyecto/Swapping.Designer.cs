
namespace Administrador_Tareas.Proyecto
{
    partial class Swapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swapping));
            this.comboBoxLetra = new MetroFramework.Controls.MetroComboBox();
            this.textBoxNumero = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.listBoxPrincipal = new System.Windows.Forms.ListBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.comboBoxLetraEliminar = new MetroFramework.Controls.MetroComboBox();
            this.btnMoverAListaLetraSeleccionada = new MetroFramework.Controls.MetroButton();
            this.listBoxLetraSeleccionada = new System.Windows.Forms.ListBox();
            this.comboBoxLetraDevolver = new MetroFramework.Controls.MetroComboBox();
            this.btnDevolverAListaPrincipal = new MetroFramework.Controls.MetroButton();
            this.btnCerrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnVerProcesos = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLetra
            // 
            this.comboBoxLetra.FormattingEnabled = true;
            this.comboBoxLetra.ItemHeight = 23;
            this.comboBoxLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxLetra.Location = new System.Drawing.Point(24, 122);
            this.comboBoxLetra.Name = "comboBoxLetra";
            this.comboBoxLetra.Size = new System.Drawing.Size(121, 29);
            this.comboBoxLetra.TabIndex = 0;
            this.comboBoxLetra.UseSelectable = true;
            // 
            // textBoxNumero
            // 
            // 
            // 
            // 
            this.textBoxNumero.CustomButton.Image = null;
            this.textBoxNumero.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.textBoxNumero.CustomButton.Name = "";
            this.textBoxNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNumero.CustomButton.TabIndex = 1;
            this.textBoxNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNumero.CustomButton.UseSelectable = true;
            this.textBoxNumero.CustomButton.Visible = false;
            this.textBoxNumero.Lines = new string[0];
            this.textBoxNumero.Location = new System.Drawing.Point(25, 171);
            this.textBoxNumero.MaxLength = 32767;
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.PasswordChar = '\0';
            this.textBoxNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNumero.SelectedText = "";
            this.textBoxNumero.SelectionLength = 0;
            this.textBoxNumero.SelectionStart = 0;
            this.textBoxNumero.ShortcutsEnabled = true;
            this.textBoxNumero.Size = new System.Drawing.Size(120, 23);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.UseSelectable = true;
            this.textBoxNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.Location = new System.Drawing.Point(24, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 42);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Ingresar";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBoxPrincipal
            // 
            this.listBoxPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPrincipal.FormattingEnabled = true;
            this.listBoxPrincipal.ItemHeight = 16;
            this.listBoxPrincipal.Location = new System.Drawing.Point(226, 83);
            this.listBoxPrincipal.Name = "listBoxPrincipal";
            this.listBoxPrincipal.Size = new System.Drawing.Size(320, 260);
            this.listBoxPrincipal.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(24, 280);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 42);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseCustomBackColor = true;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboBoxLetraEliminar
            // 
            this.comboBoxLetraEliminar.FormattingEnabled = true;
            this.comboBoxLetraEliminar.ItemHeight = 23;
            this.comboBoxLetraEliminar.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxLetraEliminar.Location = new System.Drawing.Point(23, 453);
            this.comboBoxLetraEliminar.Name = "comboBoxLetraEliminar";
            this.comboBoxLetraEliminar.Size = new System.Drawing.Size(121, 29);
            this.comboBoxLetraEliminar.TabIndex = 5;
            this.comboBoxLetraEliminar.UseSelectable = true;
            // 
            // btnMoverAListaLetraSeleccionada
            // 
            this.btnMoverAListaLetraSeleccionada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMoverAListaLetraSeleccionada.Location = new System.Drawing.Point(23, 498);
            this.btnMoverAListaLetraSeleccionada.Name = "btnMoverAListaLetraSeleccionada";
            this.btnMoverAListaLetraSeleccionada.Size = new System.Drawing.Size(120, 42);
            this.btnMoverAListaLetraSeleccionada.TabIndex = 6;
            this.btnMoverAListaLetraSeleccionada.Text = "Bajar";
            this.btnMoverAListaLetraSeleccionada.UseCustomBackColor = true;
            this.btnMoverAListaLetraSeleccionada.UseSelectable = true;
            this.btnMoverAListaLetraSeleccionada.Click += new System.EventHandler(this.btnMoverAListaLetraSeleccionada_Click);
            // 
            // listBoxLetraSeleccionada
            // 
            this.listBoxLetraSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLetraSeleccionada.FormattingEnabled = true;
            this.listBoxLetraSeleccionada.ItemHeight = 16;
            this.listBoxLetraSeleccionada.Location = new System.Drawing.Point(226, 414);
            this.listBoxLetraSeleccionada.Name = "listBoxLetraSeleccionada";
            this.listBoxLetraSeleccionada.Size = new System.Drawing.Size(320, 260);
            this.listBoxLetraSeleccionada.TabIndex = 7;
            // 
            // comboBoxLetraDevolver
            // 
            this.comboBoxLetraDevolver.FormattingEnabled = true;
            this.comboBoxLetraDevolver.ItemHeight = 23;
            this.comboBoxLetraDevolver.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxLetraDevolver.Location = new System.Drawing.Point(622, 414);
            this.comboBoxLetraDevolver.Name = "comboBoxLetraDevolver";
            this.comboBoxLetraDevolver.Size = new System.Drawing.Size(121, 29);
            this.comboBoxLetraDevolver.TabIndex = 8;
            this.comboBoxLetraDevolver.UseSelectable = true;
            // 
            // btnDevolverAListaPrincipal
            // 
            this.btnDevolverAListaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDevolverAListaPrincipal.Location = new System.Drawing.Point(623, 459);
            this.btnDevolverAListaPrincipal.Name = "btnDevolverAListaPrincipal";
            this.btnDevolverAListaPrincipal.Size = new System.Drawing.Size(120, 42);
            this.btnDevolverAListaPrincipal.TabIndex = 9;
            this.btnDevolverAListaPrincipal.Text = "Subir";
            this.btnDevolverAListaPrincipal.UseCustomBackColor = true;
            this.btnDevolverAListaPrincipal.UseSelectable = true;
            this.btnDevolverAListaPrincipal.Click += new System.EventHandler(this.btnDevolverAListaPrincipal_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(727, 708);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCustomBackColor = true;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(9, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Ingrese el Proceso:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(9, 431);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Bajar Proceso:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(622, 392);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Subir Proceso:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(308, 61);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(146, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Procesos Ingresados";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(308, 392);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(126, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "Procesos Bajados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 267);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerProcesos
            // 
            this.btnVerProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerProcesos.Location = new System.Drawing.Point(324, 680);
            this.btnVerProcesos.Name = "btnVerProcesos";
            this.btnVerProcesos.Size = new System.Drawing.Size(120, 42);
            this.btnVerProcesos.TabIndex = 17;
            this.btnVerProcesos.Text = "Mostrar";
            this.btnVerProcesos.UseCustomBackColor = true;
            this.btnVerProcesos.UseSelectable = true;
            this.btnVerProcesos.Click += new System.EventHandler(this.btnVerProcesos_Click);
            // 
            // Swapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 812);
            this.Controls.Add(this.btnVerProcesos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDevolverAListaPrincipal);
            this.Controls.Add(this.comboBoxLetraDevolver);
            this.Controls.Add(this.listBoxLetraSeleccionada);
            this.Controls.Add(this.btnMoverAListaLetraSeleccionada);
            this.Controls.Add(this.comboBoxLetraEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.listBoxPrincipal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.comboBoxLetra);
            this.Name = "Swapping";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Swapping";
            this.Load += new System.EventHandler(this.Swapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox comboBoxLetra;
        private MetroFramework.Controls.MetroTextBox textBoxNumero;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.ListBox listBoxPrincipal;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroComboBox comboBoxLetraEliminar;
        private MetroFramework.Controls.MetroButton btnMoverAListaLetraSeleccionada;
        private System.Windows.Forms.ListBox listBoxLetraSeleccionada;
        private MetroFramework.Controls.MetroComboBox comboBoxLetraDevolver;
        private MetroFramework.Controls.MetroButton btnDevolverAListaPrincipal;
        private MetroFramework.Controls.MetroButton btnCerrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MetroFramework.Controls.MetroButton btnVerProcesos;
    }
}