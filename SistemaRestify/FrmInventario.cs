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
    public partial class FrmInventario : Form
    {
        ManejadorPrincipalAdmin mpa;
        public FrmInventario()
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
            mpa.MostrarInventario($"select * from v_inventario where Producto like '%{TxtProducto.Text}%'", DtgInventario, "productosCompra");
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            mpa.MostrarStockMinimo("select * from v_inventario where `Stock Actual` <= `Stock Minimo`",DtgStockMinimo, "productosCompra");
        }
    }
}
