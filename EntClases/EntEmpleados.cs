using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Entity
{
    public class EntEmpleados
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public int sexoId { get; set; }
        public int puestoId { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaSalida { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string observaciones { get; set; }

        private EntSexo sexo;

        public EntSexo Sexo
        {
            get
            {
                if(sexo==null)
                {
                    sexo = new EntSexo();
                }
                return Sexo; 
            }
            set
            { 
                if (sexo==null)
                {
                    sexo = new EntSexo();
                }
                sexo = value;
            }
        }
        private EntPuestos puesto;

        public EntPuestos Puesto
        {
            get
            {
                if (puesto == null)
                {
                    puesto = new EntPuestos();
                }
                return puesto;
            }
            set
            {
                if (puesto == null)
                {
                    puesto = new EntPuestos();
                }
                puesto = value; 
            }
        }
        
    }
}
