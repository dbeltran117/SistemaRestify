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
    public partial class FrmAbrirMesa : Form
    {
        public TextBox CampoDestinoCP { get; set; }
        public static int MesaSeleccionada { get; set; }
        public static int CantidadPersonas { get; set; }

        ManejadorPrincipal mp;
        public FrmAbrirMesa()
        {
            InitializeComponent();
            CampoDestinoCP = TxtCantidadPersonas;
            mp = new ManejadorPrincipal();
            mp.MostrarMesas(CmbMesas);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtEtiqueta_Click(object sender, EventArgs e)
        {
            FrmTeclado ft = new FrmTeclado();
            ft.CampoDestino = TxtEtiqueta;
            ft.ShowDialog();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "0";
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "2";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "3";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "4";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "5";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "6";
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "7";
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "8";
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null)
            {
                CampoDestinoCP.Text += "9";
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (CampoDestinoCP != null && CampoDestinoCP.Text.Length > 0)
            {
                CampoDestinoCP.Text = CampoDestinoCP.Text.Substring(0, CampoDestinoCP.Text.Length - 1);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCantidadPersonas.Text))
            {
                MessageBox.Show("Por favor, seleccione el número de personas.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // detenemos aquí
            }

            MesaSeleccionada = Convert.ToInt32(CmbMesas.SelectedValue);
            CantidadPersonas = Convert.ToInt32(TxtCantidadPersonas.Text);

            // llamamos al procedure y capturamos el mensaje
            string mensaje = mp.AbrirMesa(CmbMesas.Text, TxtEtiqueta.Text, "Ocupada");
            if (!string.IsNullOrEmpty(mensaje))
            {
                // si hay mensaje, significa que la mesa está ocupada → mostramos y detenemos
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // si no hubo mensaje, todo salió bien → seguimos
            mp.ActualizarEstadoMesa(FrmPrincipal.pmesas, CmbMesas.Text, "Ocupada");
            this.Hide();
            FrmCapturarPedido fcp = new FrmCapturarPedido();
            fcp.ShowDialog();
        }
    }
}
