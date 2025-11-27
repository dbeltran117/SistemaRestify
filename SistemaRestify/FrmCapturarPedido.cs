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
    public partial class FrmCapturarPedido : Form
    {
        ManejadorPrincipal mp;
        public FrmCapturarPedido()
        {
            InitializeComponent();
            PlSeparador.BackColor = Color.FromArgb(128, 94, 113, 83);
            PlLateral.BackColor = Color.FromArgb(128, 94, 113, 83);
            mp = new ManejadorPrincipal();
            mp.LlenarCategorias(CmbCategorias);
            LblMesa.Text = FrmAbrirMesa.MesaSeleccionada.ToString();
            LblPersonas.Text = FrmAbrirMesa.CantidadPersonas.ToString();
            mp.LlenarGridCuenta(DtgCuentaActual);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query; 

            if (CmbCategorias.SelectedIndex == 0)
            {
                query = $"select * from v_productosVista";
            }
            else
            {
               query = $"select * from v_productosVista where idCategoria = {CmbCategorias.SelectedValue}";
            }
            mp.MostrarProdutos(query, DtgMenu, "productosVenta");
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (DtgMenu.CurrentRow != null)
            {
                string producto = DtgMenu.CurrentRow.Cells["Producto"].Value.ToString();
                double precio = Convert.ToDouble(DtgMenu.CurrentRow.Cells["Precio"].Value);
                double importe = Convert.ToDouble(DtgMenu.CurrentRow.Cells["Importe"].Value);

                bool productoExiste = false;

                foreach (DataGridViewRow row in DtgCuentaActual.Rows)
                {
                    if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == producto)
                    {
                        // si ya existe, incrementamos cantidad y recalculamos importe
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        cantidadActual++;
                        row.Cells["Cantidad"].Value = cantidadActual;
                        row.Cells["Importe"].Value = importe + importe; // recalculamos con tu lógica
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {
                    int cantidad = 1;
                    DtgCuentaActual.Rows.Add(producto, cantidad, precio, importe);
                }

                DtgCuentaActual.AutoResizeColumns();
                DtgCuentaActual.AutoResizeRows();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
