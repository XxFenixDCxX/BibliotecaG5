-- Errores de ejecución. Ver por ejemplo
-- (3 filas afectadas)
--Mens. 2628, Nivel 16, Estado 1, Línea 17
--Los datos binarios o de la cadena se truncan en la columna "isbn" de la tabla "GestorBibliotecaG5.dbo.Libro". Valor truncado: "1234567890123".

USE GestorBibliotecaG5;
DELETE FROM Libro_Autor;
DELETE FROM Libro_Categoria;
DELETE FROM Prestamo;
DELETE FROM Biblioteca;
DELETE FROM Categoria;
DELETE FROM Autor;
DELETE FROM Libro;
DELETE FROM Lector;
DBCC CHECKIDENT (Categoria, RESEED, 0)
DBCC CHECKIDENT (Autor, RESEED, 0)

INSERT INTO Biblioteca (nombre, lugar, imagen) VALUES ('Biblioteca Central', 'Barcelona', 'https://images.vexels.com/media/users/3/229885/isolated/preview/886153261393ecf90180d83178307a64-trazo-de-puntos-cardinales-de-la-brujula-de-navegacion.png');

INSERT INTO Categoria (descripcion) VALUES ('Narrativa'), ('Ciencia Ficción'), ('Historia');

INSERT INTO Autor (nombre) VALUES ('Gabriel García Márquez'), ('Isaac Asimov'), ('Yuval Noah Harari');

INSERT INTO Libro (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades_disponibles, es_prestable) VALUES 
('123434567', 'Cien años de soledad', 'Cátedra', 'Una obra maestra de la literatura...', 'cien_anos_de_soledad.jpg', 5, 1),
('126734568', 'Fundación', 'Edhasa', 'El inicio de una saga impresionante...', 'fundacion.jpg', 3, 1),
('123434569', 'Sapiens: De animales a dioses', 'Debate', 'Un recorrido por nuestra historia...', 'sapiens.jpg', 4, 0);

INSERT INTO Libro_Autor (libro_isbn, autor_id) VALUES 
('123434567', 1),
('126734568', 2),
('123434569', 3),
('123434569', 2);

INSERT INTO Libro_Categoria (libro_isbn, categoria_id) VALUES 
('123434567', 1),
('126734568', 2),
('123434569', 3),
('123434569', 2);

INSERT INTO Lector (numero_carnet, nombre, contrasena, telefono, email) VALUES 
(1, 'Juan Pérez', 'contraseña_segura_123', '+34 123456789', 'juan.perez@example.com'),
(2, 'Ana Gómez', 'ana_gomez_456', '+34 987654321', 'ana.gomez@example.com');

INSERT INTO Prestamo (id, fecha_prestamo, fecha_devolucion, lector_numero_carnet, libro_isbn) VALUES 
(1, '2023-10-01', NULL, 1, '123434567'),
(2, '2023-10-05','2023-10-06' , 2, '126734568');
