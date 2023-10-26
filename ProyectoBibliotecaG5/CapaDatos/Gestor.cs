using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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






        public List<Libro> listarLibrosPorComienzo(String comienzo,out string error)
        {


            error = "";
            List<Lector> listaLectores = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();
                    string sqlLectores = "SELECT * FROM Libro WHERE titulo LIKE @comienzo + '%';";
                    SqlCommand comandoLectores = new SqlCommand(sqlLectores, conexion);
                    comandoLectores.Parameters.AddWithValue("@comienzo", comienzo);
                    SqlDataReader readerLectores = comandoLectores.ExecuteReader();

                    while (readerLibros.Read())
                    {

                        string isbn = readerLibros.GetString(readerLibros.GetOrdinal("isbn"));
                        string titulo = readerLibros.GetString(readerLibros.GetOrdinal("titulo"));
                        string editorial = readerLibros.GetString(readerLibros.GetOrdinal("editorial"));
                        string sinopsis = readerLibros.GetString(readerLibros.GetOrdinal("sinopsis"));
                        string caratula = readerLibros.GetString(readerLibros.GetOrdinal("caratula"));
                        int cantidad_unidades_disponibles = readerLibros.GetInt32(readerLibros.GetOrdinal("cantidad_unidades_disponibles"));
                        bool es_prestable = readerLibros.GetBoolean(readerLibros.GetOrdinal("es_prestable"));


                        Libro libro = new Libro(isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades_disponibles, es_prestable, this.biblioteca.Nombre);
                        libros.Add(libro);
                    }

                }
                catch (Exception ex)
                {
                    error += ex.ToString();
                }
                return listaLectores;


                //List<Lector> listActualizada = new List<Lector>();
                //foreach (Lector lector in lectores)
                //{
                //    if (lector.Nombre.ToLower().StartsWith(comienzo.ToLower()))
                //    {
                //        listActualizada.Add(lector);
                //    }
                //}
                //return listActualizada;

            }
            //List<Libro> listActualizada = new List<Libro>();
            //foreach (Libro libro in libros)
            //{
            //    if (libro.Titulo.ToLower().StartsWith(comienzo.ToLower()))
            //    {
            //        listActualizada.Add(libro);
            //    }
            //}
            //return listActualizada;
        }






        public List<Libro> listarLibros()
        {
            return this.listarLibrosPorComienzo("");
        }






        public List<Lector> listarLectoresPorComienzo(String comienzo, out string error)
        {
            error = "";
            List<Lector> listaLectores = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();
                    string sqlLectores = "SELECT * FROM Lector WHERE nombre LIKE @comienzo + '%';";
                    SqlCommand comandoLectores = new SqlCommand(sqlLectores, conexion);
                    comandoLectores.Parameters.AddWithValue("@comienzo", comienzo);
                    SqlDataReader readerLectores = comandoLectores.ExecuteReader();
                    while (readerLectores.Read())
                    {
                        string numero_carnet = readerLectores.GetString(readerLectores.GetOrdinal("numero_carnet"));
                        string nombre = readerLectores.GetString(readerLectores.GetOrdinal("nombre"));
                        string contrasena = readerLectores.GetString(readerLectores.GetOrdinal("contrasena"));
                        string telefono = readerLectores.GetString(readerLectores.GetOrdinal("telefono"));
                        string email = readerLectores.GetString(readerLectores.GetOrdinal("email"));
                        Lector lector = new Lector(numero_carnet, nombre, contrasena, telefono, email);
                        listaLectores.Add(lector);
                    }

                }
                catch (Exception ex)
                {
                    error += ex.ToString();
                }
                return listaLectores;


                //List<Lector> listActualizada = new List<Lector>();
                //foreach (Lector lector in lectores)
                //{
                //    if (lector.Nombre.ToLower().StartsWith(comienzo.ToLower()))
                //    {
                //        listActualizada.Add(lector);
                //    }
                //}
                //return listActualizada;

            }
        }

        public List<Lector> listarLectores()
        {
            return this.listarLectoresPorComienzo("" ,out string error);
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

        public List<Lector> devolverListaDeMorosos(out String error)

        {

            error = "";
            List<Lector> listaMorosos = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {

                try
                {
                    conexion.Open();
                    
                    string sqlMorosos = "SELECT * FROM Lector INNER JOIN Prestamo ON Lector.numero_carnet = Prestamo.lector_numero_carnet WHERE Prestamo.fecha_devolucion < GETDATE(); ";
                    
                    SqlCommand comandoMorosos = new SqlCommand(sqlMorosos, conexion);

                    SqlDataReader readerMorosos = comandoMorosos.ExecuteReader();

                    while (readerMorosos.Read())
                    {
                        string numero_carnet = readerMorosos.GetString(readerMorosos.GetOrdinal("numero_carnet"));
                        string nombre = readerMorosos.GetString(readerMorosos.GetOrdinal("nombre"));
                        string contrasena = readerMorosos.GetString(readerMorosos.GetOrdinal("contrasena"));
                        string telefono = readerMorosos.GetString(readerMorosos.GetOrdinal("telefono"));
                        string email = readerMorosos.GetString(readerMorosos.GetOrdinal("email"));

                        Lector lector = new Lector(numero_carnet, nombre, contrasena, telefono, email);
                        listaMorosos.Add(lector);
                    }
                    
                }
                catch (Exception ex)
                {
                    error += ex.ToString();
                }
                return listaMorosos;

            }
        }

        public Gestor(out String error)

        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {

                try
                {
                    conexion.Open();
                    string sqlLectores = "SELECT numero_carnet, nombre, contrasena, telefono, email FROM Lector";
                    string sqlAutores = "SELECT id, nombre FROM Autor";
                    string sqlLibros = "SELECT isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades_disponibles, es_prestable FROM Libro";
                    string sqlCategorias = "SELECT id, descripcion FROM Categoria ";

                    SqlCommand comandoLectores = new SqlCommand(sqlLectores, conexion);
                    SqlCommand comandoAutores = new SqlCommand(sqlAutores, conexion);
                    SqlCommand comandoLibros = new SqlCommand(sqlLibros, conexion);
                    SqlCommand comandoCategorias = new SqlCommand(sqlCategorias, conexion);
                    SqlCommand comandoBiblioteca = new SqlCommand(sqlCategorias, conexion);


                    SqlDataReader readerLectores = comandoLectores.ExecuteReader();
                    SqlDataReader readerAutores = comandoAutores.ExecuteReader();
                    SqlDataReader readerLibros = comandoLibros.ExecuteReader();
                    SqlDataReader readerCategorias = comandoCategorias.ExecuteReader();
                    SqlDataReader readerBiblioteca = comandoBiblioteca.ExecuteReader();

                    while (readerBiblioteca.Read())
                    {
                        string nombre = readerBiblioteca.GetString(readerBiblioteca.GetOrdinal("nombre"));
                        string lugar = readerBiblioteca.GetString(readerBiblioteca.GetOrdinal("lugar"));
                        string imagen = readerBiblioteca.GetString(readerBiblioteca.GetOrdinal("imagen"));
                        Biblioteca biblioteca = new Biblioteca(nombre, lugar , imagen);
                        this.biblioteca = biblioteca;
                    }

                    while (readerLectores.Read())
                    {
                        string numero_carnet = readerLectores.GetString(readerLectores.GetOrdinal("numero_carnet"));
                        string nombre = readerLectores.GetString(readerLectores.GetOrdinal("nombre"));
                        string contrasena = readerLectores.GetString(readerLectores.GetOrdinal("contrasena"));
                        string telefono = readerLectores.GetString(readerLectores.GetOrdinal("telefono"));
                        string email = readerLectores.GetString(readerLectores.GetOrdinal("email"));

                        Lector lector = new Lector(numero_carnet, nombre, contrasena, telefono, email);
                        lectores.Add(lector);
                    }

                    while (readerAutores.Read())
                    {
                        Autor autor = new Autor(readerAutores.GetInt32(readerLectores.GetOrdinal("id")), readerAutores.GetString(readerAutores.GetOrdinal("nombre")));

                        autores.Add(autor);
                    }

                    while (readerLibros.Read())
                    {

                        string isbn = readerLibros.GetString(readerLibros.GetOrdinal("isbn"));
                        string titulo = readerLibros.GetString(readerLibros.GetOrdinal("titulo"));
                        string editorial = readerLibros.GetString(readerLibros.GetOrdinal("editorial"));
                        string sinopsis = readerLibros.GetString(readerLibros.GetOrdinal("sinopsis"));
                        string caratula = readerLibros.GetString(readerLibros.GetOrdinal("caratula"));
                        int cantidad_unidades_disponibles = readerLibros.GetInt32(readerLibros.GetOrdinal("cantidad_unidades_disponibles"));
                        bool es_prestable = readerLibros.GetBoolean(readerLibros.GetOrdinal("es_prestable"));


                        Libro libro = new Libro(isbn,titulo,editorial, sinopsis,caratula,cantidad_unidades_disponibles,es_prestable,this.biblioteca.Nombre);
                        libros.Add(libro);
                    }
                    while (readerCategorias.Read())
                    {
                        Categoria categoria = new Categoria(readerAutores.GetInt32(readerCategorias.GetOrdinal("id")), readerCategorias.GetString(1));
                        categorias.Add(categoria);
                    }

                }
                catch (Exception ex)
                {
                    error += ex.ToString();
                }


            }
            
        }
    }
<<<<<<< HEAD
 }
=======
}

>>>>>>> 000997e041ea26b01a17fbfc9fd611d55ab63645

