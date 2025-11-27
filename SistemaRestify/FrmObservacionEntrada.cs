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
    public partial class FrmObservacionEntrada : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmObservacionEntrada()
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
            mpa.AgregarEntradas(TxtObservacion.Text);
            if(FrmEntradas.productos.Count > 0)
            {
                foreach (var item in FrmEntradas.productos)
                {
                    mpa.AgregarDetallesEntradas(item.FkIdProducto,item.Cantidad,item.Costo);
                }
                MessageBox.Show("Entrada guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmEntradas.productos.Clear();
                Close();
            }
            else
            {
                MessageBox.Show("No hay productos para agregar en la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
