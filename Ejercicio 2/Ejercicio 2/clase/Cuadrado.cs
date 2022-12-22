using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Crear una clase Cuadrado con método para calcular el área del mismo.*/

namespace Ejercicio_2.clase
{
    public class Cuadrado
    {

        private int _lado;

        public int Lado
        {
            get { return _lado; }
            set 
            {
                if (value >= 0)
                {
                    _lado = value;
                        
                }
            }
        }
            


        public Cuadrado() { }

        public Cuadrado(int lado)
        {
            this.Lado = lado;
        }

        public double CalcularArea()
        {
            return Math.Pow(this.Lado, 2);
        }
    }
}
