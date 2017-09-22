using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Entity
{
    public class EntUsuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int empleadoId { get; set; }
        public int estado { get; set; }

        private EntEmpleados empleado;

        public EntEmpleados Empleado
        {
              get
            {
                if (empleado == null)
                {
                    empleado = new EntEmpleados();
                }
                return empleado;
            }
            set
            {
                if (empleado == null)
                {
                    empleado = new EntEmpleados();
                }
                empleado= value;
            }
        
        }
       
    }
}
