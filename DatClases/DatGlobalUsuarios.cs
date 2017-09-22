using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
    public class DatGlobalUsuarios:DatAbstracta 
    {
        public DataTable ObtenerDatosGlobales(string usuario)
        {
             MySqlCommand com = new MySqlCommand("SELECT USUA_ID, USUA_NOMB, USUA_ESTA, USUA_PERF_ID FROM USUARIOS WHERE USUA_NOMB = '"+usuario+"'", con);
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
