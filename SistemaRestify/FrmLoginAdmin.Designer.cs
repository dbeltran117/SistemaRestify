namespace SistemaRestify
{
    partial class FrmLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // TxtClave
            // 
            this.TxtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtClave.Location = new System.Drawing.Point(187, 125);
            this.TxtClave.Multiline = true;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(597, 88);
            this.TxtClave.TabIndex = 14;
            this.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.SystemColors.Control;
            this.TxtUser.Location = new System.Drawing.Point(187, 7);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(597, 88);
            this.TxtUser.TabIndex = 13;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEntrar.BackgroundImage")));
            this.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Location = new System.Drawing.Point(731, 287);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(64, 64);
            this.BtnEntrar.TabIndex = 12;
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(62)))), ((int)(((byte)(25)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(15, 287);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(64, 64);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(804, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.BtnEntrar);
            this.Controls.Add(this.BtnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoginAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.Button BtnSalir;
    }
}