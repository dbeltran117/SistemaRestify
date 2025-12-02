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

                int idMesa;
                if (int.TryParse(FrmPrincipal.mesa.NombreMesa, out idMesa))
                {
                    var cuentaMesa = FrmPrincipal.cuentasActivas.FirstOrDefault(c => c.FkIdMesa == idMesa);

                    if (cuentaMesa != null)
                    {
                        mp.InsertarCuenta(cuentaMesa.FkIdMesa, cuentaMesa.CantidadPersonas, cuentaMesa.FkIdMesero);

                        foreach (var item in cuentaMesa.Detalles)
                        {
                            mp.InsertarDetalleCuenta(item.Cantidad, item.Precio, item.FkIdProductoVenta);
                        }
                        FrmPrincipal.cuentasActivas.Remove(cuentaMesa);
                        mp.CerrarReservacion();
                    }
                    else
                    {
                        MessageBox.Show("Esta mesa no tiene una cuenta activa. No se puede cerrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Close();
                }
            }
            else
            {
                return;
            }
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            int idMesa = int.Parse(FrmPrincipal.mesa.NombreMesa);

            var cuentaMesa = FrmPrincipal.cuentasActivas .FirstOrDefault(c => c.FkIdMesa == idMesa);

            if (cuentaMesa != null)
            {
                FrmCapturarPedido fcp = new FrmCapturarPedido(cuentaMesa);
                fcp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe una cuenta abierta para esta mesa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            int idMesa = int.Parse(FrmPrincipal.mesa.NombreMesa);

            var cuentaMesa = FrmPrincipal.cuentasActivas.FirstOrDefault(c => c.FkIdMesa == idMesa);

            if (cuentaMesa != null)
            {
                FrmDividirCuenta fdc = new FrmDividirCuenta(cuentaMesa);
                fdc.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe una cuenta abierta para esta mesa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
