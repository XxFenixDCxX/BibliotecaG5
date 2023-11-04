using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Lector : IEquatable<Lector>
    {
        //El numero de carnet es de tipo string 
        public string NumeroCarnet { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool conLibroPrestado { get; set; }
        public Lector() { }

        public Lector(string numeroCarnet)
        {
            NumeroCarnet = numeroCarnet;
        }

        public Lector(string numeroCarnet , string nombre , string contrasena , string Telefono , string email)
        {
            this.NumeroCarnet = numeroCarnet;
            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Telefono = Telefono;
            this.Email = email;
        }
        public Lector(string numeroCarnet, string nombre, string contrasena, string email)
        {
            this.NumeroCarnet = numeroCarnet;
            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Telefono = "";
            this.Email = email;

        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Lector);
        }

        public bool Equals(Lector other)
        {
            return !(other is null) &&
                   string.Equals(NumeroCarnet, other.NumeroCarnet, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1830482804 + NumeroCarnet.GetHashCode();
        }
    }
}
