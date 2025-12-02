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
    public partial class FrmAgregarUsuarios : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmAgregarUsuarios()
        {
            InitializeComponent();
            mpa = new ManejadorPrincipalAdmin();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "" || TxtClave.Text == "" || CmbTipoUser.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string clave = TxtClave.Text.ToUpper();
                string nombre = TxtNombre.Text.ToUpper();
                mpa.AgregarUsuario(nombre, clave, CmbTipoUser.Text);
                mpa.MostrarUsuarios("select * from v_usuarios", DtgUsuarios, "usuarios");
                TxtClave.Clear();
                TxtNombre.Clear();
            }
        }

        private void FrmAgregarUsuarios_Load(object sender, EventArgs e)
        {
            mpa.MostrarUsuarios("select * from v_usuarios",DtgUsuarios,"usuarios");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DtgUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(DtgUsuarios.CurrentRow.Cells["idUsuario"].Value);
                string nombreUsuario = DtgUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();

                var confirm = MessageBox.Show($"¿Está seguro de que desea eliminar al usuario: {nombreUsuario}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    mpa.EliminarUsuario(idUsuario);
                    mpa.MostrarUsuarios("select * from v_usuarios", DtgUsuarios, "usuarios");
                    TxtNombre.Clear();
                    TxtClave.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
