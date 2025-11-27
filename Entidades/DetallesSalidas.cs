using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesSalidas
    {
        public int FkIdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }
    }
}
