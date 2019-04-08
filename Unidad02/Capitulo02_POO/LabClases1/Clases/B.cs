using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class B:A
    {
        public void M4()
        {
            Console.WriteLine("Método del hijo invocado");
        }

        //Consultar: se supone que B le pasa parámetros a A (lo pide en enunciado)? 
        public B()
        {
            Console.WriteLine("Instancia de B");
        }
    }
}
