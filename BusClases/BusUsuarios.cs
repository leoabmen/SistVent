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
    public class BusUsuarios
    {

        public BusUsuarios() { }

        public Boolean GetUsuarios(string usuario)
        {
            DataTable dt = new DatUsuarios().GetUsuarios(usuario);
            Boolean bol;
            if (Convert.ToInt32(dt.Rows[0]["CANTIDAD"].ToString()) > 0)
            {

                bol = true;
            }
            else
            {
                bol = false;
            }
            return bol;

            //EntUsuarios ent = new EntUsuarios();
            //ent.id = dt.Rows[0]["USUA_ID"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_ID"].ToString());
            //ent.nombre = dt.Rows[0]["USUA_NOMB"].ToString() == null ? "" : dt.Rows[0]["USUA_NOMB"].ToString();
            //ent.contraseña = dt.Rows[0]["USUA_PASS"].ToString() == null ? "" : dt.Rows[0]["USUA_PASS"].ToString();
            //ent.empleadoId = dt.Rows[0]["USUA_EMPL_ID"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_EMPL_ID"].ToString());
            //ent.estado = dt.Rows[0]["USUA_ESTA"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_ESTA"].ToString());
            //return ent;
        }
        public Boolean GetContraseñas(string usuario, string contraseña)
        {
            DataTable dt = new DatUsuarios().GetContraseñas(usuario, contraseña);
            Boolean bol;
            if (Convert.ToInt32(dt.Rows[0]["CANTIDAD"].ToString()) > 0)
            {

                bol = true;
            }
            else
            {
                bol = false;
            }
            return bol;
        }
    }
}
