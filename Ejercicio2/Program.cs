using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativoPositivoCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double num;

            //Solicitar al usuario un número
            Console.Write("Ingrese un número: ");
            num = Convert.ToDouble(Console.ReadLine());

            //Determinar si el número es positivo, negativo o cero
            {
                if (num < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else if (num > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else
                {
                    Console.WriteLine("El número es cero.");
                }

            }
        }
    }
}
