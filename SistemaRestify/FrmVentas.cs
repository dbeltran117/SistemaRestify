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
using Entidades;

namespace SistemaRestify
{
    public partial class FrmVentas : Form
    {
        ManejadorPrincipalAdmin mpa;
        int fila = 0, columna = 0;
        public static Cuentas cuenta = new Cuentas();
        public FrmVentas()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string fechaCompleta = DtpFecha.Value.ToString("yyyy-MM-dd");
            mpa.MostrarVentas($"select * from v_ventas where Fecha like '%{fechaCompleta}%'", DtgVentas, "ventas");
        }

        private void DtgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                int idCuenta = Convert.ToInt32(DtgVentas.Rows[fila].Cells["idCuenta"].Value);
                switch(columna)
                {
                    case 4:
                        {
                            FrmDetalleVenta fdv = new FrmDetalleVenta();
                            fdv.ShowDialog();
                        } break;
                }
            }
        }

        private void DtgVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
