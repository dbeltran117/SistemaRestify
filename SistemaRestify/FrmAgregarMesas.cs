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
    public partial class FrmAgregarMesas : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmAgregarMesas()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgregarMesas_Load(object sender, EventArgs e)
        {
            mpa.MostrarMesas("select * from v_mesas",DtgMesas,"mesas");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DtgMesas.SelectedRows.Count > 0)
            {
                string nombreMesa = DtgMesas.CurrentRow.Cells["Numero de Mesa"].Value.ToString();
                var confirm = MessageBox.Show($"¿Está seguro de eliminar la mesa {nombreMesa}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    mpa.EliminarMesas(nombreMesa);
                    mpa.MostrarMesas("select * from v_mesas", DtgMesas, "mesas");
                    BtnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnGuardar.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Seleccione una mesa para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNumMesa.Text == "")
                {
                    MessageBox.Show("Debe ingresar un número de mesa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mpa.AgregarMesas(TxtNumMesa.Text);
                    TxtNumMesa.Clear();
                    mpa.MostrarMesas("select * from v_mesas", DtgMesas, "mesas");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar la mesa. Verifique que el número sea valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DtgMesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnGuardar.Enabled = false;
        }

        private void TxtNumMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // 🔹 Cancela la entrada
            }
        }
    }
}
