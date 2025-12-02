using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Manejadores;

namespace SistemaRestify
{
    public partial class FrmCapturarPedido : Form
    {
        ManejadorPrincipal mp;
        private Cuentas cuentaMesa;

        public FrmCapturarPedido(Cuentas cuenta)
        {
            InitializeComponent();
            PlSeparador.BackColor = Color.FromArgb(128, 94, 113, 83);
            PlLateral.BackColor = Color.FromArgb(128, 94, 113, 83);
            PlLateral2.BackColor = Color.FromArgb(128, 94, 113, 83);
            mp = new ManejadorPrincipal();
            mp.LlenarCategorias(CmbCategorias);
            mp.LlenarGridCuenta(DtgCuentaActual);
            cuentaMesa = cuenta;
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
                int idMesa = Convert.ToInt32(LblMesa.Text);
                int idProducto = Convert.ToInt32(DtgMenu.CurrentRow.Cells["idProducto"].Value);
                string producto = DtgMenu.CurrentRow.Cells["Producto"].Value.ToString();
                double precio = Convert.ToDouble(DtgMenu.CurrentRow.Cells["Precio"].Value);

                bool productoExiste = false;

                // actualizar grid visual
                foreach (DataGridViewRow row in DtgCuentaActual.Rows)
                {
                    if (row.Cells["Producto"].Value != null && row.Cells["Producto"].Value.ToString() == producto)
                    {
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        cantidadActual++;
                        row.Cells["Cantidad"].Value = cantidadActual;
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {
                    int cantidad = 1;
                    DtgCuentaActual.Rows.Add(idProducto, producto, cantidad, precio);
                }

                // obtener cantidad actual del producto en el grid
                var filaProducto = DtgCuentaActual.Rows.Cast<DataGridViewRow>().First(r => r.Cells["Producto"].Value.ToString() == producto);

                int cantidadLs = Convert.ToInt32(filaProducto.Cells["Cantidad"].Value);

                // buscar si ya existe la cuenta de esa mesa
                var cuentaMesa = FrmPrincipal.cuentasActivas.FirstOrDefault(c => c.FkIdMesa == idMesa);

                // agregar o actualizar detalle en la cuenta
                var detalle = cuentaMesa.Detalles.FirstOrDefault(d => d.FkIdProductoVenta == idProducto);
                if (detalle != null)
                {
                    detalle.Cantidad = cantidadLs; // actualizamos cantidad
                }
                else
                {
                    cuentaMesa.Detalles.Add(new DetalleCuenta
                    {
                        FkIdProductoVenta = idProducto,
                        Cantidad = cantidadLs,
                        Precio = precio
                    });
                }

                DtgCuentaActual.AutoResizeColumns();
                DtgCuentaActual.AutoResizeRows();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmCapturarPedido_Load(object sender, EventArgs e)
        {
            LblMesa.Text = cuentaMesa.FkIdMesa.ToString();
            LblPersonas.Text = cuentaMesa.CantidadPersonas.ToString();
            LblEtiqueta.Text = mp.MostrarEtiqueta(cuentaMesa.FkIdMesa);

            DtgCuentaActual.Rows.Clear();

            foreach (var detalle in cuentaMesa.Detalles)
            {
            var producto = FrmPrincipal.productos.FirstOrDefault(p => p.IdProductoVenta == detalle.FkIdProductoVenta);

                if (producto != null)
                {
                    DtgCuentaActual.Rows.Add(
                    detalle.FkIdProductoVenta,
                    producto.Nombre,
                    detalle.Cantidad,
                    producto.Precio
                );
                }
            }
            mp.ActualizarTotalOrigen(DtgCuentaActual, LblCuenta);
            DtgCuentaActual.AutoResizeColumns();
            DtgCuentaActual.AutoResizeRows();
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DtgCuentaActual.CurrentRow != null)
            {
                // Obtener datos de la fila seleccionada
                int idMesa = Convert.ToInt32(LblMesa.Text);
                int idProducto = Convert.ToInt32(DtgCuentaActual.CurrentRow.Cells["idProducto"].Value);
                string producto = DtgCuentaActual.CurrentRow.Cells["Producto"].Value.ToString();

                // Eliminar del grid visual
                DtgCuentaActual.Rows.Remove(DtgCuentaActual.CurrentRow);

                // Buscar la cuenta de esa mesa
                var cuentaMesa = FrmPrincipal.cuentasActivas.FirstOrDefault(c => c.FkIdMesa == idMesa);
                if (cuentaMesa != null)
                {
                    // Eliminar el detalle correspondiente
                    var detalle = cuentaMesa.Detalles.FirstOrDefault(d => d.FkIdProductoVenta == idProducto);
                    if (detalle != null)
                    {
                        cuentaMesa.Detalles.Remove(detalle);
                    }
                }
                mp.ActualizarTotalOrigen(DtgCuentaActual,LblCuenta);
                // Ajustar visualización
                DtgCuentaActual.AutoResizeColumns();
                DtgCuentaActual.AutoResizeRows();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

