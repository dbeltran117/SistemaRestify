using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Base
    {
        MySqlConnection con;
        public Base(string servidor, string usuario, string password, string baseDatos, int puerto = 3306)
        {
            con = new MySqlConnection($"server={servidor}; user={usuario}; password={password}; database={baseDatos}; port={puerto};");
        }

        public void Comando(string cadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(cadena, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public DataSet Consultar(string consulta, string tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, con);
                con.Open();
                da.Fill(ds, tabla);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            return ds;
        }
    }
}
