using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestify
{
    public partial class FrmLoginMesero : Form
    {

        public FrmLoginMesero()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin fl = new FrmLogin();
            fl.Show();
            Close();
        }
    }
}
