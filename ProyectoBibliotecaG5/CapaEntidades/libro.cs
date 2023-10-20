
using System;

public class Libro : IEquatable<Libro>
{
	
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Sinopsis { get; set; }
        public string Caratula { get; set; }
        public int CantidadUnidadesDisponibles { get; set; }
        public bool EsPrestable { get; set; }
        public string BibliotecaNombre { get; set; }

    public Libro()
    {
    }

    public Libro(string isbn)
    {
        Isbn = isbn;
    }

    public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidadesDisponibles, bool esPrestable, string bibliotecaNombre)
    {
        Isbn = isbn;
        Titulo = titulo;
        Editorial = editorial;
        Sinopsis = sinopsis;
        Caratula = caratula;
        CantidadUnidadesDisponibles = cantidadUnidadesDisponibles;
        EsPrestable = esPrestable;
        BibliotecaNombre = bibliotecaNombre;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Libro);
    }

    public bool Equals(Libro other)
    {
        return !(other is null) &&
               string.Equals(Isbn, other.Isbn, StringComparison.OrdinalIgnoreCase);
    }
}
