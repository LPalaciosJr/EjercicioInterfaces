using System;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();

            Console.WriteLine("Ingrese el radio del círculo:");
            double radioCirculo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el largo del rectángulo:");
            double largoRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double anchoRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el lado del cubo:");
            double ladoCubo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el radio de la esfera:");
            double radioEsfera = Convert.ToDouble(Console.ReadLine());

            operaciones.Imprimir(radioCirculo, largoRectangulo, anchoRectangulo, ladoCubo, radioEsfera);
        }
    }
}
