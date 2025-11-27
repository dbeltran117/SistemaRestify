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
    public partial class FrmVerSalidas : Form
    {
        ManejadorPrincipalAdmin mpa;
        int fila = 0, columna = 0;
        public static Salidas salida = new Salidas();
        public FrmVerSalidas()
        {
            mpa = new ManejadorPrincipalAdmin();
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string fechaCompleta = DtpFecha.Value.ToString("yyyy-MM-dd");
            mpa.VerSalidas($"select * from v_salidas where Fecha like '%{fechaCompleta}%'", DtgDatos, "salidas");
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                salida.IdSalida = Convert.ToInt32(DtgDatos.Rows[fila].Cells[0].Value);
                switch (columna)
                {
                    case 3:
                        {
                            FrmDetalleSalida fds = new FrmDetalleSalida();
                            fds.ShowDialog();
                        }
                        break;
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
