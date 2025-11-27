namespace SistemaRestify
{
    partial class FrmAgregarMeseros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMeseros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombreMesero = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DtgMeseros = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMeseros)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1450, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "Meseros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtNombreMesero);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 224);
            this.panel2.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(13, 105);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 90);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label7.Location = new System.Drawing.Point(8, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nombre Mesero";
            // 
            // TxtNombreMesero
            // 
            this.TxtNombreMesero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.TxtNombreMesero.Location = new System.Drawing.Point(179, 8);
            this.TxtNombreMesero.Name = "TxtNombreMesero";
            this.TxtNombreMesero.Size = new System.Drawing.Size(421, 37);
            this.TxtNombreMesero.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.BackgroundImage")));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(12, 118);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(90, 90);
            this.BtnEliminar.TabIndex = 13;
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
            // DtgMeseros
            // 
            this.DtgMeseros.AllowUserToAddRows = false;
            this.DtgMeseros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(244)))));
            this.DtgMeseros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgMeseros.Location = new System.Drawing.Point(637, 154);
            this.DtgMeseros.Name = "DtgMeseros";
            this.DtgMeseros.ReadOnly = true;
            this.DtgMeseros.RowHeadersWidth = 51;
            this.DtgMeseros.Size = new System.Drawing.Size(801, 634);
            this.DtgMeseros.TabIndex = 14;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.BtnBuscar.Location = new System.Drawing.Point(1281, 118);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(157, 34);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CmbEstado.Location = new System.Drawing.Point(865, 118);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(410, 38);
            this.CmbEstado.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(637, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 34);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estatus del Mesero:";
            // 
            // FrmAgregarMeseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1450, 800);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtgMeseros);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmAgregarMeseros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarMeseros";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgMeseros)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombreMesero;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DtgMeseros;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}