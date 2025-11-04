using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace SistemaRestify
{
    public partial class FrmLoginMesero : Form
    {
        FrmTeclado ft = new FrmTeclado();
        ManejadorUsuarios mu;
        public static string usuarioActual;

        public FrmLoginMesero()
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

        private void TxtUser_Click(object sender, EventArgs e)
        {
            ft.CampoDestino = TxtUser;
            ft.ShowDialog();
        }

        private void TxtClave_Click(object sender, EventArgs e)
        {
            ft.CampoDestino = TxtClave;
            ft.ShowDialog();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (mu.ValidarMeseros(TxtUser, TxtClave))
            {
                usuarioActual = TxtUser.Text;
                FrmPrincipal fp = new FrmPrincipal();
                fp.Show();
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
    }
}
