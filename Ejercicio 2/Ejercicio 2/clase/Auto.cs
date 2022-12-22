using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

/*
  5. Crear una clase Auto con un método para encender y apagar el motor. Todo
     auto debe tener un modelo, marca y color.
   
  9. Añadir a la clase Auto un método para acelerar y para frenar. Cada vez que el
     auto acelera incrementa su velocidad en un 10%. Y cada vez que frena
     reduce su velocidad en un 20%. Se debe encender el motor del auto para
     poder acelerar. Agregar métodos para conocer la Velocidad y la Aceleración
     en cualquier momento.

 11.Agregar a la clase Auto, la posibilidad de tener una Persona como conductor.
    Siendo que ahora el auto no puede encender su motor si no hay un conductor
    presente. Además el Conductor debe tener 18 años como mínimo.


 12.Agregar a la clase Auto la posibilidad de llevar Pasajeros. (de 0 a la
    capacidad que tenga el auto). Considere agregar una property Capacidad


 13.Añadir a la clase Auto, la posibilidad de poder llevar una Mascota, pero sólo
    si hay un conductor presente. La mascota puede o no contar como pasajero
    dependiendo del Tamaño de la mascota. por lo que el número de lugares
    disponibles puede verse reducido. Además, si no hay lugares disponibles en
    el vehículo, la mascota no podrá subir al auto. Si la Mascota es pequeña, irá
    en el regazo de algún pasajero, pero no del conductor. Agregar un método
    que permita saber en el regazo de quién va la Mascota. Además otro método
    para que la Mascota se mueva al regazo de otro pasajero.

 14.Agregar un método a Auto para bajar a todos los pasajeros, donde se debe
    verificar que antes de bajar cualquier pasajero el auto debe estar detenido
    (Velocidad = 0) También que antes que baje el Conductor, debe apagarse el
    vehículo.

*/

namespace Ejercicio_2.clase
{
    public class Auto
    {
        public string Modelo { get; set; }
        public string Marca { get; set;}
        public string Color { get; set;}
        public bool IsActiveMotor { get; set;}
        public Persona Conductor { get; set;}

        public double Velocidad { get; set; }
        public double Aceleracion { get; set; }
        private int _capacidad;

        public int Capacidad
        {
            get { return _capacidad; }
            set 
            {
                if(value > 1 )
                {
                    _capacidad = value;
                }
            }
        }

        public Persona[] Pasajeros;
        private int NumPasajeros;
        private string Regazo;


        public Auto() { }
        public Auto(string modelo, string marca, string color)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
        }
        public Auto(string modelo, string marca, string color, int capacidad)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Capacidad = capacidad;
            this.Pasajeros = new Persona[capacidad];
        }

        public void EncederMotor() 
        {
            if (this.Conductor != null)
            {
                if (this.Conductor.CalcularEdad() >= 18)
                {
                    Console.WriteLine("Encendiendo Motor");
                    this.IsActiveMotor = true;
                }
                else
                {
                    Console.WriteLine("El conductor es menor de edad");
                }
            }
            else
            {
                Console.WriteLine("El auto necesita tener un conductor");
            }



        }

        public void ApagarMotor() 
        { 
            Console.WriteLine("Apagando Motor");
            this.IsActiveMotor = false;

        }

        public void Acelerar()
        {
            double auxVel = 0.0;
            if (this.IsActiveMotor)
            {
                auxVel = this.Velocidad;
                this.Velocidad *= 1.10;
                this.Aceleracion = this.Velocidad - auxVel;
            }
            else
            {
                Console.WriteLine("Se debe encender el motor para poder acelerar!!!");
            }
        }


        public void Frenar()
        {
            this.Velocidad *= 0.80;
           
        }

        public double GetVelocidad() { return this.Velocidad; }

        public double GetAceleracion() { return this.Aceleracion; }

        public void AgregarPasajeros(Persona pasajero)
        {
            if (NumPasajeros  < this.Capacidad)
            {
                this.Pasajeros[NumPasajeros++] = pasajero;
            }
            else
            {
                Console.WriteLine($"Supera el límite de capacidad del auto ");
            }
        }

        public void LlevarMascota(Mascota pet)
        {
            if (this.Conductor != null)
            {
                if (pet.Tamaño.Equals("pequeño", StringComparison.OrdinalIgnoreCase))
                {
                    pet.SetRegazo(this.Pasajeros[1]);
                }
                else
                {
                    if (this.NumPasajeros == this.Capacidad)
                    {
                        Console.WriteLine("No ahí espacio");
                    }

                }
            }
            else
            {
                Console.WriteLine("No ahí conductor");
            }
        }


        public void BajarPasajeros()
        {
            if (this.Velocidad == 0 )
            {
                for (int i = 0; i < this.Pasajeros.Length; i++)
                {
                    this.Pasajeros[i] = null;
                }

                this.NumPasajeros = 0;
            }
            else
            {
                Console.WriteLine("La velocidad debe estar en 0 para poder bajar los pasajeros");
            }
        }

        public void BajarConductor()
        {
            if(this.Velocidad == 0 && !this.IsActiveMotor)
            {
                this.Conductor = null;
            }
            else
            {
                Console.WriteLine("La velocidad debe ser 0 y debe esta apagado el motor");
            }
        }
    }
}
