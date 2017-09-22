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
    public class BusPermisos
    {
        public BusPermisos() { }
        public List<EntPermisos> ObtenerPermisosUsuarios(int idPerfil, int idPantalla)
        {
            DataTable dt = new DatPermisos().ObtenerPermisos(idPerfil, idPantalla);
            List<EntPermisos> lst = new List<EntPermisos>();
            foreach (DataRow dr in dt.Rows)
            {
                EntPermisos ent = new EntPermisos();
                ent.idFuncion = dr["FUNC_ID"].ToString() == null ? 0 : Convert.ToInt32(dr["FUNC_ID"].ToString());
                ent.nombreFuncion = dr["FUNC_DESC"].ToString() == null ? "" : dr["FUNC_DESC"].ToString();
                ent.Estatus = dr["PPF_ESTA"].ToString() == null ? 0 : Convert.ToInt32(dr["PPF_ESTA"].ToString());
                lst.Add(ent);
            }
            return lst;
        }
        public Boolean ObtenerPermisos(int idPerfil, int idPantalla, int idFuncion)
        {
            Boolean validar = false;
            List<EntPermisos> lst = new BusPermisos().ObtenerPermisosUsuarios(idPerfil, idPantalla);
            foreach (EntPermisos per in lst)
            {
                if (lst.Exists(x => x.idFuncion == idFuncion) && lst.Exists(x => x.Estatus == 1))
                {
                    validar = true;

                }

            }
            return validar;


        }

    }
}
