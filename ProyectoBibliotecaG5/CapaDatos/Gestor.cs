using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestor
    {
        public Biblioteca biblioteca;
        private const string cadConexion = "Data Source = .; Initial Catalog = GestorBibliotecaG5; Integrated Security = SSPI; MultipleActiveResultSets=true";
        public Gestor()
        {
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                conexion.Open();
                using (SqlCommand commandExist = new SqlCommand("SELECT * FROM Biblioteca", conexion))
                {
                    if (commandExist.ExecuteScalar() == null)
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO Biblioteca (nombre, lugar, imagen) VALUES (@nombre, @lugar, @imagen)", conexion))
                        {
                            biblioteca = new Biblioteca("Cuatrovientos", "Pamplona", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Brujula_en_Espa%C3%B1ol.svg/2028px-Brujula_en_Espa%C3%B1ol.svg.png");
                            command.Parameters.AddWithValue("@nombre", biblioteca.Nombre);
                            command.Parameters.AddWithValue("@lugar", biblioteca.Lugar);
                            command.Parameters.AddWithValue("@imagen", biblioteca.Imagen);
                            command.ExecuteNonQuery();
                            return;
                        }
                    }
                    using (SqlDataReader reader = commandExist.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            biblioteca = new Biblioteca((String)reader["nombre"], (String)reader["lugar"], (String)reader["imagen"]);
                        }
                    }
                }
            }
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
        public List<Lector> devolverListaDeMorososPorComienzo(string comienzo, out String error)
        {
            error = "";
            List<Lector> listaMorosos = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    string sqlMorosos = "SELECT * FROM Lector INNER JOIN Prestamo ON Lector.numero_carnet = Prestamo.lector_numero_carnet WHERE Prestamo.fecha_devolucion < GETDATE() AND Lector.nombre LIKE @comienzo; ";

                    SqlCommand comandoMorosos = new SqlCommand(sqlMorosos, conexion);
                    comandoMorosos.Parameters.AddWithValue("@comienzo", comienzo + "%");

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
        public void agregarLector(Lector lector, out string error)
        {
            error = "";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadConexion))
                {
                    conexion.Open();
                    using (SqlCommand commandExist = new SqlCommand("SELECT * FROM Lector WHERE numero_carnet = @numero_carnet", conexion))
                    {
                        commandExist.Parameters.AddWithValue("@numero_carnet", lector.NumeroCarnet);
                        if (commandExist.ExecuteScalar() != null)
                        {
                            error = "El reader ya existe";
                            return;
                        }
                    }
                    using (SqlCommand command = new SqlCommand("INSERT INTO Lector (numero_carnet, nombre, contrasena, telefono, email) VALUES (@numero_carnet, @nombre, @contrasena, @telefono, @email)", conexion))
                    {
                        command.Parameters.AddWithValue("@numero_carnet", lector.NumeroCarnet);
                        command.Parameters.AddWithValue("@nombre", lector.Nombre);
                        command.Parameters.AddWithValue("@contrasena", lector.Contrasena);
                        command.Parameters.AddWithValue("@telefono", lector.Telefono);
                        command.Parameters.AddWithValue("@email", lector.Email);
                        if (command.ExecuteNonQuery() == 0)
                        {
                            error = "No se ha podido insertar al reader";
                        }
                    }
                }
            } catch (Exception ex)
            {
                error = ex.ToString();
            }            
        }
        public void eliminarLector(String carnet, out string error)
        {
            error = "";
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadConexion))
                {
                    conexion.Open();
                    using (SqlCommand commandExist = new SqlCommand("SELECT * FROM Lector WHERE numero_carnet = @numero_carnet", conexion))
                    {
                        commandExist.Parameters.AddWithValue("@numero_carnet", carnet);
                        if (commandExist.ExecuteScalar() == null)
                        {
                            error = "El reader no existe";
                            return;
                        }
                    }
                    using (SqlCommand command = new SqlCommand("DELETE FROM Lector WHERE numero_carnet = @numero_carnet", conexion))
                    {
                        command.Parameters.AddWithValue("@numero_carnet", carnet);
                        if (command.ExecuteNonQuery() == 0)
                        {
                            error = "No se ha podido eliminar al reader";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.ToString();
            }
        }
        public List<Lector> devolverListaLectores(out String error)
        {

            error = "";
            List<Lector> listaLectores = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {

                try
                {
                    conexion.Open();

                    string sqlLectores = "SELECT * FROM Lector;";

                    SqlCommand comandoLectores = new SqlCommand(sqlLectores, conexion);

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

            }
        }
        public List<Lector> devolverListaDeLectoresPorComienzo(string comienzo, out String error)
        {
            error = "";
            List<Lector> listaLectores = new List<Lector>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    string sqlLectores = "SELECT * FROM Lector WHERE Lector.nombre LIKE @comienzo; ";

                    SqlCommand comadnoLectores = new SqlCommand(sqlLectores, conexion);
                    comadnoLectores.Parameters.AddWithValue("@comienzo", comienzo + "%");

                    SqlDataReader readerLectores = comadnoLectores.ExecuteReader();

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
            }
        }

        public Autor BuscarAutor(int id)
        {
            Autor autor = null;

            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                conexion.Open();

                string selectQuery = "SELECT * FROM Autor WHERE id = @id";
                SqlCommand command = new SqlCommand(selectQuery, conexion);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    autor = new Autor((int)reader["id"], (string)reader["nombre"]);
                }
            }

            return autor;
        }


        //Devolver Autores y Categorias 
        public List<Autor> ObtenerAutores(out string error)
        {
            return ObtenerAutoresFiltrados("",out error);
        }

        //&Lista de autores o categorias segun palabra

        public List<Autor> ObtenerAutoresFiltrados(string palabra, out string error)
        {
            List<Autor> autores = new List<Autor>();
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando;
                    if (string.IsNullOrWhiteSpace(palabra))
                    {
                        comando = new SqlCommand("SELECT id, nombre FROM Autor", conexion);
                    }
                    else
                    {
                        comando = new SqlCommand("SELECT id, nombre FROM Autor WHERE nombre LIKE @palabra", conexion);
                        comando.Parameters.AddWithValue("@palabra", "%" + palabra + "%");
                    }

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Autor autor = new Autor(reader.GetInt32(0), reader.GetString(1));
                        autores.Add(autor);
                    }
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                }

            }

            return autores;
        }

        public List<Categoria> ObtenerCategorias(out string error)
        {
            return ObtenerCategoriasFiltradas("", out error);
        }

        public List<Categoria> ObtenerCategoriasFiltradas(string palabra, out string error)
        {
            List<Categoria> categorias = new List<Categoria>();
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando;
                    if (string.IsNullOrWhiteSpace(palabra))
                    {
                        comando = new SqlCommand("SELECT id, descripcion FROM Categoria", conexion);
                    }
                    else
                    {
                        comando = new SqlCommand("SELECT id, descripcion FROM Categoria WHERE descripcion LIKE @palabra", conexion);
                        comando.Parameters.AddWithValue("@palabra", "%" + palabra + "%");
                    }

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria(reader.GetInt32(0), reader.GetString(1));
                        categorias.Add(categoria);
                    }
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                }

            }

            return categorias;
        }



        //public Categoria BuscarCategoria(int id)
        //{
        //    Categoria categoria = null;

        //    using (SqlConnection conexion = new SqlConnection(cadConexion))
        //    {
        //        conexion.Open();

        //        string selectQuery = "SELECT * FROM Categoria WHERE id = @id";
        //        SqlCommand command = new SqlCommand(selectQuery, conexion);
        //        command.Parameters.AddWithValue("@id", id);
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            categoria = new Categoria((int)reader["id"], (string)reader["descripcion"]);
        //        }
        //    }

        //    return categoria;
        //}


        public bool AgregarLibro(Libro nuevoLibro, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();
                    string sqlAgregarLibro = "INSERT INTO Libro (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades_disponibles, es_prestable) VALUES (@isbn, @titulo, @editorial, @sinopsis, @caratula, @cantidad_unidades_disponibles, @es_prestable);";

                    SqlCommand comandoAgregarLibro = new SqlCommand(sqlAgregarLibro, conexion);

                    comandoAgregarLibro.Parameters.AddWithValue("@isbn", nuevoLibro.Isbn);
                    comandoAgregarLibro.Parameters.AddWithValue("@titulo", nuevoLibro.Titulo);
                    comandoAgregarLibro.Parameters.AddWithValue("@editorial", nuevoLibro.Editorial);
                    comandoAgregarLibro.Parameters.AddWithValue("@sinopsis", nuevoLibro.Sinopsis);
                    comandoAgregarLibro.Parameters.AddWithValue("@caratula", nuevoLibro.Caratula);
                    comandoAgregarLibro.Parameters.AddWithValue("@cantidad_unidades_disponibles", nuevoLibro.CantidadUnidadesDisponibles);
                    comandoAgregarLibro.Parameters.AddWithValue("@es_prestable", nuevoLibro.EsPrestable);

                    int filasAfectadas = comandoAgregarLibro.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        foreach (Autor autor in nuevoLibro.Autores)
                        {
                            SqlCommand comandoAgregarAutor = new SqlCommand("INSERT INTO Libro_Autor (libro_isbn, autor_id) VALUES (@isbn, @autor_id)", conexion);
                            comandoAgregarAutor.Parameters.AddWithValue("@isbn", nuevoLibro.Isbn);
                            comandoAgregarAutor.Parameters.AddWithValue("@autor_id", autor.Id); 

                            comandoAgregarAutor.ExecuteNonQuery();
                        }

                        foreach (Categoria categoria in nuevoLibro.Categorias)
                        {
                            SqlCommand comandoAgregarCategoria = new SqlCommand("INSERT INTO Libro_Categoria (libro_isbn, categoria_id) VALUES (@isbn, @categoria_id)", conexion);
                            comandoAgregarCategoria.Parameters.AddWithValue("@isbn", nuevoLibro.Isbn);
                            comandoAgregarCategoria.Parameters.AddWithValue("@categoria_id", categoria.Id); 

                            comandoAgregarCategoria.ExecuteNonQuery();
                        }

                    }

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                    return false;
                }
            }
        }


        public bool EliminarLibro(string isbn, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    // quitar todass las relaciones en las tablas Libro_Autor, Libro_Categoria y Prestamo
                    string sqlEliminarLibroAutor = "DELETE FROM Libro_Autor WHERE libro_isbn = @isbn;";
                    string sqlEliminarLibroCategoria = "DELETE FROM Libro_Categoria WHERE libro_isbn = @isbn;";
                    string sqlEliminarPrestamo = "DELETE FROM Prestamo WHERE libro_isbn = @isbn;";

                    SqlCommand comandoEliminarLibroAutor = new SqlCommand(sqlEliminarLibroAutor, conexion);
                    SqlCommand comandoEliminarLibroCategoria = new SqlCommand(sqlEliminarLibroCategoria, conexion);
                    SqlCommand comandoEliminarPrestamo = new SqlCommand(sqlEliminarPrestamo, conexion);

                    comandoEliminarLibroAutor.Parameters.AddWithValue("@isbn", isbn);
                    comandoEliminarLibroCategoria.Parameters.AddWithValue("@isbn", isbn);
                    comandoEliminarPrestamo.Parameters.AddWithValue("@isbn", isbn);

                    comandoEliminarLibroAutor.ExecuteNonQuery();
                    comandoEliminarLibroCategoria.ExecuteNonQuery();
                    comandoEliminarPrestamo.ExecuteNonQuery();


                    string sqlEliminarLibro = "DELETE FROM Libro WHERE isbn = @isbn;";

                    SqlCommand comandoEliminarLibro = new SqlCommand(sqlEliminarLibro, conexion);

                    comandoEliminarLibro.Parameters.AddWithValue("@isbn", isbn);

                    int filasAfectadas = comandoEliminarLibro.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                    return false;
                }
            }
        }


        //Anadir autor y categoria
        public bool AnadirAutor(string nombre, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("INSERT INTO Autor (nombre) VALUES (@nombre)", conexion);
                    comando.Parameters.AddWithValue("@nombre", nombre);

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }

            return true;
        }

        public bool AnadirCategoria(string descripcion, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("INSERT INTO Categoria (descripcion) VALUES (@descripcion)", conexion);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    error = ex.Message;
                    return false;
                }
            }

            return true;
        }

    }
}

