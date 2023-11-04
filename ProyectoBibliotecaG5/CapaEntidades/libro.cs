
using CapaEntidades;
using System;
using System.Collections.Generic;

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
        public string CategoriasString { get; set; }
        public string AutoresString { get; set; }
        public List<Categoria> Categorias { get; set; } // Ahora es una lista
        public List<Autor> Autores { get; set; } // Ahora es una lista

    public Libro()
    {
    }

    public Libro(string isbn)
    {
        Isbn = isbn;
    }

    public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidadesDisponibles, bool esPrestable)
    {
        Isbn = isbn;
        Titulo = titulo;
        Editorial = editorial;
        Sinopsis = sinopsis;
        Caratula = caratula;
        CantidadUnidadesDisponibles = cantidadUnidadesDisponibles;
        EsPrestable = esPrestable;
    }

    public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidadesDisponibles, bool esPrestable, string bibliotecaNombre,List<Categoria> categorias, List<Autor> autores)
    {
        Isbn = isbn;
        Titulo = titulo;
        Editorial = editorial;
        Sinopsis = sinopsis;
        Caratula = caratula;
        CantidadUnidadesDisponibles = cantidadUnidadesDisponibles;
        EsPrestable = esPrestable;
        BibliotecaNombre = bibliotecaNombre;
        Categorias = categorias;
        Autores = autores;
    }

    public Libro(string isbn, string titulo, string editorial, string sinopsis, string caratula, int cantidadUnidadesDisponibles, bool esPrestable, string categorias, string autores)
    {
        Isbn = isbn;
        Titulo = titulo;
        Editorial = editorial;
        Sinopsis = sinopsis;
        Caratula = caratula;
        CantidadUnidadesDisponibles = cantidadUnidadesDisponibles;
        EsPrestable = esPrestable;
        CategoriasString = categorias;
        AutoresString = autores;
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
