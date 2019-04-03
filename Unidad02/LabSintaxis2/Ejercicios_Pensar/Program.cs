using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Pensar
{
    class Program
    {
        static void Main(string[] args)
        {

            //SUMA
            void sum() { 
            Console.WriteLine("Ingrese primer número: ");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo número: ");
            int numero2 = Int32.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de " + numero1 + " y " + numero2 + " es: " + suma);

            Console.ReadKey();
            }
            //sum();

            //EVALUA SI AÑO ES BISIESTO
            void calculoBisiesto() { 
            Console.Write("Ingrese año: ");
            float year = float.Parse(Console.ReadLine());

            //float calculo = (year % 4);
            
            if (year % 4==0&&year%100!=0||year%400==0) {

                Console.WriteLine("Año bisiesto.");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Año no bisiesto");
                Console.ReadLine();

            }
            }
            //calculoBisiesto();

            //SUMATORIA SERIE DE FIBONACCI
            
            Console.Write("Ingrese longitud de la sumatoria: ");
            int longitud = Int32.Parse(Console.ReadLine());
            int fibonacci = 0;
            int fibonacciP = 1;
            int fibonacciM; 
            

            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine(fibonacci);
                fibonacciM = fibonacci;
                fibonacci = fibonacci + fibonacciP;
                fibonacciP = fibonacciM; 

                Console.ReadKey();

            }






        }
    }
}
