using System;
using System.Threading;
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nr, n1, n2;

            Console.WriteLine("Bienvenido al Programa de Operaciones de Matematicas Sencillas");
            Console.ReadKey();
            do
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("ingrese 1 para hacer suma, 2 para hacer resta, 3 para hacer multiplicacion y 4 para hacer division");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n == 1 || n == 2 || n == 3 || n == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese el primer numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                suma(n1,n2);
                                Thread.Sleep(2000);
                                break;
                            case 2:
                                resta(n1,n2);
                                Thread.Sleep(2000);
                                break;
                            case 3:
                                multiplicar(n1,n2);
                                Thread.Sleep(2000);
                                break;
                            case 4:
                                dividir(n1,n2);
                                Thread.Sleep(2000);
                                break;

                                //default:
                                //Console.WriteLine("Usted ingreso un numero incorrecto");
                                //break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usted ingreso un numero incorrecto");
                    }
                } while (n < 0 || n > 4);
                Console.WriteLine("Ingrese 1 si quiere repetir el programa O Ingrese 2 para salir.");
                nr = Convert.ToInt32(Console.ReadLine());
            } while (nr == 1);
        }

        static void suma(float num1,float num2)
        {
            float resultado;
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma de los 2 numeros es: {0}", resultado);
        }

        static void resta(float num1,float num2)
        {
            float resultado;
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta de los 2 numeros es: {0}", resultado);
        }

        static void multiplicar(float num1,float num2)
        {
            float resultado;
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicacion de los 2 numeros es: {0}", resultado);
        }

        static void dividir(float num1,float num2)
        {
            float resultado;

            if(num2 == 0)
            {
                Console.WriteLine("El resultado de la division de los 2 numeros es: INDEFINIDO");

            } else {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la division de los 2 numeros es: {0}", resultado);

            }
        }


    }
}
