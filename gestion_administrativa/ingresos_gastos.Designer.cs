namespace SistemaGestionDeportiva.gestion_administrativa
{
    partial class ingresos_gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresos_gastos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonApunte = new System.Windows.Forms.Button();
            this.btnbuscarIG = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnInforme = new System.Windows.Forms.Button();
            this.DataGridViewIng = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIng)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonApunte
            // 
            this.buttonApunte.Location = new System.Drawing.Point(62, 36);
            this.buttonApunte.Name = "buttonApunte";
            this.buttonApunte.Size = new System.Drawing.Size(137, 39);
            this.buttonApunte.TabIndex = 10;
            this.buttonApunte.Text = "Nuevo Apunte +";
            this.buttonApunte.UseVisualStyleBackColor = true;
            this.buttonApunte.Click += new System.EventHandler(this.buttonApunte_Click);
            // 
            // btnbuscarIG
            // 
            this.btnbuscarIG.Location = new System.Drawing.Point(778, 34);
            this.btnbuscarIG.Name = "btnbuscarIG";
            this.btnbuscarIG.Size = new System.Drawing.Size(103, 43);
            this.btnbuscarIG.TabIndex = 11;
            this.btnbuscarIG.Text = "Buscar";
            this.btnbuscarIG.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 164;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGridViewIng);
            this.panel1.Controls.Add(this.BtnInforme);
            this.panel1.Controls.Add(this.btnbuscarIG);
            this.panel1.Controls.Add(this.buttonApunte);
            this.panel1.Location = new System.Drawing.Point(71, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 606);
            this.panel1.TabIndex = 165;
            // 
            // BtnInforme
            // 
            this.BtnInforme.Location = new System.Drawing.Point(938, 34);
            this.BtnInforme.Name = "BtnInforme";
            this.BtnInforme.Size = new System.Drawing.Size(103, 43);
            this.BtnInforme.TabIndex = 59;
            this.BtnInforme.Text = "Informe";
            this.BtnInforme.UseVisualStyleBackColor = true;
            this.BtnInforme.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // DataGridViewIng
            // 
            this.DataGridViewIng.AllowUserToAddRows = false;
            this.DataGridViewIng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewIng.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DataGridViewIng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewIng.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewIng.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIng.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewIng.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewIng.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewIng.EnableHeadersVisualStyles = false;
            this.DataGridViewIng.GridColor = System.Drawing.Color.SteelBlue;
            this.DataGridViewIng.Location = new System.Drawing.Point(53, 102);
            this.DataGridViewIng.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewIng.Name = "DataGridViewIng";
            this.DataGridViewIng.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewIng.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewIng.RowHeadersWidth = 52;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewIng.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewIng.Size = new System.Drawing.Size(988, 436);
            this.DataGridViewIng.TabIndex = 60;
            // 
            // ingresos_gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1213, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingresos_gastos";
            this.Text = "ingresos_gastos";
            this.Load += new System.EventHandler(this.ingresos_gastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewIng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonApunte;
        private System.Windows.Forms.Button btnbuscarIG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInforme;
        private System.Windows.Forms.DataGridView DataGridViewIng;
    }
}