using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
   3. Crear una clase Persona que tenga un método para devolver el nombre
      completo. (Nombre más Apellido).
   4. Agregar a la Persona, una property Fecha de Nacimiento y un método para
      calcular la edad.

   10.Agregar a la clase Persona la posibilidad de tener un Smartphone.

*/
namespace Ejercicio_2.clase
{
    public class Persona
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set;}

        public Smartphone Sphone { get; set;}
        
        



        public Persona() { }

        public Persona(string name, string surName)
        {
            this.Name = name;
            this.SurName = surName;

        }

        public Persona(string name, string surName, DateTime dateOfBirth)
        {
            this.Name =  name;
            this.SurName = surName;
            this.DateOfBirth = dateOfBirth;
            
        }


        public string GetFullName() { return this.Name + " " + this.SurName; }

        public int CalcularEdad() { return DateTime.Now.Year - this.DateOfBirth.Year; }






    }
}
