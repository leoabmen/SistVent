using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
    public class DatComandos:DatAbstracta
    {
        public int InsertaComando(string strSql)
        {
           
            MySqlCommand com = new MySqlCommand(strSql, con);
            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery(); //respuesta de ejecucion del query en la BD
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error al insertar el producto en la capa de datos, " + ex.Message);
            }
        }
        public int ActualizaComando(string strSql)
        {

            MySqlCommand com = new MySqlCommand(strSql, con);

            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery(); //respuesta de ejecucion del query en la BD
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException("Error al Actualizar el producto en la capa de datos, " + ex.Message);
            }
        }
        public DataTable ConsultasComando(string strSql)
        {
            MySqlCommand com = new MySqlCommand(strSql, con);
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
