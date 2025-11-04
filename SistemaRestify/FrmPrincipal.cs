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
    public partial class FrmPrincipal : Form
    {
        ManejadorUsuarios mu;
        public FrmPrincipal()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            PlSeparador.BackColor = Color.FromArgb(128, 94, 113, 83);
            PlMesas.BackColor = Color.FromArgb(51, 94, 113, 83);
            PlMesasCerradas.BackColor = Color.FromArgb(51, 94, 113, 83);
            mu.VerUsuarioMesero(FrmLoginMesero.usuarioActual,LblUsuario);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }
    }
}
