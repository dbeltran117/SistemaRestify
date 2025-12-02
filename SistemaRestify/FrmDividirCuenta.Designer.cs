namespace SistemaRestify
{
    partial class FrmDividirCuenta
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
            this.DtgCuentaActual = new System.Windows.Forms.DataGridView();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PCuentas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCantidadC = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCuentasAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCuentaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgCuentaActual
            // 
            this.DtgCuentaActual.AllowUserToAddRows = false;
            this.DtgCuentaActual.BackgroundColor = System.Drawing.Color.White;
            this.DtgCuentaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCuentaActual.Location = new System.Drawing.Point(6, 84);
            this.DtgCuentaActual.Name = "DtgCuentaActual";
            this.DtgCuentaActual.ReadOnly = true;
            this.DtgCuentaActual.RowHeadersWidth = 51;
            this.DtgCuentaActual.RowTemplate.Height = 24;
            this.DtgCuentaActual.Size = new System.Drawing.Size(716, 604);
            this.DtgCuentaActual.TabIndex = 6;
            this.DtgCuentaActual.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCuentaActual_CellClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnCancelar.Location = new System.Drawing.Point(12, 740);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(146, 48);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "CUENTA ORIGEN";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1450, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dividir Cuenta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.LblTotal.Location = new System.Drawing.Point(6, 691);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(30, 32);
            this.LblTotal.TabIndex = 17;
            this.LblTotal.Text = "0";
            // 
            // PCuentas
            // 
            this.PCuentas.AutoScroll = true;
            this.PCuentas.Location = new System.Drawing.Point(728, 84);
            this.PCuentas.Name = "PCuentas";
            this.PCuentas.Size = new System.Drawing.Size(710, 604);
            this.PCuentas.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(722, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total de Cuentas:";
            // 
            // TxtCantidadC
            // 
            this.TxtCantidadC.Location = new System.Drawing.Point(921, 43);
            this.TxtCantidadC.Name = "TxtCantidadC";
            this.TxtCantidadC.Size = new System.Drawing.Size(90, 38);
            this.TxtCantidadC.TabIndex = 20;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 2;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnAceptar.Location = new System.Drawing.Point(1292, 740);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(146, 48);
            this.BtnAceptar.TabIndex = 14;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCuentasAdd
            // 
            this.BtnCuentasAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnCuentasAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnCuentasAdd.FlatAppearance.BorderSize = 2;
            this.BtnCuentasAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuentasAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnCuentasAdd.Location = new System.Drawing.Point(1017, 41);
            this.BtnCuentasAdd.Name = "BtnCuentasAdd";
            this.BtnCuentasAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnCuentasAdd.TabIndex = 21;
            this.BtnCuentasAdd.Text = "+";
            this.BtnCuentasAdd.UseVisualStyleBackColor = false;
            this.BtnCuentasAdd.Click += new System.EventHandler(this.BtnCuentasAdd_Click);
            // 
            // FrmDividirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.BtnCuentasAdd);
            this.Controls.Add(this.TxtCantidadC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PCuentas);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DtgCuentaActual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmDividirCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDividirCuenta";
            this.Load += new System.EventHandler(this.FrmDividirCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgCuentaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgCuentaActual;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Panel PCuentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCantidadC;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCuentasAdd;
    }
}