namespace SistemaRestify
{
    partial class FrmAgregarMesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMesas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgMesas = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtNumMesa = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMesas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1460, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtgMesas
            // 
            this.DtgMesas.AllowUserToAddRows = false;
            this.DtgMesas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMesas.Location = new System.Drawing.Point(637, 106);
            this.DtgMesas.Name = "DtgMesas";
            this.DtgMesas.ReadOnly = true;
            this.DtgMesas.RowHeadersWidth = 51;
            this.DtgMesas.Size = new System.Drawing.Size(801, 682);
            this.DtgMesas.TabIndex = 3;
            this.DtgMesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgMesas_CellClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(9, 106);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 90);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(541, 698);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(90, 90);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.TxtNumMesa);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(9, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 223);
            this.panel2.TabIndex = 13;
            // 
            // TxtNumMesa
            // 
            this.TxtNumMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtNumMesa.Location = new System.Drawing.Point(164, 24);
            this.TxtNumMesa.Name = "TxtNumMesa";
            this.TxtNumMesa.Size = new System.Drawing.Size(426, 32);
            this.TxtNumMesa.TabIndex = 18;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(8, 116);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 90);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero Mesa:";
            // 
            // FrmAgregarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DtgMesas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAgregarMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarMesas";
            this.Load += new System.EventHandler(this.FrmAgregarMesas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgMesas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgMesas;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumMesa;
    }
}