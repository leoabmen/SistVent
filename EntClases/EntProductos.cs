using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stmx.Siscomic.Entity
{
    public class EntProductos
    {
        public String Id { get; set; }
        public String Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int ColorId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioId { get; set; }
        public string Observaciones { get; set; }
        public int Estatus { get; set; }

        private EntCategoria categoria;

        public EntCategoria Categoria
        {

            get
            {
                if (categoria == null)
                    categoria = new EntCategoria();
                return categoria;
            }
            set
            {
                if (categoria == null)
                    categoria = new EntCategoria();
                categoria = value;
            }


        }

        private EntMarca marca;

        public EntMarca Marca
        {
            get
            {
                if (marca == null)
                    marca = new EntMarca();
                return marca;
            }
            set
            {
                if (marca == null)
                {
                    marca = new EntMarca();
                }
                marca = value;
            }
        }
        private EntModelo modelo;

        public EntModelo Modelo
        {
            get
            {
                if (modelo == null)
                    modelo = new EntModelo();
                return modelo;
            }
            set
            {
                if (modelo==null)
                {
                    modelo = new EntModelo();
                }
                modelo = value;
            }
        }
        private EntColores color;

        public EntColores Color
        {
            get { 
                if (color == null)
                { 
                    color = new EntColores(); 
                }
            
                return color;
            }
            set 
            {
                if (color == null)
                {
                    color = new EntColores();
                }
                color = value;
            }
        }
        


    }

    public class EntCategoria
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
    }
    public class EntMarca
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
    }
    public class EntModelo
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int MarcaId { get; set; }
        private EntMarca marca;

        public EntMarca Marca
        {
            get
            {
                if (marca == null)
                    marca = new EntMarca();
                return marca;
            }
            set
            {
                if (marca == null)
                {
                    marca = new EntMarca();
                }
                
                marca = value;
            }
        }
        
    }
    public class EntColores
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
