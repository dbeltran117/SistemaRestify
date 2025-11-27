namespace SistemaRestify
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.DtgInventario = new System.Windows.Forms.DataGridView();
            this.DtgStockMinimo = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStockMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1450, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgInventario
            // 
            this.DtgInventario.AllowUserToAddRows = false;
            this.DtgInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgInventario.Location = new System.Drawing.Point(5, 160);
            this.DtgInventario.Name = "DtgInventario";
            this.DtgInventario.ReadOnly = true;
            this.DtgInventario.RowHeadersWidth = 51;
            this.DtgInventario.Size = new System.Drawing.Size(714, 532);
            this.DtgInventario.TabIndex = 16;
            // 
            // DtgStockMinimo
            // 
            this.DtgStockMinimo.AllowUserToAddRows = false;
            this.DtgStockMinimo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgStockMinimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgStockMinimo.Location = new System.Drawing.Point(724, 160);
            this.DtgStockMinimo.Name = "DtgStockMinimo";
            this.DtgStockMinimo.ReadOnly = true;
            this.DtgStockMinimo.RowHeadersWidth = 51;
            this.DtgStockMinimo.Size = new System.Drawing.Size(714, 532);
            this.DtgStockMinimo.TabIndex = 17;
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
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(5, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prodcuto:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnBuscar.Location = new System.Drawing.Point(562, 115);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(157, 34);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(890, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "PRODUCTOS EN STOCK MINIMO";
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtProducto.Location = new System.Drawing.Point(116, 114);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(440, 38);
            this.TxtProducto.TabIndex = 23;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DtgStockMinimo);
            this.Controls.Add(this.DtgInventario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgStockMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgInventario;
        private System.Windows.Forms.DataGridView DtgStockMinimo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProducto;
    }
}