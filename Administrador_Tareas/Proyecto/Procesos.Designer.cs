
namespace Administrador_Tareas
{
    partial class Procesos
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
            this.nombreEstadoTextBox = new System.Windows.Forms.TextBox();
            this.crearEstadoButton = new System.Windows.Forms.Button();
            this.estadosListBox = new System.Windows.Forms.ListBox();
            this.iniciarButton = new System.Windows.Forms.Button();
            this.historialListBox = new System.Windows.Forms.ListBox();
            this.tiempoTranscurridoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operacionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreEstadoTextBox
            // 
            this.nombreEstadoTextBox.Location = new System.Drawing.Point(61, 131);
            this.nombreEstadoTextBox.Name = "nombreEstadoTextBox";
            this.nombreEstadoTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreEstadoTextBox.TabIndex = 0;
            // 
            // crearEstadoButton
            // 
            this.crearEstadoButton.BackColor = System.Drawing.Color.Yellow;
            this.crearEstadoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearEstadoButton.Location = new System.Drawing.Point(529, 294);
            this.crearEstadoButton.Name = "crearEstadoButton";
            this.crearEstadoButton.Size = new System.Drawing.Size(259, 34);
            this.crearEstadoButton.TabIndex = 2;
            this.crearEstadoButton.Text = "Crear";
            this.crearEstadoButton.UseVisualStyleBackColor = false;
            this.crearEstadoButton.Click += new System.EventHandler(this.crearEstadoButton_Click);
            // 
            // estadosListBox
            // 
            this.estadosListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadosListBox.FormattingEnabled = true;
            this.estadosListBox.ItemHeight = 16;
            this.estadosListBox.Items.AddRange(new object[] {
            "Nombre:"});
            this.estadosListBox.Location = new System.Drawing.Point(211, 44);
            this.estadosListBox.Name = "estadosListBox";
            this.estadosListBox.Size = new System.Drawing.Size(531, 212);
            this.estadosListBox.TabIndex = 3;
            this.estadosListBox.SelectedIndexChanged += new System.EventHandler(this.estadosListBox_SelectedIndexChanged);
            // 
            // iniciarButton
            // 
            this.iniciarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarButton.Location = new System.Drawing.Point(529, 334);
            this.iniciarButton.Name = "iniciarButton";
            this.iniciarButton.Size = new System.Drawing.Size(259, 38);
            this.iniciarButton.TabIndex = 4;
            this.iniciarButton.Text = "Iniciar";
            this.iniciarButton.UseVisualStyleBackColor = false;
            this.iniciarButton.Click += new System.EventHandler(this.iniciarButton_Click);
            // 
            // historialListBox
            // 
            this.historialListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialListBox.FormattingEnabled = true;
            this.historialListBox.ItemHeight = 16;
            this.historialListBox.Items.AddRange(new object[] {
            "ID    Nombre    Estado    Fecha/Hora"});
            this.historialListBox.Location = new System.Drawing.Point(15, 304);
            this.historialListBox.Name = "historialListBox";
            this.historialListBox.Size = new System.Drawing.Size(491, 132);
            this.historialListBox.TabIndex = 5;
            this.historialListBox.SelectedIndexChanged += new System.EventHandler(this.historialListBox_SelectedIndexChanged);
            // 
            // tiempoTranscurridoTextBox
            // 
            this.tiempoTranscurridoTextBox.Location = new System.Drawing.Point(529, 418);
            this.tiempoTranscurridoTextBox.Name = "tiempoTranscurridoTextBox";
            this.tiempoTranscurridoTextBox.Size = new System.Drawing.Size(259, 20);
            this.tiempoTranscurridoTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo:";
            // 
            // operacionComboBox
            // 
            this.operacionComboBox.FormattingEnabled = true;
            this.operacionComboBox.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División",
            "Texto"});
            this.operacionComboBox.Location = new System.Drawing.Point(61, 175);
            this.operacionComboBox.Name = "operacionComboBox";
            this.operacionComboBox.Size = new System.Drawing.Size(121, 21);
            this.operacionComboBox.TabIndex = 9;
            this.operacionComboBox.SelectedIndexChanged += new System.EventHandler(this.operacionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bitácora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Procesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Datos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operacionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiempoTranscurridoTextBox);
            this.Controls.Add(this.historialListBox);
            this.Controls.Add(this.iniciarButton);
            this.Controls.Add(this.estadosListBox);
            this.Controls.Add(this.crearEstadoButton);
            this.Controls.Add(this.nombreEstadoTextBox);
            this.Name = "Procesos";
            this.Text = "Procesos";
            this.Load += new System.EventHandler(this.Procesos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreEstadoTextBox;
        private System.Windows.Forms.Button crearEstadoButton;
        private System.Windows.Forms.ListBox estadosListBox;
        private System.Windows.Forms.Button iniciarButton;
        private System.Windows.Forms.ListBox historialListBox;
        private System.Windows.Forms.TextBox tiempoTranscurridoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operacionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}