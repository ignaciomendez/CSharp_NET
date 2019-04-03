using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor1 = "Este es el valor 1";
            int valor2 = 5;
            string valor3 = valor1; //Solo puedo asignar a valor3 el string valor1 dado que lo definimos como string. No podemos asignarle valor2 por ser int.
 
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3); //WriteLine soporta que se ingrese entero o string.

            Console.WriteLine(); //deja un espacio
            Console.WriteLine("Presione una tecla para continuar"); 
            Console.ReadKey(); // Final original del ejercicio, todo el texto debajo es una adición propia para probar la asignación de valores.

            //Console.WriteLine("Ingrese nuevo valor 3");
            //valor3 = Console.ReadLine();
            //Console.WriteLine("El nuevo valor 3 es: " + valor3);
            //Console.WriteLine("Presione una tecla para continuar");
            //Console.ReadKey();
        }
    }
}
