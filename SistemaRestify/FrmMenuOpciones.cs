using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace SistemaRestify
{
    public partial class FrmMenuOpciones : Form
    {
        ManejadorPrincipal mp;
        public FrmMenuOpciones()
        {
            InitializeComponent();
            mp = new ManejadorPrincipal();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCerrarCuenta_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show($"¿Estás seguro de que deseas cerrar la cuenta de la mesa {FrmPrincipal.mesa.NombreMesa}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                mp.CerrarMesa(FrmPrincipal.mesa.NombreMesa,"","Disponible");
                mp.ActualizarEstadoMesa(FrmPrincipal.pmesas, FrmPrincipal.mesa.NombreMesa, "Disponible");
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
