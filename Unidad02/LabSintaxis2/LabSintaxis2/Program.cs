using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un texto: ");
            String inputTexto;
            inputTexto = Console.ReadLine();

            if (inputTexto=="")
            {
                Console.WriteLine("Texto vacío. Fin de la aplicación");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Valor del texto: " + inputTexto);

                Console.WriteLine();
                Console.WriteLine("Menú");
                Console.WriteLine("1- Transformar a mayúsculas");
                Console.WriteLine("2- Transformar a minúsculas");
                Console.WriteLine("3- Mostrar cantidad de caracteres.");
                Console.WriteLine();

                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key==ConsoleKey.D1)
                {
                    Console.WriteLine();
                    Console.WriteLine(inputTexto.ToUpper());
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Console.WriteLine(inputTexto.ToLower());
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine();
                    Console.WriteLine(inputTexto.Length);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opción invalida. Fin de la aplicación.");

                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
