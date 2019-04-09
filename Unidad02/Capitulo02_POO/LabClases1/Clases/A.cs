using System;

namespace Clases
{
    public class A
    {
        private String NombreInstancia;

        public String getNombreInstancia()
        {
            return NombreInstancia;
        }

        public void setNombreInstancia(String instancia)
        {
            NombreInstancia = instancia;
        }

        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }

        public A(String instancia)
        {
            NombreInstancia = instancia;
        }

        public void MostrarNombre()
        {
            Console.WriteLine("El nombre de la instancia es: " + NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("Método M1 invocado");
        }

        public void M2()
        {
            Console.WriteLine("Método M2 invocado");
        }

        public void M3()
        {
            Console.WriteLine("Método M3 invocado");
        }
    }

    public class C
    {
        public void F() { Console.WriteLine("C.F"); }
        public virtual void G() { Console.WriteLine("C.G"); }
    }

    public class D : C
    {
        new public void F() { Console.WriteLine("D.F"); }
        public override void G() { Console.WriteLine("D.G"); }
    }
}
