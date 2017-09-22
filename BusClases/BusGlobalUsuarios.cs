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
    public class BusGlobalUsuarios
    {
         public BusGlobalUsuarios() { }
         public void ObtenerDatosGlobales(string usuario)
         {
             DataTable dt = new DatGlobalUsuarios().ObtenerDatosGlobales(usuario);
             EntGlobalUsuarios.IdUsuario = dt.Rows[0]["USUA_ID"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_ID"].ToString());
             EntGlobalUsuarios.NombreUsuario = dt.Rows[0]["USUA_NOMB"].ToString() == null ? "" : dt.Rows[0]["USUA_NOMB"].ToString();
             EntGlobalUsuarios.Estatus = dt.Rows[0]["USUA_ESTA"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_ESTA"].ToString());
             EntGlobalUsuarios.IdPerfil = dt.Rows[0]["USUA_PERF_ID"].ToString() == null ? 0 : Convert.ToInt32(dt.Rows[0]["USUA_PERF_ID"].ToString());
             
         }

    }
}
