namespace SistemaRestify
{
    partial class FrmPedidoRapido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoRapido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GbxCobroRapido = new System.Windows.Forms.GroupBox();
            this.GbxMenu = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtgCobroRapido = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.DtgDatosProductos = new System.Windows.Forms.DataGridView();
            this.BtnAgregarComentario = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GbxCobroRapido.SuspendLayout();
            this.GbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCobroRapido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "RÁPIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label2.Location = new System.Drawing.Point(293, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "CAPTURA PEDIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1447, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 73);
            this.label4.TabIndex = 5;
            this.label4.Text = "|";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.GbxCobroRapido);
            this.panel1.Location = new System.Drawing.Point(56, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 588);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.GbxMenu);
            this.panel2.Location = new System.Drawing.Point(765, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 588);
            this.panel2.TabIndex = 7;
            // 
            // GbxCobroRapido
            // 
            this.GbxCobroRapido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.GbxCobroRapido.Controls.Add(this.label10);
            this.GbxCobroRapido.Controls.Add(this.label9);
            this.GbxCobroRapido.Controls.Add(this.LblTotal);
            this.GbxCobroRapido.Controls.Add(this.label7);
            this.GbxCobroRapido.Controls.Add(this.DtgCobroRapido);
            this.GbxCobroRapido.Controls.Add(this.label5);
            this.GbxCobroRapido.Location = new System.Drawing.Point(3, 3);
            this.GbxCobroRapido.Name = "GbxCobroRapido";
            this.GbxCobroRapido.Size = new System.Drawing.Size(666, 582);
            this.GbxCobroRapido.TabIndex = 0;
            this.GbxCobroRapido.TabStop = false;
            // 
            // GbxMenu
            // 
            this.GbxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.GbxMenu.Controls.Add(this.BtnAgregarComentario);
            this.GbxMenu.Controls.Add(this.DtgDatosProductos);
            this.GbxMenu.Controls.Add(this.BtnBuscarProducto);
            this.GbxMenu.Controls.Add(this.textBox1);
            this.GbxMenu.Controls.Add(this.label11);
            this.GbxMenu.Controls.Add(this.label8);
            this.GbxMenu.Controls.Add(this.label6);
            this.GbxMenu.Location = new System.Drawing.Point(3, 3);
            this.GbxMenu.Name = "GbxMenu";
            this.GbxMenu.Size = new System.Drawing.Size(666, 582);
            this.GbxMenu.TabIndex = 1;
            this.GbxMenu.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cobro Rápido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Menú";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(649, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // DtgCobroRapido
            // 
            this.DtgCobroRapido.AllowUserToAddRows = false;
            this.DtgCobroRapido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.DtgCobroRapido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCobroRapido.Location = new System.Drawing.Point(0, 79);
            this.DtgCobroRapido.Name = "DtgCobroRapido";
            this.DtgCobroRapido.Size = new System.Drawing.Size(669, 396);
            this.DtgCobroRapido.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(18, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "TOTAL:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Lucida Bright", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblTotal.Location = new System.Drawing.Point(154, 511);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(31, 32);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-6, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(703, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-6, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(703, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "_________________________________________________________________________________" +
    "___________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.label11.Location = new System.Drawing.Point(10, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Buscar Producto:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.textBox1.Location = new System.Drawing.Point(191, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 31);
            this.textBox1.TabIndex = 9;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarProducto.BackgroundImage")));
            this.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(617, 96);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(33, 33);
            this.BtnBuscarProducto.TabIndex = 10;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // DtgDatosProductos
            // 
            this.DtgDatosProductos.AllowUserToAddRows = false;
            this.DtgDatosProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.DtgDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatosProductos.Location = new System.Drawing.Point(14, 148);
            this.DtgDatosProductos.Name = "DtgDatosProductos";
            this.DtgDatosProductos.Size = new System.Drawing.Size(636, 342);
            this.DtgDatosProductos.TabIndex = 7;
            // 
            // BtnAgregarComentario
            // 
            this.BtnAgregarComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnAgregarComentario.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnAgregarComentario.Location = new System.Drawing.Point(173, 511);
            this.BtnAgregarComentario.Name = "BtnAgregarComentario";
            this.BtnAgregarComentario.Size = new System.Drawing.Size(356, 43);
            this.BtnAgregarComentario.TabIndex = 11;
            this.BtnAgregarComentario.Text = "Agregar Comentario";
            this.BtnAgregarComentario.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnCancelar.Location = new System.Drawing.Point(56, 745);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 43);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnAceptar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnAceptar.Location = new System.Drawing.Point(1304, 745);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 43);
            this.BtnAceptar.TabIndex = 13;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // FrmPedidoRapido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPedidoRapido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPedidoRapido";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.GbxCobroRapido.ResumeLayout(false);
            this.GbxCobroRapido.PerformLayout();
            this.GbxMenu.ResumeLayout(false);
            this.GbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCobroRapido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatosProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GbxCobroRapido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GbxMenu;
        private System.Windows.Forms.DataGridView DtgCobroRapido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DtgDatosProductos;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnAgregarComentario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
    }
}