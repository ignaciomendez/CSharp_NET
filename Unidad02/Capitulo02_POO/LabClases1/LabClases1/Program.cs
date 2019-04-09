using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            void ejercicio1(){ 

            A instanciaA = new A();
            B instanciaB = new B();
            A segundaA = new A("nombre");

            instanciaA.getNombreInstancia();
            segundaA.getNombreInstancia();

            instanciaB.M4();
            instanciaB.MostrarNombre();
            segundaA.MostrarNombre();
            Console.ReadKey();
            }

            void ejercicio2() { 
            D d = new D();
            C c = d;
            c.F();
            d.F();
            c.G();
            d.G();

            Console.ReadKey();
            }

        }
    }
}
