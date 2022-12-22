using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  6. Crear una clase Mascota con un método que sirva para alimentarlo. Por cada
     alimento ingerido, incrementa su energía en un 30%. La Mascota debe tener
     nombre, y tipo (gato o perro).
  7. Agregar a la Mascota un método para correr. Cada vez que la mascota corre,
     gasta un 10% de su energía. Solamente puede correr si su nivel de energía
     es superior al 20%.
*/

namespace Ejercicio_2.clase
{
    public class Mascota
    {

        private int energia;



        public string NombreMascota { get; set; }
        public string TipoMascota { get; set; }
        public string Tamaño { get; set; }
        public string Regazo { get; set; }

        public Mascota() { }
        public Mascota(string nombreMascota, string tipoMascota)
        {
            this.NombreMascota = nombreMascota;
            this.TipoMascota = tipoMascota;
        }
        public Mascota(string nombreMascota, string tipoMascota, string tamaño)
        {
            this.NombreMascota = nombreMascota;
            this.TipoMascota = tipoMascota;
            this.Tamaño = tamaño;
        }

        public int GetEnergia() { return this.energia; }

        public void AlimentarMascota()
        {
            if (this.energia <= 100)
            {
                this.energia += 30;
                if (this.energia > 100) { this.energia = 100; }

                Console.WriteLine($"La energia de la mascota se incremento en un 30%, su energia actual es del {this.GetEnergia()}%");
            }
            else
            {
                Console.WriteLine($"La energia de la mascota está llena {this.GetEnergia()}% ");
            }


        }


        public void Correr()
        {
            if (this.energia > 20)
            {
                this.energia -= 10;

                Console.WriteLine($"La mascota comenzo a correr y gasto un 10% de energia. Su energia total es del {this.energia}%");
            }
            else
            {
                Console.WriteLine($"La mascota está cansada, no puede correr su energia es de {this.energia}%");
            }
        }

        public void SetRegazo(Persona p)
        {
            this.Regazo = this.NombreMascota + " está en el regazo de " + p.GetFullName();
        }


        public string GetRegazo()
        {
            return this.Regazo;
        }

    }
}
