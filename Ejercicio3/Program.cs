using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdenada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            string nombre1, nombre2, nombre3;
            int libreta1, libreta2, libreta3;

            //Solicitar al usuario los nombres y números de libreta
            Console.Write("Ingrese nombre y libreta del primer alumno: ");
            nombre1 = Console.ReadLine();
            libreta1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese nombre y libreta del segundo alumno: ");
            nombre2 = Console.ReadLine();
            libreta2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese nombre y libreta del tercer alumno: ");
            nombre3 = Console.ReadLine();
            libreta3 = Convert.ToInt32(Console.ReadLine());

            //Comparar los números de libreta y mostrar lista ordenada por número de libreta
            if (libreta1 <= libreta2 && libreta1 <= libreta3)
            {
                Console.WriteLine(nombre1 + " - " + libreta1);

                if (libreta2 <= libreta3)
                {
                    Console.WriteLine(nombre2 + " - " + libreta2);
                    Console.WriteLine(nombre3 + " - " + libreta3);
                }
                else
                {
                    Console.WriteLine(nombre3 + " - " + libreta3);
                    Console.WriteLine(nombre2 + " - " + libreta2);
                }
            }
            else if (libreta2 <= libreta1 && libreta2 <= libreta3)
            {
                Console.WriteLine(nombre2 + " - " + libreta2);

                if (libreta1 <= libreta3)
                {
                    Console.WriteLine(nombre1 + " - " + libreta1);
                    Console.WriteLine(nombre3 + " - " + libreta3);
                }
                else
                {
                    Console.WriteLine(nombre3 + " - " + libreta3);
                    Console.WriteLine(nombre1 + " - " + libreta1);
                }
            }
            else
            {
                Console.WriteLine(nombre3 + " - " + libreta3);

                if (libreta1 <= libreta2)
                {
                    Console.WriteLine(nombre1 + " - " + libreta1);
                    Console.WriteLine(nombre2 + " - " + libreta2);
                }
                else
                {
                    Console.WriteLine(nombre2 + " - " + libreta2);
                    Console.WriteLine(nombre1 + " - " + libreta1);
                }
            }
        }
    }
}
            
