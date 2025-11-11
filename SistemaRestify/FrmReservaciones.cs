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
    public partial class FrmReservaciones : Form
    {
        public FrmReservaciones()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Dibuja una sombra más grande y suave debajo
            for (int i = 0; i < 15; i++) // más iteraciones = sombra más extendida
            {
                int alpha = 40 - (i * 2); // empieza más opaca y se desvanece
                if (alpha < 0) alpha = 0;

                using (SolidBrush sombra = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    // desplazamiento hacia abajo y lados
                    e.Graphics.FillRectangle(sombra, i, btn.Height - 2 + i / 2, btn.Width, 5);
                }
            }

            // Texto centrado
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font,
                btn.ClientRectangle, btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void BtnCancelar_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Dibuja una sombra más grande y suave debajo
            for (int i = 0; i < 15; i++) // más iteraciones = sombra más extendida
            {
                int alpha = 40 - (i * 2); // empieza más opaca y se desvanece
                if (alpha < 0) alpha = 0;

                using (SolidBrush sombra = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    // desplazamiento hacia abajo y lados
                    e.Graphics.FillRectangle(sombra, i, btn.Height - 2 + i / 2, btn.Width, 5);
                }
            }

            // Texto centrado
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font,
                btn.ClientRectangle, btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
