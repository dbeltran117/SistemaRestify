namespace SistemaRestify
{
    partial class FrmVerSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerSalidas));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(1348, 698);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 90);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnBuscar.Location = new System.Drawing.Point(500, 100);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(157, 34);
            this.BtnBuscar.TabIndex = 20;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(96, 103);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(398, 38);
            this.DtpFecha.TabIndex = 18;
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(12, 140);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(1426, 552);
            this.DtgDatos.TabIndex = 17;
            this.DtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellClick);
            this.DtgDatos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDatos_CellEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1450, 97);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ver Salidas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmVerSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmVerSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerSalidas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Label label1;
    }
}