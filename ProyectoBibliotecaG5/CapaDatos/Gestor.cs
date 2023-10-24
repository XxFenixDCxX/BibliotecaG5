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
 }

