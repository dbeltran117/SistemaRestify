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
    public partial class FrmAgregarProductoMenu : Form
    {
        ManejadorPrincipalAdmin mpa;
        FrmDatosCategorias fdc = new FrmDatosCategorias();
        public FrmAgregarProductoMenu()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
            mpa.LlenarCategorias(CmbCategorias);
            mpa.LlenarCategorias(CmbAddCategoria);

            fdc.OnCategoriaInsertada += nombre =>
            {
                mpa.LlenarCategorias(CmbCategorias);
                mpa.LlenarCategorias(CmbAddCategoria);
            };

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            mpa.MostrarProdutos($"select * from v_productosVista where idCategoria = {CmbCategorias.SelectedValue}", DtgProductos, "productosVenta");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            fdc.ShowDialog();
        }

        private void BtnAgregarSubCategoria_Click(object sender, EventArgs e)
        {
            FrmDatosSubCategoria fdsc = new FrmDatosSubCategoria();
            fdsc.ShowDialog();
        }

        private void CmbAddCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAddCategoria.SelectedValue != null && CmbAddCategoria.SelectedValue is int)
            {
                int idCategoria = (int)CmbAddCategoria.SelectedValue;
                mpa.LlenarSubCategorias(CmbSubCat, idCategoria);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtCodigo.Text == null || TxtDesc.Text == null || CmbAddCategoria.SelectedValue.ToString() == null || TxtPrecio.Text == null || TxtImporte.Text == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mpa.AgregarProducto(TxtCodigo.Text, TxtDesc.Text, int.Parse(CmbAddCategoria.SelectedValue.ToString()), double.Parse(TxtPrecio.Text), double.Parse(TxtImporte.Text));
                    mpa.MostrarProdutos($"select * from v_productosVista where idCategoria = {CmbCategorias.SelectedValue}", DtgProductos, "productosVenta");
                    TxtCodigo.Clear();
                    TxtDesc.Clear();
                    TxtPrecio.Clear();
                    TxtImporte.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el producto. Verifica los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DtgProductos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DtgProductos.SelectedRows[0].Cells["idProducto"].Value);
                string Desc = TxtDesc.Text = DtgProductos.SelectedRows[0].Cells["Producto"].Value.ToString();

                // Confirmación visual
                var confirm = MessageBox.Show($"¿Deseas eliminar el producto: {Desc}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    mpa.EliminarProducto(id); // ← método en tu capa de lógica
                    mpa.MostrarProdutos($"select * from v_productosVista where idCategoria = {CmbCategorias.SelectedValue}", DtgProductos, "productosVenta");
                    TxtCodigo.Clear();
                    TxtDesc.Clear();
                    TxtPrecio.Clear();
                    TxtImporte.Clear();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DtgProductos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DtgProductos.SelectedRows[0].Cells["idProducto"].Value);
                string Desc = TxtDesc.Text;
                int idCat = int.Parse(CmbAddCategoria.SelectedValue.ToString());
                double precio = double.Parse(TxtPrecio.Text);
                double importe = double.Parse(TxtImporte.Text);

                var confirm = MessageBox.Show($"¿Deseas editar el producto: {Desc}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes) 
                {
                    mpa.EditarProducto(id, Desc,idCat,precio, importe); // ← método en tu capa de lógica
                    mpa.MostrarProdutos($"select * from v_productosVista where idCategoria = {CmbCategorias.SelectedValue}", DtgProductos, "productosVenta");
                    TxtCodigo.Enabled = true;
                    BtnGuardar.Enabled = true;
                    TxtCodigo.Clear();
                    TxtDesc.Clear();
                    TxtPrecio.Clear();
                    TxtImporte.Clear();
                }
            }
        }

        private void DtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BtnGuardar.Enabled = false;
                TxtCodigo.Enabled = false;

                DataGridViewRow fila = DtgProductos.Rows[e.RowIndex];

                TxtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                int idProducto = Convert.ToInt32(fila.Cells["idProducto"].Value);
                TxtDesc.Text = fila.Cells["Producto"].Value.ToString();
                string idCategoria = fila.Cells["idCategoria"].Value.ToString();
                TxtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                TxtImporte.Text = fila.Cells["Importe"].Value.ToString();
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 🔹 Cancela la entrada
            }
        }

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 🔹 Cancela la entrada
            }
        }
    }
}

