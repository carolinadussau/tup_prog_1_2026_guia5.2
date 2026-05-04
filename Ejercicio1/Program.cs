using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionDelAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double condPromocion, nota1, nota2, nota3, promedio;

            //Solicitar al usuario el valor de la condición de promoción
            Console.Write("Ingrese la nota de condición de promoción: ");
            condPromocion = Convert.ToDouble(Console.ReadLine());

            //Solicitar al usuario las tres notas
            Console.Write("Ingrese la primera nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            //Calcular el promedio
            promedio = (nota1 + nota2 + nota3) / 3;

            //Determinar la condición del alumno
            if (promedio >= condPromocion)
            {
                Console.WriteLine("El alumno está promocionado.");
            }
            else if (promedio >= 4)
            {
                Console.WriteLine("El alumno está aprobado.");
            }
            else
            {
                Console.WriteLine("El alumno está desaprobado.");
            }
        }
    }
}
