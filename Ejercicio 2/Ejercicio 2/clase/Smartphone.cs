using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  8. Crear una clase Smartphone con los siguientes métodos:
        a. para encender y apagar el mismo,
        b. subir y bajar el volumen,
        c. poner en silencio,
        d. bajar o subir el brillo de la pantalla.
        e. Además de properties para marca y modelo.
*/

namespace Ejercicio_2.clase
{
    public class Smartphone
    {

        private bool IsActivatePhone { get; set; }
        private bool isMuted { get; set; }
        private int _volumen { get; set; }
        public int Volumen
        {
            get { return _volumen; }
            set 
            { 
                if(value >= 0 && value <= 100)
                {
                    _volumen = value;
                }
            }
        }

        private int _brillo { get; set; }

        public int Brillo
        {
            get { return _brillo; }
            set 
            { 
                if(value >= 0 && value <= 10)
                {
                    _brillo = value;
                }
            }
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }


        public Smartphone() { }
        public Smartphone(string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public void EncenderSmartphone()
        {
            if (!this.IsActivatePhone)
            {
                this.IsActivatePhone = true;
                Console.WriteLine("Encediendo Smartphone");
            }
            else
            {
                Console.WriteLine("Smarphone se encuentra encendido");
            }
        }

        public void ApagarSmartphone()
        {
            if (this.IsActivatePhone)
            {
                Console.WriteLine("Smarphone se encuentra apagado");

            }
            else
            {
                this.IsActivatePhone = false;
                Console.WriteLine("Encediendo Smartphone");
            }
        }


        public void SubirVolumen()
        {
            if (this._volumen < 100)
            {
                this._volumen += 10;

                Console.WriteLine($"Nivel de Volumen: {this._volumen}");
            }
            else
            {
                Console.WriteLine($"Nivel de Volumen: {this._volumen}");
            }

        }

        public void BajarVolumen()
        {
            if (this._volumen >= 10)
            {
                this._volumen -= 10;

                Console.WriteLine($"Nivel de Volumen: {this._volumen}");
            }
            else
            {
                Console.WriteLine($"Nivel de Volumen: {this._volumen}");
            }

        }


        public void ActivarModoSilencio()
        {
            if (!this.isMuted)
            {
                this.isMuted = true;
                Console.WriteLine("El modo silencio está activado");
            }
            else
            {
                Console.WriteLine("El modo silencio se encuentra activado");
            }
            
        }

        public void DesactivarModoSilencio()
        {
            if (this.isMuted)
            {
                this.isMuted = false;
                Console.WriteLine("El modo sonido está activado");
            }
            else
            {
                Console.WriteLine("El modo silencio se encuentra activado");
            }

        }

        public void SubirBrillo()
        {
            if (this._brillo < 10)
            {
                this._brillo += 1;

                Console.WriteLine($"Nivel de Brillo: {this._brillo}");
            }
            else
            {
                Console.WriteLine($"Nivel de Brillo: {this._brillo}");
            }

        }

        public void BajarBrillo()
        {
            if (this._brillo >= 1)
            {
                this._brillo -= 1;

                Console.WriteLine($"Nivel de Brillo: {this._brillo}");
            }
            else
            {
                Console.WriteLine($"Nivel de Brillo: {this._brillo}");
            }

        }
    }
}
