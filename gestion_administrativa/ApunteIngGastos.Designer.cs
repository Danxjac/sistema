namespace SistemaGestionDeportiva.gestion_administrativa
{
    partial class ApunteIngGastos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtimporte = new System.Windows.Forms.TextBox();
            this.Txtdes = new System.Windows.Forms.TextBox();
            this.Txtmarca = new System.Windows.Forms.TextBox();
            this.Cmborigen = new System.Windows.Forms.ComboBox();
            this.Cmbtipo = new System.Windows.Forms.ComboBox();
            this.Cmbbanco = new System.Windows.Forms.ComboBox();
            this.Txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(177, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(177, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Importe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(177, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(177, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(177, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Origen:";
            // 
            // Txtimporte
            // 
            this.Txtimporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtimporte.Location = new System.Drawing.Point(300, 284);
            this.Txtimporte.Margin = new System.Windows.Forms.Padding(4);
            this.Txtimporte.Name = "Txtimporte";
            this.Txtimporte.Size = new System.Drawing.Size(163, 26);
            this.Txtimporte.TabIndex = 44;
            // 
            // Txtdes
            // 
            this.Txtdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdes.Location = new System.Drawing.Point(300, 249);
            this.Txtdes.Margin = new System.Windows.Forms.Padding(4);
            this.Txtdes.Name = "Txtdes";
            this.Txtdes.Size = new System.Drawing.Size(242, 26);
            this.Txtdes.TabIndex = 43;
            this.Txtdes.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // Txtmarca
            // 
            this.Txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtmarca.Location = new System.Drawing.Point(300, 318);
            this.Txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.Txtmarca.Name = "Txtmarca";
            this.Txtmarca.Size = new System.Drawing.Size(71, 26);
            this.Txtmarca.TabIndex = 42;
            // 
            // Cmborigen
            // 
            this.Cmborigen.FormattingEnabled = true;
            this.Cmborigen.Location = new System.Drawing.Point(300, 176);
            this.Cmborigen.Name = "Cmborigen";
            this.Cmborigen.Size = new System.Drawing.Size(163, 24);
            this.Cmborigen.TabIndex = 51;
            // 
            // Cmbtipo
            // 
            this.Cmbtipo.FormattingEnabled = true;
            this.Cmbtipo.Location = new System.Drawing.Point(300, 212);
            this.Cmbtipo.Name = "Cmbtipo";
            this.Cmbtipo.Size = new System.Drawing.Size(163, 24);
            this.Cmbtipo.TabIndex = 52;
            // 
            // Cmbbanco
            // 
            this.Cmbbanco.FormattingEnabled = true;
            this.Cmbbanco.Location = new System.Drawing.Point(300, 365);
            this.Cmbbanco.Name = "Cmbbanco";
            this.Cmbbanco.Size = new System.Drawing.Size(163, 24);
            this.Cmbbanco.TabIndex = 56;
            this.Cmbbanco.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Txtdate
            // 
            this.Txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Txtdate.Location = new System.Drawing.Point(300, 144);
            this.Txtdate.MinDate = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            this.Txtdate.Name = "Txtdate";
            this.Txtdate.Size = new System.Drawing.Size(163, 24);
            this.Txtdate.TabIndex = 57;
            this.Txtdate.Value = new System.DateTime(2020, 12, 3, 16, 22, 0, 0);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnguardar.Location = new System.Drawing.Point(551, 436);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(142, 49);
            this.btnguardar.TabIndex = 58;
            this.btnguardar.Text = "Guardar Datos";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Apuntes de Ingreso/Gasto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(180, 369);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Banco:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(180, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Marca:";
            // 
            // ApunteIngGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.Txtdate);
            this.Controls.Add(this.Cmbbanco);
            this.Controls.Add(this.Cmbtipo);
            this.Controls.Add(this.Cmborigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtimporte);
            this.Controls.Add(this.Txtdes);
            this.Controls.Add(this.Txtmarca);
            this.MaximizeBox = false;
            this.Name = "ApunteIngGastos";
            this.Text = "ApunteIngGastos";
            this.Load += new System.EventHandler(this.ApunteIngGastos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Txtimporte;
        public System.Windows.Forms.TextBox Txtdes;
        public System.Windows.Forms.TextBox Txtmarca;
        private System.Windows.Forms.ComboBox Cmborigen;
        private System.Windows.Forms.ComboBox Cmbtipo;
        private System.Windows.Forms.ComboBox Cmbbanco;
        private System.Windows.Forms.DateTimePicker Txtdate;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}