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
    public partial class FrmDetalleSalida : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmDetalleSalida()
        {
            mpa = new ManejadorPrincipalAdmin();
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetalleSalida_Load(object sender, EventArgs e)
        {
            mpa.VerDetallesSalidas($"select * from v_detallesSalidas where idSalida = {FrmVerSalidas.salida.IdSalida}", DtgDatos, "detallesSalidas");
        }
    }
}
