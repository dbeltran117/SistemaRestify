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

namespace Manejadores
{
    public partial class FrmInsumos : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmInsumos()
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
            mpa.MostrarInsumos($"select * from v_insumos where Producto like '%{TxtNamePr.Text}%'",DtgProductos,"productosCompra");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtDesc.Text == "" || CmbUnidad.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mpa.AgregarInsumos(TxtDesc.Text, CmbUnidad.Text,double.Parse(TxtStockMinimo.Text));
                mpa.MostrarInsumos("select * from v_insumos", DtgProductos, "productosCompra");
                TxtDesc.Clear();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(DtgProductos.SelectedRows.Count > 0)
            {
                string nombreInsumo = DtgProductos.CurrentRow.Cells["Producto"].Value.ToString();
                var confirm = MessageBox.Show($"¿Está seguro de eliminar el insumo '{nombreInsumo}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    mpa.EliminarInsumos(nombreInsumo);
                    mpa.MostrarInsumos("select * from v_insumos", DtgProductos, "productosCompra");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un insumo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
