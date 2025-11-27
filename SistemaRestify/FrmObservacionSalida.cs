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
    public partial class FrmObservacionSalida : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmObservacionSalida()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            mpa.AgregarSalidas(TxtObservacion.Text);
            if (FrmSalidas.productos.Count > 0)
            {
                foreach (var item in FrmSalidas.productos)
                {
                    mpa.AgregarDetallesSalidas(item.FkIdProducto,item.Cantidad,item.Costo);
                }
                MessageBox.Show("Salida registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSalidas.productos.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("No hay productos para agregar en la salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
