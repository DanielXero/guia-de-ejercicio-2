using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Ejercicio_2.clase
{
    public class Estudiante : Persona
    {
        public List<Libro> Libros;
        public Estudiante(string name, string surName) : base(name, surName)
        {
            this.Libros = new List<Libro>();
        }

        public void ShowBooksRead()
        {
            string msg = null;
            foreach (var item in Libros)
            {
                if (item.WasRead)
                {
                    msg += item.Nombre + "\n";
                }

            }

            if (msg != null)
            {
                Console.WriteLine("Lista de libros leídos: ");
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine("No tiene ningún libro leído");
            }
        }

        public int CantidadPaginasLeidas()
        {
            int totalPaginas = 0;
            foreach (var item in Libros)
            {
                if (item.WasRead)
                {
                    totalPaginas += item.CantidadPaginas;
                }

            }

            return totalPaginas;

        }

        public int CantidadLibrosNoLeidos()
        {
            int totalLibros = 0;
            foreach (var item in Libros)
            {
                if (!item.WasRead)
                {
                    totalLibros++;
                }

            }

            return totalLibros;
        }

        public void AgregarLibro(Libro book)
        {

            this.Libros.Add(book);
            
        }

        public void QuitarLibro(Libro book)
        {
            this.Libros.Remove(book);
            
        }
    }
}
