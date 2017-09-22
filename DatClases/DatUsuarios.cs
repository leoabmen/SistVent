using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
    public class DatUsuarios : DatAbstracta
    {
        public DataTable GetUsuarios(string usuario)
        {
            MySqlCommand com = new MySqlCommand("SELECT COUNT(*) CANTIDAD FROM USUARIOS WHERE USUA_NOMB = '" + usuario + "'", con);
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetContraseñas(string usuario, string contraseña)
        {
            MySqlCommand com = new MySqlCommand("SELECT COUNT(*) CANTIDAD FROM USUARIOS WHERE USUA_NOMB = '" + usuario + "' AND USUA_PASS ='" + contraseña + "'", con);
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
