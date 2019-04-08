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
    }
}
