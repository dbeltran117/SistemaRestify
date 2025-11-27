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
    public partial class FrmDetalleVenta : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmDetalleVenta()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            mpa.MostrarDetallesVentas($"select * from v_detallesVentas where idCuenta = {FrmVentas.cuenta.IdCuenta}",DtgVentas,"cuentas");
        }
    }
}
