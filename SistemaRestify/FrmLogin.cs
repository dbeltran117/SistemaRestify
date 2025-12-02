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
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios mu;
        public FrmLogin()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMeseros_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginMesero flm = new FrmLoginMesero();
            flm.Show();
        }

        private void BtnAdministrativo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAdmin fla = new FrmLoginAdmin();
            fla.Show();
        }
    }
}
