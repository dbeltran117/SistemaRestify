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
    public partial class FrmConsultarPrecios : Form
    {
        ManejadorPrincipal mp;
        public FrmConsultarPrecios()
        {
            InitializeComponent();
            mp = new ManejadorPrincipal();
            mp.LlenarCategorias(CmbCategorias);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query;
            if (Convert.ToInt32(CmbCategorias.SelectedValue) == 0)
            {
                query = $"select * from v_productosVista where Producto like '%{TxtBuscar.Text}%'";
            }
            else
            {
                query = $"select * from v_productosVista where Producto like '%{TxtBuscar.Text}%' and idCategoria = {CmbCategorias.SelectedValue}";
            }

            mp.MostrarProdutos(query, DtgProductos, "productosVenta");
        }
    }
}
