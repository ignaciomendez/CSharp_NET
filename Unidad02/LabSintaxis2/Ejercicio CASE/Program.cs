using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_CASE
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

                switch (opcion.Key) { 
                    case ConsoleKey.D1:
                    {
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    }

                    case ConsoleKey.D2:
                {
                    Console.WriteLine();
                    Console.WriteLine(inputTexto.ToLower());
                            break;
                }
                    case ConsoleKey.D3:
                {
                    Console.WriteLine();
                    Console.WriteLine(inputTexto.Length);
                            break;
                }
                    default:
                {
                    Console.WriteLine();
                    Console.WriteLine("Opción invalida. Fin de la aplicación.");
                            break;
                }
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}

