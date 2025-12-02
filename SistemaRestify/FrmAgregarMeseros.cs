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
    public partial class FrmAgregarMeseros : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmAgregarMeseros()
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
            mpa.MostrarMeseros($"select * from v_meseros where Estado = '{CmbEstado.Text}'", DtgMeseros, "meseros");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombreMesero.Text == "")
                {
                    MessageBox.Show("Debe ingresar un nombre para el mesero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mpa.AgregarMeseros(TxtNombreMesero.Text);
                    TxtNombreMesero.Clear();
                    mpa.MostrarMeseros($"select * from v_meseros where Estado = '{CmbEstado.Text}'", DtgMeseros, "meseros");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el mesero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(DtgMeseros.SelectedRows.Count > 0)
            {
                int idMesero = Convert.ToInt32(DtgMeseros.CurrentRow.Cells["idMesero"].Value);
                string nombreMesero = DtgMeseros.CurrentRow.Cells["Nombre del Mesero"].Value.ToString();
                var confrim = MessageBox.Show($"¿Está seguro de eliminar el mesero: {nombreMesero}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confrim == DialogResult.Yes)
                {
                    mpa.EliminarMeseros(idMesero);
                    mpa.MostrarMeseros($"select * from v_meseros where Estado = '{CmbEstado.Text}'", DtgMeseros, "meseros");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un mesero para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
