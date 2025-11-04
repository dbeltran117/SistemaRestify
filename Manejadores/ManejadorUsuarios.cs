using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorUsuarios
    {
        Base b = new Base("localhost", "root", "12345", "restauranteSft", 3306);

        public void CrearUsuarios(Usuarios u)
        {
            b.Comando($"CALL p_insertUsuarios('{u.Nombre}','{u.Clave}')");
        }

        public void EliminarUsuarios(int idUsuario)
        {
            b.Comando($"CALL p_deleteUsuarios({idUsuario})");
        }

        public bool ValidarMeseros(TextBox usuario, TextBox clave) 
        {
            DataRow dr = b.Consultar($"call p_validarMeseros('{usuario.Text}','{Sha1(clave.Text)}')", "usuarios").Tables[0].Rows[0];
            if (dr["rs"].Equals("Ac3ptad0"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarAdmin(TextBox usuario, TextBox clave)
        {
            DataRow dr = b.Consultar($"call p_validarAdmin('{usuario.Text}','{Sha1(clave.Text)}')", "usuarios").Tables[0].Rows[0];
            if (dr["rs"].Equals("Ac3ptad0"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VerUsuarioMesero(string usuario,Label useract)
        {
            DataSet ds = b.Consultar($"select nombre from usuarios where nombre = '{usuario}' AND tipoUser = 'Mesero'", "usuarios");
            if (ds.Tables[0].Rows.Count > 0)
            {
                usuario = ds.Tables[0].Rows[0]["nombre"].ToString();
                useract.Text = usuario;
            }
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
