namespace Manejadores
{
    partial class FrmInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsumos));
            this.DtgProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbUnidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNamePr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStockMinimo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgProductos
            // 
            this.DtgProductos.AllowUserToAddRows = false;
            this.DtgProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProductos.Location = new System.Drawing.Point(639, 145);
            this.DtgProductos.Name = "DtgProductos";
            this.DtgProductos.ReadOnly = true;
            this.DtgProductos.RowHeadersWidth = 51;
            this.DtgProductos.Size = new System.Drawing.Size(801, 643);
            this.DtgProductos.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(1, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "LISTA DE INSUMOS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(242, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre Producto:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(9, 287);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 90);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnBuscar.Location = new System.Drawing.Point(1286, 106);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(157, 34);
            this.BtnBuscar.TabIndex = 18;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtDesc
            // 
            this.TxtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtDesc.Location = new System.Drawing.Point(10, 35);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(591, 111);
            this.TxtDesc.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Descripcion:";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(537, 106);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 90);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(633, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 34);
            this.panel3.TabIndex = 16;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(15, 106);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 90);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidad:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TxtStockMinimo);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.TxtDesc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CmbUnidad);
            this.panel2.Location = new System.Drawing.Point(12, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 380);
            this.panel2.TabIndex = 14;
            // 
            // CmbUnidad
            // 
            this.CmbUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.CmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidad.FormattingEnabled = true;
            this.CmbUnidad.Items.AddRange(new object[] {
            "Piezas",
            "Litros",
            "Kilos"});
            this.CmbUnidad.Location = new System.Drawing.Point(105, 168);
            this.CmbUnidad.Name = "CmbUnidad";
            this.CmbUnidad.Size = new System.Drawing.Size(496, 33);
            this.CmbUnidad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(0, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1450, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insumos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 100);
            this.panel1.TabIndex = 13;
            // 
            // TxtNamePr
            // 
            this.TxtNamePr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtNamePr.Location = new System.Drawing.Point(1068, 108);
            this.TxtNamePr.Name = "TxtNamePr";
            this.TxtNamePr.Size = new System.Drawing.Size(212, 31);
            this.TxtNamePr.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label10.Location = new System.Drawing.Point(13, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Stock Minimo:";
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtStockMinimo.Location = new System.Drawing.Point(166, 222);
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(435, 31);
            this.TxtStockMinimo.TabIndex = 25;
            // 
            // FrmInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.TxtNamePr);
            this.Controls.Add(this.DtgProductos);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsumos";
            ((System.ComponentModel.ISupportInitialize)(this.DtgProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbUnidad;
        private System.Windows.Forms.TextBox TxtNamePr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtStockMinimo;
    }
}