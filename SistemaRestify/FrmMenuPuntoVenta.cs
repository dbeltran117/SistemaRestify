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
    public partial class FrmMenuPuntoVenta : Form
    {
        public FrmMenuPuntoVenta()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

        private void BtnInsumos_Click(object sender, EventArgs e)
        {
            FrmInsumos fi = new FrmInsumos();
            fi.ShowDialog();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarProductoMenu fapm = new FrmAgregarProductoMenu();
            fapm.ShowDialog();
        }

        private void BtnMesas_Click(object sender, EventArgs e)
        {
            FrmAgregarMesas fam = new FrmAgregarMesas();
            fam.ShowDialog();
        }
        private void BtnEntradas_Click(object sender, EventArgs e)
        {
            FrmEntradas fe = new FrmEntradas();
            fe.ShowDialog();
        }

        private void BtnAsMeseros_Click_1(object sender, EventArgs e)
        {
            FrmAgregarMeseros fame = new FrmAgregarMeseros();
            fame.ShowDialog();
        }

        private void BtnSalidas_Click(object sender, EventArgs e)
        {
            FrmSalidas fs = new FrmSalidas();
            fs.ShowDialog();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas fv = new FrmVentas();
            fv.ShowDialog();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario fi = new FrmInventario();
            fi.ShowDialog();
        }
    }
}
