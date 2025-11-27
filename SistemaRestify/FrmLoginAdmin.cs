using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace SistemaRestify
{
    public partial class FrmLoginAdmin : Form
    {
        ManejadorUsuarios mu;
        public FrmLoginAdmin()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            TxtClave.Text = TxtClave.Text.ToUpper();
            TxtUser.Text = TxtUser.Text.ToUpper();
            if (mu.ValidarAdmin(TxtUser, TxtClave))
            {
                FrmMenuPuntoVenta fmpv = new FrmMenuPuntoVenta();
                fmpv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUser.Clear();
                TxtClave.Clear();
                TxtUser.Focus();
            }
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            Close();
        }
    }
}
