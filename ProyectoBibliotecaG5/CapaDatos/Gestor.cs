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
        //meter usuarios
        public String MeterLector(Lector lector)
        {
            //lector existe en la lista de lectores?
            foreach (Lector l in lectores)
            {
                if (l.Equals(lector))
                {
                    return "El lector ya existe";
                }
            }
            lectores.Add(lector);
            return "Lector agregado correctamente";
        }   
        //meter libros
        public string AgregarLibro(Libro libro)
        {
            //libro existe en la lista de libros?
            
            //1ªforma de hacerlo
            foreach (Libro l in libros)
            {
                if (l.Equals(libro))
                {
                    return "El libro ya existe";
                }
            }
            //2ªforma de hacerlo
            //if (libros.Contains(libro))
            //{
            //    return "El libro ya existe";
            //}

            libros.Add(libro);
            return "Libro agregado correctamente";
        }

        //funcion actulizar la lista desde la base de datos
        public void ActualizarLista()
        {
          //TODO Hacer Actualizar lista con la base de datos cada vez que modifiquemos la lista
        }

        //elimiar libros
        public String EliminarLibro(Libro libro)
        {
            //libro existe en la lista de libros?
            foreach (Libro l in libros)
            {
                if (l.Equals(libro))
                {
                    return "Libro eliminado";
                }
            }
            libros.Add(libro);
            return "Libro no econtrado";
        }   

        //eliminar lector
        public String EliminarLector(Lector lector)
        {
            //lector existe en la lista de lectores?
            foreach (Lector l in lectores)
            {
                if (l.Equals(lector))
                {
                    return "Lector eliminado";
                }
            }
            lectores.Add(lector);
            return "Lector no econtrado";
        }

        //presata un libro a un lector en concreto
        public String Prestar(Lector lectorBuscar,Libro libroBuscar,out String errores)
        {
            errores = "";
            foreach (Lector lectorAux in lectores)
            {
                if (lectorAux.Equals(lectorBuscar))
                {
                    foreach (Libro libroAux in libros)
                    {
                        if (libroAux.Equals(libroBuscar))
                        {
                            if (libroAux.CantidadUnidadesDisponibles > 0)
                            {
                                libroAux.CantidadUnidadesDisponibles--;
                                lectorAux.conLibroPrestado = true;
                                return $"Libro prestado al lector {lectorAux}";
                            }
                            else
                            {
                                return errores;
                            }
                        }
                    }
                }
            }
            return errores;
        }

        //devolver libro
        public String Devolver(Lector lectorBuscar, Libro libroBuscar, out String errores)
        {
            errores = "";
            foreach (Lector lectorAux in lectores)
            {
                if (lectorAux.Equals(lectorBuscar))
                {
                    foreach (Libro libroAux in libros)
                    {
                        if (libroAux.Equals(libroBuscar))
                        {
                            if (libroAux.CantidadUnidadesDisponibles > 0)
                            {
                                libroAux.CantidadUnidadesDisponibles++;
                                lectorAux.conLibroPrestado = false;
                                return $"Libro devuelto por el lector {lectorAux}";
                            }
                            else
                            {
                                return errores;
                            }
                        }
                    }
                }
            }
            return errores;
        }   

    }
}

    }
}
