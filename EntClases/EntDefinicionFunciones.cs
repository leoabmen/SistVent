using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Entity
{
   public class EntDefinicionFunciones
    {
    
            static int idBtnInventario = 3;
            static int idBtnVentas = 4;
            static int idClickDerechoGridPrecioProducto = 5;
            static int idClickDerechoGridDescuentoProductos = 6;

            public static int IdBtnInventario
            {
                get
                {
                    return idBtnInventario;
                }
                //set
                //{   
                //    idHome = Convert.ToInt32(new EntDefinicionesGenerales().ToString());
                //    idHome = value;

                //}
            }
            public static int IdBtnVentas
            {
                get
                {
                    return idBtnVentas;
                }
            }
            public static int IdClickDerechoGridPrecioProducto
            {
                get
                {
                    return idClickDerechoGridPrecioProducto;
                }
            }
            public static int IdClickDerechoGridDescuentoProductos
            {
                get
                {
                    return idClickDerechoGridDescuentoProductos;
                }
            }
    }
}
