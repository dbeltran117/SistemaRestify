using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuentas
    {
        public int IdCuenta { get; set; }
        public int FkIdMesa { get; set; }
        public int CantidadPersonas { get; set; }
        public int FkIdMesero { get; set; }
        public double Propina { get; set; } 
    }
}
