using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Entity
{
    public class EntDefinicionVentanas
    {
      static int idFrmHome = 3;
      static int idFrmProductos = 1;

        public static int IdFrmHome
        {
            get
            {
                return idFrmHome;
            }
            //set
            //{   
            //    idHome = Convert.ToInt32(new EntDefinicionesGenerales().ToString());
            //    idHome = value;

            //}
        }
        public static int IdFrmProductos
        {
            get
            {
                return idFrmProductos;
            }
        }
    }


}
