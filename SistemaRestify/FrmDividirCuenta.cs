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
    public partial class FrmDividirCuenta : Form
    {
        ManejadorPrincipal mp;
        private Cuentas cuentaMesa;
        public FrmDividirCuenta(Cuentas cuenta)
        {
            InitializeComponent();
            mp = new ManejadorPrincipal();
            mp.LlenarGridCuenta(DtgCuentaActual);
            cuentaMesa = cuenta;
        }
        private void FrmDividirCuenta_Load(object sender, EventArgs e)
        {
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
            DtgCuentaActual.AutoResizeColumns();
            DtgCuentaActual.AutoResizeRows();
            mp.ActualizarTotalOrigen(DtgCuentaActual, LblTotal);
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCuentasAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCantidadC.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la cantidad de cuentas a agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    mp.GenerarCuentasVisuales(PCuentas, Convert.ToInt32(TxtCantidadC.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al agregar una nueva cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgCuentaActual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mp.cuentaActiva > 0)
            {
                string producto = DtgCuentaActual.Rows[e.RowIndex].Cells["Producto"].Value.ToString();
                int cantidad = Convert.ToInt32(DtgCuentaActual.Rows[e.RowIndex].Cells["Cantidad"].Value);
                double precio = Convert.ToDouble(DtgCuentaActual.Rows[e.RowIndex].Cells["Precio Unitario"].Value);

                // 🔹 Restar 1 a la cantidad en origen
                cantidad -= 1;

                if (cantidad > 0)
                {
                    DtgCuentaActual.Rows[e.RowIndex].Cells["Cantidad"].Value = cantidad;
                }
                else
                {
                    // Si ya no queda, eliminar la fila
                    DtgCuentaActual.Rows.RemoveAt(e.RowIndex);
                }

                // 🔹 Agregar al grid destino
                foreach (Control ctrl in PCuentas.Controls)
                {
                    if (ctrl is DataGridView dgv && (int)dgv.Tag == mp.cuentaActiva)
                    {
                        bool encontrado = false;

                        // Buscar si ya existe el producto en la cuenta
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (row.Cells["Producto"].Value?.ToString() == producto)
                            {
                                // Ya existe → incrementar cantidad
                                int cantDestino = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                cantDestino += 1;
                                row.Cells["Cantidad"].Value = cantDestino;

                                // Recalcular subtotal
                                row.Cells["Subtotal"].Value = cantDestino * precio;

                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            // No existe → agregar nueva fila
                            dgv.Rows.Add(producto, 1, precio, precio);
                        }
                    }
                }

                // 🔹 Actualizar total de la cuenta activa
                mp.ActualizarTotal(PCuentas,mp.cuentaActiva);
                mp.ActualizarTotalOrigen(DtgCuentaActual,LblTotal);
            }

        }

    }
}

