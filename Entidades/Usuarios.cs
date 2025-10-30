using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string nombre, string clave)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Clave = clave;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
