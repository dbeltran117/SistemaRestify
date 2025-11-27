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
    public partial class FrmDetalleEntrada : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmDetalleEntrada()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void FrmDetalleEntrada_Load(object sender, EventArgs e)
        {
            mpa.VerDetallesEntradas($"select * from v_detalleEntradas where idEntrada = {FrmVerEntradas.entrada.IdEntrada}", DtgDatos, "detalleEntradas");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
