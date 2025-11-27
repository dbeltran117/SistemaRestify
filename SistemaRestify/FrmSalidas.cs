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
    public partial class FrmSalidas : Form
    {
        public static List<DetallesSalidas> productos = new List<DetallesSalidas>();
        ManejadorPrincipalAdmin mpa;
        public FrmSalidas()
        {
            mpa = new ManejadorPrincipalAdmin();
            InitializeComponent();
            mpa.LlenarGridEntrada(DtgProductos);
            mpa.LlenarProductosCompra(CmbProducto);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (CmbProducto.Text == "" || TxtCantidad.Text == "" || TxtCosto.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idProducto = Convert.ToInt32(CmbProducto.SelectedValue);
                string nombreProducto = CmbProducto.Text;
                double costo = Convert.ToDouble(TxtCosto.Text);
                double cantidad = Convert.ToDouble(TxtCantidad.Text);

                bool Existe = DtgProductos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells[0].Value) == idProducto);
                if (Existe)
                {
                    MessageBox.Show("Este producto ya fue agregado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCantidad.Clear();
                    return;
                }
                DtgProductos.Rows.Add(idProducto, nombreProducto, cantidad, costo);

                productos.Add(new DetallesSalidas
                {
                    FkIdProducto = idProducto,
                    Cantidad = cantidad,
                    Costo = costo
                });

                DtgProductos.AutoResizeColumns();
                DtgProductos.AutoResizeRows();
            }
        }

        private void DtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                int idProducto = Convert.ToInt32(DtgProductos.Rows[e.RowIndex].Cells[0].Value);
                var itemToRemove = productos.FirstOrDefault(item => item.FkIdProducto == idProducto);
                if (itemToRemove != null)
                {
                    productos.Remove(itemToRemove);
                }
                DtgProductos.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "" || TxtCosto.Text == "")
            {
                MessageBox.Show("No hay productos para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmObservacionSalida fos = new FrmObservacionSalida();
                fos.ShowDialog();
                DtgProductos.Rows.Clear();
                TxtCantidad.Clear();
                TxtCosto.Clear();
            }
        }

        private void BtnVerSalidas_Click(object sender, EventArgs e)
        {
            FrmVerSalidas fvs = new FrmVerSalidas();
            fvs.ShowDialog();
        }
    }
}
