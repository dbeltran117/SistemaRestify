using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SistemaRestify
{
    public partial class FrmPrincipal : Form
    {
        ManejadorUsuarios mu;
        ManejadorPrincipal mp;
        public static Panel pmesas = new Panel();
        public static Mesas mesa = new Mesas();
        public FrmPrincipal()
        {
            InitializeComponent();
            mp = new ManejadorPrincipal();
            mu = new ManejadorUsuarios();
            PlSeparador.BackColor = Color.FromArgb(128, 94, 113, 83);
            PlMesas.BackColor = Color.FromArgb(51, 94, 113, 83);
            mu.VerUsuarioMesero(FrmLoginMesero.usuarioActual,LblUsuario);
            mp.CrearBotonesMesas(PlMesas);
        }

    private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void BtnAbrirMesa_Click(object sender, EventArgs e)
        {
            pmesas = PlMesas;
            FrmAbrirMesa fam = new FrmAbrirMesa();
            fam.ShowDialog();
        }

        private void BtnVerPrecios_Click(object sender, EventArgs e)
        {
            FrmConsultarPrecios fcp = new FrmConsultarPrecios();
            fcp.ShowDialog();
        }

        private void BtnReservaciones_Click(object sender, EventArgs e)
        {
            FrmReservaciones fr = new FrmReservaciones();
            fr.ShowDialog();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos fp = new FrmPedidos();
            fp.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            mp.OnMesaSeleccionada += nombreMesa =>
            {
                FrmMenuOpciones fmo = new FrmMenuOpciones();
                mesa.NombreMesa = nombreMesa;
                fmo.ShowDialog();
            };

            mp.CrearBotonesMesas(pmesas);
        }
    }
}
