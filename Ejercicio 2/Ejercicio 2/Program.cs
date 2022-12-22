


using Ejercicio_2.clase;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 2
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Lado = 5;
            Console.WriteLine($"El área del cuadrado es: {cuadrado1.CalcularArea()}");
            Console.WriteLine("\n\n");

            //Ejercicio 3 y 4
            Persona persona1 = new Persona("Juan", "Perez", new DateTime(1994, 5, 10));

            Console.WriteLine($"Nombre Completo: {persona1.GetFullName()}");
            Console.WriteLine($"Edad: {persona1.CalcularEdad()} años");
            Console.WriteLine("\n\n");

            // Ejercicio 5
            Auto autoNisssan = new Auto("Sentra", "Nissan", "Blanco");

            autoNisssan.EncederMotor();
            autoNisssan.ApagarMotor();
            Console.WriteLine("\n\n");

            //Ejercicio 6 y 7
            Mascota firulais = new Mascota("Firulais", "Perro");

            firulais.Correr();
            firulais.AlimentarMascota();
            firulais.Correr();
            Console.WriteLine("\n\n");

            //Ejercicio 8

            Smartphone smartPhone = new Smartphone("Asus", "Rog Phone 6");

            smartPhone.EncenderSmartphone();
            smartPhone.EncenderSmartphone();
            Console.WriteLine("\n\n");

            // Ejercicio 9, ...
            Auto autoChevrolet = new Auto("Onix", "Chevrolet", "Azul", 4);

            autoChevrolet.Acelerar();
            autoChevrolet.EncederMotor();
            autoChevrolet.Conductor = persona1;
            autoChevrolet.EncederMotor();
            autoChevrolet.Acelerar();
            Persona persona3 = new Persona("Carlos", "Perez", new DateTime(1994, 5, 10));
            Persona persona4 = new Persona("Yessica", "Gomez", new DateTime(1994, 5, 10));
            autoChevrolet.AgregarPasajeros(persona3);
            autoChevrolet.AgregarPasajeros(persona4);
            

            Console.WriteLine("\n\n");


            // Ejercicio 10
            Persona persona2 = new Persona("Jhon", "Smith", new DateTime(1992, 11, 2));
            Smartphone smartPhone2 = new Smartphone("Asus", "Rog Phone 7");
            persona2.Sphone = smartPhone2;

            Console.WriteLine(persona2.Sphone.Marca + " " + persona2.Sphone.Modelo + " smartphone de " + persona2.GetFullName());
            Console.WriteLine("\n\n");

            //

            Libro libro1 = new Libro("La Ilíada", "Homero", 187, true);

            Estudiante estudiante1 = new Estudiante("Juan", "Perez");

            estudiante1.AgregarLibro(libro1);
            //estudiante1.ShowBooksRead();
           





        }
    }
}