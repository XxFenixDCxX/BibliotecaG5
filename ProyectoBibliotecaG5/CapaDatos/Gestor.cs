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
                    using (SqlCommand commandPrestado = new SqlCommand("SELECT * FROM Prestamo WHERE  lector_numero_carnet = @numero_carnet", conexion))
                    {
                        commandPrestado.Parameters.AddWithValue("@numero_carnet", carnet);
                        if (commandPrestado.ExecuteScalar() != null)
                        {
                            error = "El Lector tiene libros prestados no se puede eliminar";
                            return;
                        }
                    }
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



        public bool AgregarLibro(Libro nuevoLibro, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();
                    string sqlAgregarLibro;
                    if (string.IsNullOrEmpty(nuevoLibro.Caratula))
                    {
                        sqlAgregarLibro = "INSERT INTO Libro (isbn, titulo, editorial, sinopsis, cantidad_unidades_disponibles, es_prestable) VALUES (@isbn, @titulo, @editorial, @sinopsis, @cantidad_unidades_disponibles, @es_prestable);";
                    }
                    else
                    {
                         sqlAgregarLibro = "INSERT INTO Libro (isbn, titulo, editorial, sinopsis,caratula ,cantidad_unidades_disponibles, es_prestable) VALUES (@isbn, @titulo, @editorial, @sinopsis,@caratula ,@cantidad_unidades_disponibles, @es_prestable);";
                    }
         

                    SqlCommand comandoAgregarLibro = new SqlCommand(sqlAgregarLibro, conexion);

                    comandoAgregarLibro.Parameters.AddWithValue("@isbn", nuevoLibro.Isbn);
                    comandoAgregarLibro.Parameters.AddWithValue("@titulo", nuevoLibro.Titulo);
                    comandoAgregarLibro.Parameters.AddWithValue("@editorial", nuevoLibro.Editorial);
                    comandoAgregarLibro.Parameters.AddWithValue("@sinopsis", nuevoLibro.Sinopsis);
                    if (!string.IsNullOrEmpty(nuevoLibro.Caratula))
                    {
                        comandoAgregarLibro.Parameters.AddWithValue("@caratula", nuevoLibro.Caratula);
                    }

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
        public Autor ObtenerAutorPorNombre(string nombreAutor, out string error)
        {
            error = "";
            Autor autor = null;

            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    string sqlObtenerAutor = "SELECT * FROM Autor WHERE nombre = @nombre;";

                    SqlCommand comandoObtenerAutor = new SqlCommand(sqlObtenerAutor, conexion);
                    comandoObtenerAutor.Parameters.AddWithValue("@nombre", nombreAutor);

                    SqlDataReader reader = comandoObtenerAutor.ExecuteReader();

                    if (reader.Read())
                    {
                        autor = new Autor(reader.GetInt32(0), reader.GetString(1));
                    }
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                }
            }

            return autor;
        }


        public Categoria ObtenerCategoriaPorNombre(string nombreCategoria, out string error)
        {
            error = "";
            Categoria categoria = null;

            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    string sqlObtenerCategoria = "SELECT * FROM Autor WHERE nombre = @nombre;";

                    SqlCommand comandoObtenerCategoria = new SqlCommand(sqlObtenerCategoria, conexion);
                    comandoObtenerCategoria.Parameters.AddWithValue("@nombre", nombreCategoria);

                    SqlDataReader reader = comandoObtenerCategoria.ExecuteReader();

                    if (reader.Read())
                    {
                        categoria = new Categoria(reader.GetInt32(0), reader.GetString(1));
                    }
                }
                catch (Exception ex)
                {
                    error += ex.Message;
                }
            }

            return categoria;
        }




        public List<Libro> devolverListaDeLibros(out String error)
        {

            error = "";
            List<Libro> listaLibros = new List<Libro>();
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {

                try
                {
                    conexion.Open();

                    // Si existe el prestamo lo devuelvo
                    string sqlLibros = "SELECT * FROM Libros";

                    SqlCommand comandoLibros = new SqlCommand(sqlLibros, conexion);

                    SqlDataReader reader = comandoLibros.ExecuteReader();

                    while (reader.Read())
                    {
                        Libro libro = new Libro((string)reader["isbn"], (string)reader["titulo"], (string)reader["editorial"], (string)reader["sinopsis"], (string)reader["caratula"], (int)reader["cantidad_unidades_disponibles"], (bool)reader["es_prestable"], (string)reader["biblioteca_nombre"], null, null);
                        
                        listaLibros.Add(libro);
                    }
                    } catch (Exception ex)
                {
                    error = ex.Message;
                }
                return listaLibros;
            }
        }

        //prestar libro comporbando que no este prestado y que quien quiera prestarlo no tenga ningun libro prestado
        public void PrestarLibro(string isbn, string numeroCarnet, out string error)
        {
            error = "";
            using (SqlConnection conexion = new SqlConnection(cadConexion))
            {
                try
                {
                    conexion.Open();

                    // Si existe el prestamo lo devuelvo
                    string sqlPrestamo = "SELECT * FROM Prestamo WHERE libro_isbn = @isbn AND lector_numero_carnet = @numeroCarnet";
                    SqlCommand comandoPrestamo = new SqlCommand(sqlPrestamo, conexion);
                    comandoPrestamo.Parameters.AddWithValue("@isbn", isbn);
                    comandoPrestamo.Parameters.AddWithValue("@numeroCarnet", numeroCarnet);

                    SqlDataReader reader = comandoPrestamo.ExecuteReader();

                    if (reader.Read())
                    {
                        error = "El libro ya esta prestado";
                    }

                    reader.Close();

                    // Si el lector tiene 3 libros prestados no puede prestar mas
                    string sqlPrestamosLector = "SELECT * FROM Prestamo WHERE lector_numero_carnet = @numeroCarnet";
                    SqlCommand comandoPrestamosLector = new SqlCommand(sqlPrestamosLector, conexion);
                    comandoPrestamosLector.Parameters.AddWithValue("@numeroCarnet", numeroCarnet);

                    SqlDataReader readerPrestamosLector = comandoPrestamosLector.ExecuteReader();

                    if (readerPrestamosLector.HasRows)
                    {
                        int contador = 0;
                        while (readerPrestamosLector.Read())
                        {
                            contador++;
                        }

                        if (contador >= 3)
                        {
                            error = "El lector ya tiene 3 libros prestados";
                        }
                    }

                    readerPrestamosLector.Close();

                    // Si el libro no esta prestado y el lector no tiene 3 libros prestados, presto el libro
                    string sqlPrestarLibro = "INSERT INTO Prestamo (libro_isbn, lector_numero_carnet, fecha_prestamo, fecha_devolucion) VALUES (@isbn, @numeroCarnet, @fechaPrestamo, @fechaDevolucion)";
                    SqlCommand comandoPrestarLibro = new SqlCommand(sqlPrestarLibro, conexion);
                    comandoPrestarLibro.Parameters.AddWithValue("@isbn", isbn);
                    comandoPrestarLibro.Parameters.AddWithValue("@numeroCarnet", numeroCarnet);
                    comandoPrestarLibro.Parameters.AddWithValue("@fechaPrestamo", DateTime.Now);
                    comandoPrestarLibro.Parameters.AddWithValue("@fechaDevolucion", DateTime.Now.AddDays(15));


                    
                }catch (Exception ex)
                {
                    error = ex.Message;
                }
            }
        }
    }
}

