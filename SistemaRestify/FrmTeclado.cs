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
    public partial class FrmTeclado : Form
    {
        public TextBox CampoDestino { get; set; }
        public FrmTeclado()
        {
            InitializeComponent();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "Q";
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "A";
            }
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "Z";
            }
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "W";
            }
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "S";
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "X";
            }
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "E";
            }
        }

        private void BntD_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "D";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "C";
            }
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "R";
            }
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "F";
            }
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "V";
            }
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "T";
            }
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "G";
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "B";
            }
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "Y";
            }
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "H";
            }
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "N";
            }
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "U";
            }
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "J";
            }
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "M";
            }
        }

        private void BntI_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "I";
            }
        }

        private void BntK_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "K";
            }
        }

        private void BtnComa_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += ",";
            }
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "O";
            }
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "L";
            }
        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += ".";
            }
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "P";
            }
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += "Ñ";
            }
        }

        private void BtnEspacio_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null)
            {
                CampoDestino.Text += " ";
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (CampoDestino != null && CampoDestino.Text.Length > 0)
            {
                CampoDestino.Text = CampoDestino.Text.Substring(0, CampoDestino.Text.Length - 1);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
