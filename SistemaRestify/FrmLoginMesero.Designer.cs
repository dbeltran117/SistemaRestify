namespace SistemaRestify
{
    partial class FrmLoginMesero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginMesero));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(12, 292);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(64, 64);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.BtnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEntrar.BackgroundImage")));
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Location = new System.Drawing.Point(728, 292);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(64, 64);
            this.BtnEntrar.TabIndex = 2;
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtUser.Location = new System.Drawing.Point(184, 12);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(597, 88);
            this.TxtUser.TabIndex = 7;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUser.Click += new System.EventHandler(this.TxtUser_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtClave.Location = new System.Drawing.Point(184, 130);
            this.TxtClave.Multiline = true;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(597, 88);
            this.TxtClave.TabIndex = 8;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtClave.Click += new System.EventHandler(this.TxtClave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(7, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "USUARIO:";
            // 
            // FrmLoginMesero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(804, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLoginMesero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginMesero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}