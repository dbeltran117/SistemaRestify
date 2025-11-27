namespace SistemaRestify
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PlMesas = new System.Windows.Forms.Panel();
            this.PlSeparador = new System.Windows.Forms.Panel();
            this.BtnAbrirMesa = new System.Windows.Forms.Button();
            this.BtnReservaciones = new System.Windows.Forms.Button();
            this.BtnVerPrecios = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnSalir.Location = new System.Drawing.Point(1324, 729);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 59);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PlMesas
            // 
            this.PlMesas.AutoScroll = true;
            this.PlMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.PlMesas.Location = new System.Drawing.Point(224, 98);
            this.PlMesas.Name = "PlMesas";
            this.PlMesas.Size = new System.Drawing.Size(1142, 625);
            this.PlMesas.TabIndex = 1;
            // 
            // PlSeparador
            // 
            this.PlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.PlSeparador.Location = new System.Drawing.Point(-2, 66);
            this.PlSeparador.Name = "PlSeparador";
            this.PlSeparador.Size = new System.Drawing.Size(1452, 5);
            this.PlSeparador.TabIndex = 2;
            // 
            // BtnAbrirMesa
            // 
            this.BtnAbrirMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAbrirMesa.FlatAppearance.BorderSize = 0;
            this.BtnAbrirMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnAbrirMesa.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrirMesa.Image")));
            this.BtnAbrirMesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrirMesa.Location = new System.Drawing.Point(12, 8);
            this.BtnAbrirMesa.Name = "BtnAbrirMesa";
            this.BtnAbrirMesa.Size = new System.Drawing.Size(178, 52);
            this.BtnAbrirMesa.TabIndex = 4;
            this.BtnAbrirMesa.Text = "Abrir Mesa";
            this.BtnAbrirMesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrirMesa.UseVisualStyleBackColor = true;
            this.BtnAbrirMesa.Click += new System.EventHandler(this.BtnAbrirMesa_Click);
            // 
            // BtnReservaciones
            // 
            this.BtnReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReservaciones.FlatAppearance.BorderSize = 0;
            this.BtnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnReservaciones.Image = ((System.Drawing.Image)(resources.GetObject("BtnReservaciones.Image")));
            this.BtnReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReservaciones.Location = new System.Drawing.Point(196, 8);
            this.BtnReservaciones.Name = "BtnReservaciones";
            this.BtnReservaciones.Size = new System.Drawing.Size(220, 52);
            this.BtnReservaciones.TabIndex = 5;
            this.BtnReservaciones.Text = "Reservaciones";
            this.BtnReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReservaciones.UseVisualStyleBackColor = true;
            this.BtnReservaciones.Click += new System.EventHandler(this.BtnReservaciones_Click);
            // 
            // BtnVerPrecios
            // 
            this.BtnVerPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerPrecios.FlatAppearance.BorderSize = 0;
            this.BtnVerPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerPrecios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnVerPrecios.Image = ((System.Drawing.Image)(resources.GetObject("BtnVerPrecios.Image")));
            this.BtnVerPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVerPrecios.Location = new System.Drawing.Point(422, 8);
            this.BtnVerPrecios.Name = "BtnVerPrecios";
            this.BtnVerPrecios.Size = new System.Drawing.Size(201, 52);
            this.BtnVerPrecios.TabIndex = 6;
            this.BtnVerPrecios.Text = "Ver Precios";
            this.BtnVerPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVerPrecios.UseVisualStyleBackColor = true;
            this.BtnVerPrecios.Click += new System.EventHandler(this.BtnVerPrecios_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.BtnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("BtnPedidos.Image")));
            this.BtnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPedidos.Location = new System.Drawing.Point(629, 8);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(151, 52);
            this.BtnPedidos.TabIndex = 7;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1397, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 52);
            this.panel1.TabIndex = 8;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.LblUsuario.Location = new System.Drawing.Point(1274, 22);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(48, 25);
            this.LblUsuario.TabIndex = 9;
            this.LblUsuario.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Area: Comedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(66, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ocupadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(66, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reservadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(66, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Disponibles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(148)))), ((int)(((byte)(112)))));
            this.panel2.Location = new System.Drawing.Point(17, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.panel3.Location = new System.Drawing.Point(17, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(104)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(17, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 16;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnPedidos);
            this.Controls.Add(this.BtnVerPrecios);
            this.Controls.Add(this.BtnReservaciones);
            this.Controls.Add(this.BtnAbrirMesa);
            this.Controls.Add(this.PlSeparador);
            this.Controls.Add(this.PlMesas);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PlMesas;
        private System.Windows.Forms.Panel PlSeparador;
        private System.Windows.Forms.Button BtnAbrirMesa;
        private System.Windows.Forms.Button BtnReservaciones;
        private System.Windows.Forms.Button BtnVerPrecios;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}