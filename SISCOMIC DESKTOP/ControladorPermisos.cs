using Stmx.Siscomic.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCOMIC_DESKTOP
{
    public class ControladorPermisos
    {
        public void RevisarPermisosButton(Button btn, int idPerfil, int idPantalla, int idFuncion)
        {
            Boolean validar = new BusPermisos().ObtenerPermisos(idPerfil, idPantalla, idFuncion);
            if (validar == true)
            {
                btn.Visible = true;
            }
            else
            {
                btn.Visible = false;
            }

        }
        public void RevisarPermisosToolStripMenuItem(ToolStripMenuItem mi, int idPerfil, int idPantalla, int idFuncion)
        {
            Boolean validar = new BusPermisos().ObtenerPermisos(idPerfil, idPantalla, idFuncion);
            if (validar == true)
            {
                mi.Visible = true;
            }
            else
            {
                mi.Visible = false;
            }

        }
    }
}
