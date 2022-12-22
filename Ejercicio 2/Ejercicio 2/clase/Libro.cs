/*
 15.Crear una clase Libro, que contenga Nombre, Autor, Cantidad de Páginas, y
    una property llamada WasRead, que diga si el libro fue leído o no (boolean).
    Crear una clase Estudiante, que hereda de Persona (la clase de los puntos
    anteriores). El estudiante debe contener una lista de Libros, los cuales puede
    ser que los haya leído o no. (Se pueden crear dos listas diferentes si se
    complica mucho. Una lista con todos los libros, leídos o no, y otra lista sólo
    con los libros leídos) Debe haber un método que muestre la lista de libros
    leídos, y además otro método que permita calcular la suma de la cantidad de
    páginas leídas totales, de todos los libros leídos. Y un método que permita
    saber cuántos libros quedan sin leer. Otro método que permite agregar o
    quitar libros de la lista de libros (dos métodos diferentes).
*/
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio_2.clase
{
    public class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public int CantidadPaginas { get; set; }
        public bool WasRead { get; set; }

        public Libro() { }
        public Libro(string nombre, string autor, int cantidadPaginas, bool wasRead)
        {
            this.Nombre = nombre;
            this.Autor = autor;
            this.CantidadPaginas = cantidadPaginas;
            this.WasRead = wasRead;
        }
    }
}
