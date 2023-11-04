using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Biblioteca
    {

        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string Imagen { get; set; }

        public Biblioteca(string nombre, string lugar, string imagen)
        {
            Nombre = nombre;
            Lugar = lugar;
            Imagen = imagen;
        }
    }
}
