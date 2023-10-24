using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        private Biblioteca biblioteca;
        private List<Autor> autores;
        private List<Libro> libros;
        private List<Lector> lectores;
        private List<Categoria> categorias;
        private const string cadConexion = "Data Source = .; Initial Catalog = GestorBibliotecaG5; Integrated Security = SSPI; MultipleActiveResultSets=true";

        public List<Autor> listarAutoresPorComienzo(String comienzo)
        {
            List<Autor> listActualizada = new List<Autor>();
            foreach (Autor autor in autores)
            {
                if (autor.Nombre.ToLower().StartsWith(comienzo.ToLower()))
                {
                    listActualizada.Add(autor);
                }
            }
            return listActualizada;
        }
        public List<Autor> listarAutores()
        {
            return this.listarAutoresPorComienzo("");
        }
        public List<Libro> listarLibrosPorComienzo(String comienzo)
        {
            List<Libro> listActualizada = new List<Libro>();
            foreach (Libro libro in libros)
            {
                if (libro.Titulo.ToLower().StartsWith(comienzo.ToLower()))
                {
                    listActualizada.Add(libro);
                }
            }
            return listActualizada;
        }
        public List<Libro> listarLibros()
        {
            return this.listarLibrosPorComienzo("");
        }
        public List<Lector> listarLectoresPorComienzo(String comienzo)
        {
            List<Lector> listActualizada = new List<Lector>();
            foreach (Lector lector in lectores)
            {
                if (lector.Nombre.ToLower().StartsWith(comienzo.ToLower()))
                {
                    listActualizada.Add(lector);
                }
            }
            return listActualizada;
        }
        public List<Lector> listarLectores()
        {
            return this.listarLectoresPorComienzo("");
        }
    }
}
