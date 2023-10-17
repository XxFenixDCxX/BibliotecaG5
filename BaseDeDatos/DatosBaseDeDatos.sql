INSERT INTO Biblioteca (nombre, lugar, imagen) VALUES ('Biblioteca Central', 'Barcelona', 'biblioteca_central.jpg');

INSERT INTO Categoria (id, descripcion) VALUES (1, 'Narrativa'), (2, 'Ciencia Ficción'), (3, 'Historia');

INSERT INTO Autor (id, nombre) VALUES (1, 'Gabriel García Márquez'), (2, 'Isaac Asimov'), (3, 'Yuval Noah Harari');

INSERT INTO Libro (isbn, titulo, editorial, sinopsis, caratula, cantidad_unidades_disponibles, es_prestable, biblioteca_nombre) VALUES 
('12345678901234567', 'Cien años de soledad', 'Cátedra', 'Una obra maestra de la literatura...', 'cien_anos_de_soledad.jpg', 5, 1, 'Biblioteca Central'),
('12345678901234568', 'Fundación', 'Edhasa', 'El inicio de una saga impresionante...', 'fundacion.jpg', 3, 1, 'Biblioteca Central'),
('12345678901234569', 'Sapiens: De animales a dioses', 'Debate', 'Un recorrido por nuestra historia...', 'sapiens.jpg', 4, 0, 'Biblioteca Central');

INSERT INTO Libro_Autor (libro_isbn, autor_id) VALUES 
('12345678901234567', 1),
('12345678901234568', 2),
('12345678901234569', 3);

INSERT INTO Libro_Categoria (libro_isbn, categoria_id) VALUES 
('12345678901234567', 1),
('12345678901234568', 2),
('12345678901234569', 3);

INSERT INTO Lector (numero_carnet, nombre, contrasena, telefono, email) VALUES 
(1, 'Juan Pérez', 'contraseña_segura_123', '+34 123456789', 'juan.perez@example.com'),
(2, 'Ana Gómez', 'ana_gomez_456', '+34 987654321', 'ana.gomez@example.com');

INSERT INTO Prestamo (id, fecha_prestamo, fecha_devolucion, lector_numero_carnet, libro_isbn) VALUES 
(1, '2023-10-01', NULL, 1, '12345678901234567'),
(2, '2023-10-05', NULL, 2, '12345678901234568');