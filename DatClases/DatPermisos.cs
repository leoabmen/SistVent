using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
    public class DatPermisos : DatAbstracta
    {
        string strSql;
        public DataTable ObtenerPermisos(int idPerfil, int idPantalla){
            MySqlCommand com = new MySqlCommand("Call getPermisos(" + idPerfil + ", "+idPantalla+")", con);          
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
         
    }
}
