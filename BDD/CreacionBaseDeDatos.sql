USE master
DROP DATABASE IF EXISTS GestorBibliotecaG5;
CREATE DATABASE GestorBibliotecaG5;
GO
USE GestorBibliotecaG5;

CREATE TABLE Biblioteca (
    nombre NVARCHAR(100) PRIMARY KEY,
    lugar NVARCHAR(100) NOT NULL,
    imagen NVARCHAR(100) NOT NULL
);

CREATE TABLE Categoria (
    id INT PRIMARY KEY,
    descripcion NVARCHAR(100)
);

CREATE TABLE Autor (
    id INT PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE Libro (
    isbn NCHAR(13) PRIMARY KEY,
    titulo NVARCHAR(100) NOT NULL,
    editorial NVARCHAR(100) NOT NULL,
    sinopsis NVARCHAR(100),
    caratula NVARCHAR(100) NOT NULL,
    cantidad_unidades_disponibles INT NOT NULL,
    es_prestable BIT NOT NULL
);

CREATE TABLE Libro_Autor (
    libro_isbn NCHAR(13) NOT NULL,
    autor_id INT NOT NULL,
    PRIMARY KEY (libro_isbn, autor_id),
    FOREIGN KEY (libro_isbn) REFERENCES Libro(isbn),
    FOREIGN KEY (autor_id) REFERENCES Autor(id)
);

CREATE TABLE Libro_Categoria (
    libro_isbn NCHAR(13) NOT NULL,
    categoria_id INT NOT NULL,
    PRIMARY KEY (libro_isbn, categoria_id),
    FOREIGN KEY (libro_isbn) REFERENCES Libro(isbn),
    FOREIGN KEY (categoria_id) REFERENCES Categoria(id)
);

CREATE TABLE Lector (
    numero_carnet NVARCHAR(100) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    contrasena NVARCHAR(100) NOT NULL,
    telefono NVARCHAR(15),
    email NVARCHAR(100) NOT NULL
);

CREATE TABLE Prestamo (
    id INT PRIMARY KEY,
    fecha_prestamo DATE NOT NULL,
    fecha_devolucion DATE,
    lector_numero_carnet NVARCHAR(100) NOT NULL,
    libro_isbn NCHAR(13) NOT NULL,
    FOREIGN KEY (lector_numero_carnet) REFERENCES Lector(numero_carnet),
    FOREIGN KEY (libro_isbn) REFERENCES Libro(isbn)
);
