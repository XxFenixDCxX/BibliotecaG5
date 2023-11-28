# Proyecto de Gestión de Biblioteca - Arkaitz Calvo Saldias

Este proyecto tiene como objetivo simular la gestión de una biblioteca, permitiendo el mantenimiento de datos generales de la biblioteca, lector@s, categorías, autor@s y libros, así como la realización de préstamos, devoluciones y la obtención de un listado de moros@s. A continuación, se detallan las principales características y funcionalidades del proyecto.

## Características principales

- Gestión de datos generales de la biblioteca, incluyendo nombre, lugar y una imagen representativa.
- Registro de libros con información como ISBN, título, editorial, autor/es, sinopsis, carátula, categoría/s, cantidad de unidades existentes y disponibilidad.
- Categorías con identificador y descripción.
- Autor@s con identificador y nombre.
- Registro de lector@s con número de carnet, nombre, contraseña, teléfono, y email.
- Préstamos de libros a lector@s registrad@s, con control de disponibilidad y morosidad.
- Devoluciones de libros y registro de los préstamos realizados.
- Listado de moros@s, personas que tienen libros prestados con fecha de devolución vencida.

## Estructura del proyecto

El proyecto consta de tres capas: Datos, Entidades y Presentación.

- **Capa de Datos:** Encargada de interactuar con la base de datos y realizar todas las operaciones de alta, borrado y consulta. Incluye validaciones de datos y control de errores en la base de datos.

- **Capa de Entidades:** Define las clases de objetos necesarios para representar las entidades del sistema, como Libro, Autor, Categoría, Lector, Préstamo, etc.

- **Capa de Presentación:** Contiene los formularios de la aplicación, donde los usuarios interactúan con el sistema. Muestra datos de la biblioteca y permite realizar todas las operaciones mencionadas.

## Operaciones disponibles

### Mantenimiento de datos generales de la biblioteca

- Alta y borrado de autor@s.
- Alta y borrado de libros, incluyendo la asignación de categorías y autor@s.

### Préstamos y devoluciones

- Realizar préstamos de libros a lector@s, controlando disponibilidad y morosidad.
- Realizar devoluciones de libros, registrando los préstamos.
- Listar l@s moros@s, personas con libros prestados y fecha de devolución vencida.

## Instrucciones para ejecutar el proyecto

1. Descargue el repositorio.
2. Asegúrese de que tiene una base de datos configurada con las tablas necesarias (se proporcionan archivos SQL para crear la estructura de la base de datos y cargar datos de ejemplo).
3. Ejecute la aplicación desde la capa de presentación.

## Notas adicionales

- Las imágenes de carátulas de libros se almacenan en una carpeta local y se copian automáticamente al directorio de ejecución de la aplicación cuando se realiza un alta de libro.

## Contribuciones

Este proyecto ha sido desarrollado en colaboración por el equipo. Los cambios y contribuciones se registran a través de commits en el repositorio.

Para más detalles, consulte la documentación y el código fuente del proyecto.

**¡Gracias por su interés en nuestro proyecto de gestión de biblioteca!**
