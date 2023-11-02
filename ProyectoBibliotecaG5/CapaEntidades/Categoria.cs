using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Categoria

    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria(int id, string descripcion)
        {
            this.Id = id;
            Descripcion = descripcion;
        }
        public Categoria(string descripcion)
        {
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
