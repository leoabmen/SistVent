using Stmx.Siscomic.Data;
using Stmx.Siscomic.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Business
{
    public class BusProductos
    {
        public BusProductos() { }
        public int AgregarProducto(EntProductos prod)
        {
            int filas = new DatProductos().AgregarProducto(prod.Id, prod.Descripcion, prod.CategoriaId, prod.MarcaId, prod.ModeloId, prod.ColorId, prod.Cantidad, prod.FechaAlta.ToString("yyyy-MM-dd"), prod.UsuarioId, prod.Observaciones, prod.Estatus);
            // if (prod.Clave != "")
            //  {
            return filas;

            // }
            //   else if (filas != 1)
            //   throw new ApplicationException(string.Format("Error al insertar a {0} {1}", prod.Clave, prod.Descripcion));
        }
        public int ActualizarProducto(EntProductos prod)
        {
            int filas = new DatProductos().ActualizarProducto(prod.Id, prod.Descripcion, prod.CategoriaId, prod.MarcaId, prod.ModeloId, prod.ColorId, prod.Cantidad, prod.FechaAlta.ToString("yyyy-MM-dd"), prod.UsuarioId, prod.Observaciones, prod.Estatus);
            return filas;

        }
        public int RegistrarPrecioProductos(string clave, double precioCompra, double preciVenta, DateTime fechaInicio, DateTime fechaFin)
        {
            int filas = new DatProductos().RegistrarPrecioProductos(clave, precioCompra, preciVenta, fechaInicio.ToString("yyyy-MM-dd"), fechaFin.ToString("yyyy-MM-dd"));
            return filas;
        }
        public int ActualizarPrecioProductos(int idPrecio, string clave, double precioCompra, double preciVenta, DateTime fechaInicio, DateTime fechaFin)
        {
            int filas = new DatProductos().ActualizarPrecioProductos(idPrecio, clave, precioCompra, preciVenta, fechaInicio.ToString("yyyy-MM-dd"), fechaFin.ToString("yyyy-MM-dd"));
            return filas;
        }
        public int ActualizarStockProductos(string clave, int cantidad, int usuario)
        {
            int filas = new DatProductos().ActualizarStockProductos(clave, cantidad, usuario);
            return filas;
        }      
        public List<EntCategoria> CargarComboCategoria()
        {
            DataTable dt = new DatProductos().LLenarCombos("CATEGORIA_PRODUCTOS");
            List<EntCategoria> lst = new List<EntCategoria>();
            lst.Add(new EntCategoria() { Id = 0, Descripcion = "--Seleccionar--" });

            foreach (DataRow dr in dt.Rows)
            {
                EntCategoria ent = new EntCategoria();
                ent.Id = Convert.ToInt32(dr["CATE_ID"].ToString());
                ent.Descripcion = dr["CATE_DESC"].ToString();
                lst.Add(ent);
            }

            return lst;
        }
        public List<EntMarca> CargarComboMarca()
        {
            DataTable dt = new DatProductos().LLenarCombos("MARCA_PRODUCTOS");
            List<EntMarca> lst = new List<EntMarca>();
            lst.Add(new EntMarca() { Id = 0, Descripcion = "--Seleccionar--" });
            foreach (DataRow dr in dt.Rows)
            {
                EntMarca ent = new EntMarca();
                ent.Id = Convert.ToInt32(dr["MARC_ID"].ToString());
                ent.Descripcion = dr["MARC_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntModelo> CargarComboModelo(int idPadre)
        {
            DataTable dt = new DatProductos().LLenarCombos("MODELO_PRODUCTOS", idPadre, "MODE_MARC_ID");
            List<EntModelo> lst = new List<EntModelo>();
            lst.Add(new EntModelo() { Id = 0, Descripcion = "--Seleccionar--" });
            foreach (DataRow dr in dt.Rows)
            {
                EntModelo ent = new EntModelo();
                ent.Id = Convert.ToInt32(dr["MODE_ID"].ToString());
                ent.Descripcion = dr["MODE_DESC"].ToString();
                ent.MarcaId = Convert.ToInt32(dr["MODE_MARC_ID"].ToString());
                lst.Add(ent);
            }
            return lst;
        }
        public List<EntColores> CargarComboColor(int idPadre)
        {
            DataTable dt = new DatProductos().LLenarCombosCompuestos("COL.COLO_ID ID, COL.COLO_DESC DESCRIPCION", "COLORES COL, MODELOS_X_COLORES MXC, MODELO_PRODUCTOS MDL", "COL.COLO_ID = MXC.MXC_COLO_ID AND MDL.MODE_ID = MXC.MXC_MODE_ID AND MDL.MODE_ID", idPadre);
            List<EntColores> lst = new List<EntColores>();
            lst.Add(new EntColores() { Id = 0, Descripcion = "--Seleccionar--" });
            foreach (DataRow dr in dt.Rows)
            {
                EntColores ent = new EntColores();
                ent.Id = Convert.ToInt32(dr["ID"].ToString());
                ent.Descripcion = dr["DESCRIPCION"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
        public Boolean ValidarClave(string claveProducto)
        {
            Boolean validar = false;
            DataTable dt = new DatProductos().ValidarClave(claveProducto);
            int cantidad = dt.Rows[0]["CANTIDAD"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["CANTIDAD"].ToString());
            if (cantidad > 0)
            {
                validar = true;
            }
            return validar;
        }
        public DataTable GetFullProductos()
        {
            DataTable dt = new DatProductos().GetFullProductos();
            return dt;
        }
        public DataTable ObtenerHistoricoPrecio(string clave)
        {
            DataTable dt = new DatProductos().ObtenerHistoricoPrecio(clave);
            return dt;
        }
        public DataTable ObtenerStockHistorico(string clave)
        {
            DataTable dt = new DatProductos().ObtenerStockHistorico(clave);
            return dt;
        }
        public EntProductos ObtenerProducto(string clave)
        {
            DataTable dt = new DatProductos().ObtenerProducto(clave);
            EntProductos ent = new EntProductos();
            ent.Id = dt.Rows[0]["PROD_ID"].ToString();
            ent.Descripcion = dt.Rows[0]["PROD_DESC"].ToString();
            ent.Cantidad = Convert.ToInt32(dt.Rows[0]["PROD_CANT"].ToString());
            ent.CategoriaId = Convert.ToInt32(dt.Rows[0]["PROD_CATE_ID"].ToString());
            ent.MarcaId = Convert.ToInt32(dt.Rows[0]["PROD_MARC_ID"].ToString());
            ent.ModeloId = Convert.ToInt32(dt.Rows[0]["PROD_MODE_ID"].ToString());
            ent.ColorId = Convert.ToInt32(dt.Rows[0]["PROD_COLO_ID"].ToString());
            ent.FechaAlta = Convert.ToDateTime(dt.Rows[0]["PROD_FECH_ALTA"].ToString());
            ent.Observaciones = dt.Rows[0]["PROD_OBSE"].ToString();
            ent.UsuarioId = Convert.ToInt32(dt.Rows[0]["PROD_USUA_ID"].ToString());
            ent.Estatus = Convert.ToInt32(dt.Rows[0]["PROD_ESTA"].ToString());
            return ent;
        }
        public DataTable ObtenerProductoIdCB(string clave, int copias)
        {
            DataTable dt = new DatProductos().ObtenerProductoIdCB(clave, copias);
            return dt;
        }
        public Boolean ValidarPrecio(string clave)
        {
            Boolean validar = false;
            DataTable dt = new DatProductos().ValidarPrecio(clave);
            int cantidad = dt.Rows[0]["CANTIDAD"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["CANTIDAD"].ToString());
            if (cantidad > 0)
            {
                validar = true;
            }
            return validar;
        }
        public List<string> ObtenerPrecio(string clave)
        {
            DataTable dt = new DatProductos().ObtenerPrecio(clave);
            List<string> lst = new List<string>();
            lst.Add(dt.Rows[0]["PREC_ID"].ToString() == null ? "" : dt.Rows[0]["PREC_ID"].ToString());
            lst.Add(dt.Rows[0]["PREC_COSTO"].ToString() == null ? "" : dt.Rows[0]["PREC_COSTO"].ToString());
            lst.Add(dt.Rows[0]["PREC_VENTA"].ToString() == null ? "" : dt.Rows[0]["PREC_VENTA"].ToString());
            lst.Add(dt.Rows[0]["PREC_FECH_INIC"].ToString() == null ? "" : dt.Rows[0]["PREC_FECH_INIC"].ToString());
            lst.Add(dt.Rows[0]["PREC_FECH_FIN"].ToString() == null ? "" : dt.Rows[0]["PREC_FECH_FIN"].ToString());
            return lst;
        }
        public int CierraVigenciaPrecio(DateTime fecha, string clave, int idPrecio)
        {
            int filas = new DatProductos().CierraVigenciaPrecio(fecha.ToString("yyyy-MM-dd HH:mm:ss"), clave, idPrecio);
            return filas;
        }
        public int ObtenerUltimoPrecioId(string clave)
        {
            DataTable dt = new DatProductos().ObtenerPrecio(clave);
            int idPrecio = dt.Rows[0]["PREC_ID"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["PREC_ID"].ToString());
            return idPrecio;
        }

    }

}
