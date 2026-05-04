using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double num, numMayor;

            // Primer número
            Console.Write("Ingrese el primer número: ");
            num = Convert.ToDouble(Console.ReadLine());
            numMayor = num;

            // Segundo número
            Console.Write("Ingrese el segundo número: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > numMayor)
            {
                numMayor = num;
            }

            // Tercer número
            Console.Write("Ingrese el tercer número: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > numMayor)
            {
                numMayor = num;
            }

            // Cuarto número
            Console.Write("Ingrese el cuarto número: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > numMayor)
            {
                numMayor = num;
            }

            // Quinto número
            Console.Write("Ingrese el quinto número: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > numMayor)
            {
                numMayor = num;
            }

            // Resultado
            Console.WriteLine("El mayor es: " + numMayor);
        }
    }
}
