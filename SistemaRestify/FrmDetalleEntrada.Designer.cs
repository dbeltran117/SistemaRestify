namespace SistemaRestify
{
    partial class FrmDetalleEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleEntrada));
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.AllowUserToAddRows = false;
            this.DtgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(12, 12);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.ReadOnly = true;
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.Size = new System.Drawing.Size(1426, 680);
            this.DtgDatos.TabIndex = 5;
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
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmDetalleEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DtgDatos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmDetalleEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleEntrada";
            this.Load += new System.EventHandler(this.FrmDetalleEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private System.Windows.Forms.Button BtnSalir;
    }
}