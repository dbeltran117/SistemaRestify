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
    public partial class FrmDatosSubCategoria : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmDatosSubCategoria()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
            mpa.LlenarCategorias(CmbCategorias);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            mpa.AgregarSubCategoria(TxtNombreC.Text,(int)CmbCategorias.SelectedValue);
            Close();
        }
    }
}
