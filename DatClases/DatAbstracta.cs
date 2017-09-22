using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
   public class DatAbstracta
    {
        public MySqlConnection con;
        public DatAbstracta()
        {
            con = new MySqlConnection("server=127.0.0.1; database=alonso; Uid=root; pwd=leoncito;");
        }
    }
}
