using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Data
{
    public class DatProductos : DatAbstracta
    {
        string strSql;
        public int AgregarProducto(string id, string descripcion, int categoria, int marca, int modelo, int color, int cantidad, string fechaAlta, int usuario, string observaciones, int estatus)
        {
            strSql = "INSERT INTO PRODUCTOS (PROD_ID, PROD_DESC,  PROD_CATE_ID, PROD_MARC_ID, PROD_MODE_ID, PROD_COLO_ID, PROD_CANT, PROD_FECH_ALTA, PROD_USUA_ID, PROD_OBSE, PROD_ESTA) "
                   + "VALUES ( '" + id + "','" + descripcion + "', " + categoria + "," + marca + "," + modelo + "," + color + "," + cantidad + ",'" + fechaAlta + "'," + usuario + ",'" + observaciones + "'," + estatus + ")";
            int filas = new DatComandos().InsertaComando(strSql);
            return filas;
        }
        public int RegistrarPrecioProductos(string clave, double precioCompra, double precioVenta, string fechaInicio, string fechaFin)
        {
            strSql = "INSERT INTO PRECIOS_PRODUCTOS (PREC_COSTO, PREC_VENTA, PREC_FECH_INIC, PREC_FECH_FIN, PREC_PROD_ID) "
                + "VALUES ('"+precioCompra+"','"+precioVenta+"','"+fechaInicio+"','"+fechaFin+"','"+clave+"')";
            int filas = new DatComandos().InsertaComando(strSql);
            return filas;
           
        }
        public int ActualizarPrecioProductos(int idPrecio, string clave, double precioCompra, double precioVenta, string fechaInicio, string fechaFin)
        {
            strSql = "UPDATE PRECIOS_PRODUCTOS SET PREC_COSTO= '" + precioCompra + "', PREC_VENTA= '" + precioVenta + "', PREC_FECH_INIC= '" + fechaInicio + "', PREC_FECH_FIN= '" + fechaFin + "' "
            + "WHERE PREC_ID= '" + idPrecio + "' AND PREC_PROD_ID= '" + clave + "'";
            int filas = new DatComandos().ActualizaComando(strSql);
            return filas;

        }
        public int ActualizarProducto(string clave, string descripcion, int categoria, int marca, int modelo, int color, int cantidad, string fechaAlta, int usuario, string observaciones, int estatus)
        {
            strSql = "UPDATE PRODUCTOS SET PROD_DESC='"+descripcion+"',  PROD_CATE_ID="+categoria+", PROD_MARC_ID="+marca+", PROD_MODE_ID="+modelo+", PROD_COLO_ID="+color+", PROD_CANT="+cantidad+", PROD_FECH_ALTA='"+fechaAlta+"',"
            +"PROD_USUA_ID="+usuario+", PROD_OBSE='"+observaciones+"', PROD_ESTA="+estatus+" WHERE PROD_ID='"+clave+"'";
            int filas = new DatComandos().ActualizaComando(strSql);
            return filas;
        }
        public int ActualizarStockProductos(string clave, int cantidad, int usuario)
        {
            strSql = "UPDATE PRODUCTOS SET PROD_CANT = "+cantidad+", PROD_USUA_ID = "+usuario+" WHERE PROD_ID = '"+clave+"'";
            int filas = new DatComandos().ActualizaComando(strSql);
            return filas;
        }
        public int CierraVigenciaPrecio(string fecha, string clave, int idPrecio)
        {
            strSql = "UPDATE PRECIOS_PRODUCTOS SET PREC_FECH_FIN='" + fecha + "' WHERE PREC_PROD_ID='" + clave + "' AND PREC_ID= "+idPrecio+"";
            int filas = new DatComandos().ActualizaComando(strSql);
            return filas;
        }
        public DataTable LLenarCombos(string tabla) 
        {
            DataTable dt = new DataTable();
            strSql = "SELECT * FROM "+tabla+"";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt; 
        }
        public DataTable LLenarCombos(string tabla, int idPadre, string colPivote)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT * FROM " + tabla + " WHERE "+colPivote+" = "+idPadre+"";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;            
        }
        public DataTable LLenarCombosCompuestos(string columnas, string tablas, string cruceTablas, int idPadre)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT "+columnas+" FROM " + tablas + " WHERE " + cruceTablas + " = " + idPadre + "";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
            
        }
        public DataTable ValidarClave(string claveProducto)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT COUNT(PROD_ID)CANTIDAD FROM PRODUCTOS WHERE PROD_ID='"+claveProducto+"'";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable GetFullProductos()
        {
            DataTable dt = new DataTable();
            strSql = "CALL GET_FULL_PRODUCTOS";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerProducto(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "CALL GET_PRODUCTO('"+clave+"')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerProductoIdCB(string clave, int copias)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT PROD_ID FROM PRODUCTOS WHERE PROD_ID = '" + clave + "'";
            for (int i = 0; i < copias; i++)
            {
                strSql = strSql + "UNION ALL SELECT PROD_ID FROM PRODUCTOS WHERE PROD_ID = '" + clave + "'";
            }
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ValidarPrecio(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT COUNT(PREC_ID)CANTIDAD FROM PRECIOS_PRODUCTOS WHERE PREC_PROD_ID = '" + clave + "'";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ValidarDescuento(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "SELECT COUNT(DESC_ID)CANTIDAD FROM DESCUENTOS_PRODUCTOS WHERE DESC_PROD_ID = '" + clave + "'";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerPrecio(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "CALL GET_PRECIO('" + clave + "')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerDescuento(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "CALL GET_DESCUENTO('" + clave + "')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerUltimoPrecioId(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "GET_ULTIMO_PRECIO('" + clave + "')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerHistoricoPrecio(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "GET_HISTORICO_PRECIO('" + clave + "')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
        public DataTable ObtenerStockHistorico(string clave)
        {
            DataTable dt = new DataTable();
            strSql = "GET_STOCK_HISTORICO('" + clave + "')";
            dt = new DatComandos().ConsultasComando(strSql);
            return dt;
        }
    }

}
