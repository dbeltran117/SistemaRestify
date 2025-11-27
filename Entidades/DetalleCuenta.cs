using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleCuenta
    {
        public int IdDetalleCuenta { get; set; }
        public int Cantidad { get; set; }
        public int FkIdProductoVenta { get; set; }
        public int FkIdCuenta { get; set; }
    }
}
