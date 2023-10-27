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
                            error = "El lector ya existe";
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
                            error = "No se ha podido insertar al lector";
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
                            error = "El lector no existe";
                            return;
                        }
                    }
                    using (SqlCommand command = new SqlCommand("DELETE FROM Lector WHERE numero_carnet = @numero_carnet", conexion))
                    {
                        command.Parameters.AddWithValue("@numero_carnet", carnet);
                        if (command.ExecuteNonQuery() == 0)
                        {
                            error = "No se ha podido eliminar al lector";
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

    }
}

