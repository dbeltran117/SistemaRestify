using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

            double totalCuenta = 0;

            foreach (DataGridViewRow row in DtgVentas.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    double valor;
                    if (double.TryParse(row.Cells["Total"].Value.ToString(), out valor))
                    {
                        totalCuenta += valor;
                    }
                }
            }

            LblTotal.Text = $"Total: ${totalCuenta:F2}";

        }
    }
}
