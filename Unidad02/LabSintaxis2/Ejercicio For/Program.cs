using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] arreglo = new string[cantIteraciones];

            Console.WriteLine("Ingrese valores del arreglo: ");

            for (int i = 0; i < cantIteraciones; i++)
            {
                arreglo[i] = Console.ReadLine();
                Console.WriteLine("Valor " + (i+1) + " del arreglo guardado.");
            }

            Console.WriteLine("Fin de carga del arreglo, arreglo ingresado: ");

            for (int i = cantIteraciones-1 ; i >= 0; i--)
            {
                Console.WriteLine("Valor " + (i+1) + " del arreglo: " + arreglo[i]);
               
            }

            Console.ReadKey();
        }
    }
}
