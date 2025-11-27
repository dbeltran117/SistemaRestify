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
    public partial class FrmVerEntradas : Form
    {
        ManejadorPrincipalAdmin mpa;
        int fila = 0, columna = 0;
        public static Entradas entrada = new Entradas();
        public FrmVerEntradas()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string fechaCompleta = DtpFecha.Value.ToString("yyyy-MM-dd");
            mpa.VerEntradas($"select * from v_entradas where Fecha like '%{fechaCompleta}%'",DtgDatos,"entradas");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }
            else
            {
                entrada.IdEntrada = Convert.ToInt32(DtgDatos.Rows[fila].Cells[0].Value);
                switch (columna)
                {
                    case 3:
                        {
                            FrmDetalleEntrada fde = new FrmDetalleEntrada();
                            fde.ShowDialog();
                        } break;
                }
            }
        }

        private void DtgDatos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
