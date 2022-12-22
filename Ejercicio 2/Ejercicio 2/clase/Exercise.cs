using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.clase
{





    public class Exercise
    {

        public void ShowExercise1()
        {
            string numStr;
            int num;
            string message = "El valor es mayor que 100";

            do
            {
                Console.Write("Ingrese un valor entero: ");
                numStr = Console.ReadLine();

            } while (!Int32.TryParse(numStr, out num));


            if (num > 100)
            {
                Console.WriteLine(message);
            }

        }

        public void ShowExercise2()
        {
            string? numStr;
            int num;

            do
            {
                Console.Write("Ingrese un número entero: ");
                numStr = Console.ReadLine();
            } while (!Int32.TryParse(numStr, out num));


            Console.WriteLine(num + " -> " + ((num % 2) == 0 ? "Es Par" : "Es Impar"));

            Console.Write("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        public void ShowExercise3()
        {
            string numStr;
            int num;
            string message = "";

            do
            {
                Console.Write("Ingrese un valor entero: ");
                numStr = Console.ReadLine();
            } while (!Int32.TryParse(numStr, out num));


            message = (num / 2.0) % 2 == 1 ? "Es el doble de un impar" : "No es el doble de un impar";

            Console.WriteLine(num + " -> " + message);
        }

        public void ShowExercise4()
        {
            string numStr;
            int num;
            string numRomano = "";
            bool isInt = false, band = false;

            do
            {
                Console.Write("Ingrese un número entero entre 1 y 10: ");
                numStr = Console.ReadLine();

                isInt = Int32.TryParse(numStr, out num);
            } while (!(isInt && (num > 0 && num <= 10)));



            switch (num)
            {
                case 1:
                    numRomano = "I";
                    break;
                case 2:
                    numRomano = "II";
                    break;
                case 3:
                    numRomano = "III";
                    break;
                case 4:
                    numRomano = "IV";
                    break;
                case 5:
                    numRomano = "V";
                    break;
                case 6:
                    numRomano = "VI";
                    break;
                case 7:
                    numRomano = "VII";
                    break;
                case 8:
                    numRomano = "VIII";
                    break;
                case 9:
                    numRomano = "IX";
                    break;
                case 10:
                    numRomano = "X";
                    break;
                default:
                    break;
            }



            Console.WriteLine($"El número {num} en número romano es: {numRomano}");

        }


        public void ShowExercise5()
        {
            string? name1, ageStr1, ageStr2;
            int age1, age2, diferenciaEdad = 0;
            string? name2, message = "", message2 = "";

            Console.Write("Ingrese un nombre: ");
            name1 = Console.ReadLine();
            Console.Write($"Ingrese la edad de {name1}: ");
            ageStr1 = Console.ReadLine();
            Console.Write("Ingrese otro nombre: ");
            name2 = Console.ReadLine();
            Console.Write($"Ingrese la edad de {name2}: ");
            ageStr2 = Console.ReadLine();

            Int32.TryParse(ageStr1, out age1);
            Int32.TryParse(ageStr2, out age2);


            if (age1 < age2)
            {
                message = name1 + $" es menor ({age1})";
            }
            else if (age2 < age1)
            {
                message = name2 + $" es menor ({age2})";
            }
            else
            {
                message = name1 + " y " + name2 + $" tienen la misma edad ({age1})";
            }


            if (name1.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                diferenciaEdad = Math.Abs(age1 - age2);
                message2 = "Su diferencia de edad es: " + diferenciaEdad;
            }

            Console.WriteLine(message);
            Console.WriteLine(message2);
        }

        public void ShowExercise6()
        {
            int lado1, lado2, lado3, perimetro;
            double area = 0.0, semiperimetro = 0.0;
            perimetro = 0;
            string msg = "";

            Console.WriteLine("\t\t*****Calcular tipo de Triángulo, Área y Perímetro***\n");
            lado1 = GetIntegerDataFromUser("Ingrese lado 1: ");
            lado2 = GetIntegerDataFromUser("Ingrese lado 2: ");
            lado3 = GetIntegerDataFromUser("Ingrese lado 3: ");


            if (lado1 == lado2 && lado2 == lado3)
            {
                msg = "Triángulo Equilátero";
            }
            else if ((lado1 != lado2) && (lado2 != lado3) && (lado1 != lado3))
            {
                msg = "Triángulo Escaleno";
            }
            else
            {
                msg = "Triángulo Isóceles";
            }

            perimetro = lado1 + lado2 + lado3;
            semiperimetro = perimetro / 2;
            area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

            Console.WriteLine($"\nTipo: {msg}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }


        public void ShowExercise7()
        {
            string montoStr, msg = "";
            int monto, aux;

            Console.Write("Ingrese el monto total: ");
            montoStr = Console.ReadLine();

            Int32.TryParse(montoStr, out monto);

            aux = monto % 1000;
            monto /= 1000;

            if (monto != 0)
            {
                msg += getMessage(monto, aux, "1000");
            }
            monto = aux;
            aux = aux % 500;
            monto /= 500;
            if (monto != 0)
            {
                msg += getMessage(monto, aux, "500"); ;
            }
            monto = aux;
            aux = aux % 200;
            monto /= 200;
            if (monto != 0)
            {
                msg += getMessage(monto, aux, "200"); ;
            }
            monto = aux;
            aux = aux % 50;
            monto /= 50;
            if (monto != 0)
            {
                msg += getMessage(monto, aux, "50");
            }
            monto = aux;
            aux = aux % 20;
            monto /= 20;
            if (monto != 0)
            {
                msg += getMessage(monto, aux, "20");
            }
            monto = aux;
            aux = aux % 10;
            monto /= 10;
            if (monto != 0)
            {
                msg += getMessage(monto, aux, "10");
            }
            monto = aux;
            aux = aux % 5;
            monto /= 5;
            if (monto != 0)
            {
                msg += monto + " moneda de $5" + (aux == 0 ? "." : ", ");
            }
            monto = aux;
            aux = aux % 2;
            monto /= 2;
            if (monto != 0)
            {
                msg += monto + " moneda de $2" + (aux == 0 ? "." : ", ");
            }
            monto = aux;
            aux = aux % 1;
            monto /= 1;
            if (monto != 0)
            {
                msg += monto + " moneda de $1" + (aux == 0 ? "." : ", ");
            }



            Console.WriteLine(msg);
        }


        public void ShowExercise8()
        {
            string numStr;
            int num;

            do
            {
                Console.Write("Ingrese un número entero: ");
                numStr = Console.ReadLine();

            } while (!Int32.TryParse(numStr, out num));


            ;

            Console.Write($"Números del (1 al {num}): ");
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
        }

        public void ShowExercise9()
        {
            double num, totalSum = 0.0;
            Console.WriteLine("\t\tIngresar 15 números\n\n");

            for (int i = 1; i <= 15; i++)
            {

                num = GetIntegerDataFromUser($"Ingrese {i}\u00BA número: ");
                totalSum += num;
            }

            Console.WriteLine("La suma total de los números ingresados: " + totalSum);
        }

        public void ShowExercise10()
        {
            int num;
            string msgMul = "";
            Console.WriteLine("\t\tIngresar 5 números\n\n");

            for (int i = 1; i <= 5; i++)
            {
                num = GetIntegerDataFromUser($"Ingrese {i}\u00BA número: ");
                if (num % 3 == 0)
                {
                    msgMul += num + ", ";
                }

            }

            if (msgMul != "")
            {
                Console.WriteLine($"Número/s múltplo de 3 -> {msgMul}\b\b.");
            }
            else
            {
                Console.WriteLine("No se ingresaron números múltiplo de 3");
            }
        }

        public void ShowExercise11()
        {
            string password1 = "", password2 = "";

            Console.Write("Ingrese una contraseña: ");
            password1 = Console.ReadLine();

            do
            {
                password2 = password1;
                Console.Write("Ingrese otra contraseña: ");
                password1 = Console.ReadLine();
            } while (!password1.Equals(password2));
        }

        public void ShowExercise12()
        {
            string password1 = "", password2 = "";
            int count;

            Console.Write("Ingrese una contraseña: ");
            password1 = Console.ReadLine();
            count = 1;

            do
            {
                password2 = password1;
                Console.Write("Ingrese otra contraseña: ");
                password1 = Console.ReadLine();
                count++;
            } while ((!password1.Equals(password2) && count < 3));
        }

        public void ShowExercise13()
        {
            Random r = new Random();
            string opc = "SI";
            int num, numRandom;
            bool isAdivino = false;


            Console.WriteLine("\t\tAdivinar número entre (1-100)\n\n");

            Console.WriteLine("\n\nGenerando número aleatorio!!!\n\n");
            numRandom = r.Next(1, 101);

            while (opc.Equals("si", StringComparison.OrdinalIgnoreCase))
            {

                num = GetIntegerDataFromUser("Ingrese número posible: ");
                if (num == numRandom)
                {
                    isAdivino = true;
                    break;
                }

                Console.Write("¿Desesa seguir intentado? (SI/NO): ");
                opc = Console.ReadLine();
            }

            if (isAdivino)
            {
                Console.WriteLine("Felicidades Adivinaste el número aleatorio!!!");
            }
            else
            {
                Console.WriteLine($"Perdiste!!! El número aleatorio era: {numRandom}");
            }
        }

        public void ShowExercise14()
        {
            Random r = new Random();
            string opc = "SI";
            int num, numRandom;
            bool isAdivino = false;


            Console.WriteLine("\t\tAdivinar número entre (1-100)\n\n");

            Console.WriteLine("\n\nGenerando número aleatorio!!!\n\n");
            numRandom = r.Next(1, 101);

            while (opc.Equals("si", StringComparison.OrdinalIgnoreCase))
            {
                num = GetIntegerDataFromUser("Ingrese número posible: ");

                if (num < numRandom)
                {
                    Console.WriteLine("Intenta otra vez. El número a adivinar es mayor.");
                }
                else if (num > numRandom)
                {
                    Console.WriteLine("Intenta otra vez. El número a adivinar es menor.");

                }
                else
                {
                    isAdivino = true;
                    break;
                }
                Console.Write("¿Desesa seguir intentado? (SI/NO): ");
                opc = Console.ReadLine();
            }

            if (isAdivino)
            {
                Console.WriteLine("Felicidades Adivinaste el número aleatorio!!!");
            }
            else
            {
                Console.WriteLine($"Perdiste!!! El número aleatorio era: {numRandom}");
            }
        }


        public void ShowExercise15()
        {
            string? numStr;
            double suma = 0.0, num;
            bool isFin = false;

            Console.WriteLine("\t\t Suma de N números\n\n");


            while (!isFin)
            {

                Console.Write("Ingrese número (\'fin\' -> para salir): ");
                numStr = Console.ReadLine();
                if (Double.TryParse(numStr, out num))
                {
                    suma += num;
                }
                else
                {
                    isFin = true;
                }

            }

            Console.WriteLine($"El resultado de la suma de los números ingresados es: {suma}");
        }




        private int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;


            while (!isDataValid)
            {
                Console.Write(message);
                userData = Console.ReadLine();

                if (!Int32.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que ingresaste no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }


            }

            return data;
        }

        private string getMessage(int monto, int aux, string money)
        {
            return monto + $" moneda de ${money}" + (aux == 0 ? "." : ", ");
        }
    }
}
