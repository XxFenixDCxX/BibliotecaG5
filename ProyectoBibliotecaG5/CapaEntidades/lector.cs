using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class lector : IEquatable<lector>
    {
        public int NumeroCarnet { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public lector() { }
        public lector(int numeroCarnet , string nombre , string contrasena , string Telefono , string email)
        {
            this.NumeroCarnet = numeroCarnet;
            this.Nombre = nombre;
            this.Contrasena = contrasena;
            this.Telefono = Telefono;
            this.Email = email;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as lector);
        }

        public bool Equals(lector other)
        {
            return !(other is null) &&
                   NumeroCarnet == other.NumeroCarnet;
        }

        public override int GetHashCode()
        {
            return -1830482804 + NumeroCarnet.GetHashCode();
        }
    }
}
