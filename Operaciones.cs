using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double CalcularAreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public double CalcularLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double CalcularVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double CalcularVolumenEsfera(double radio)
        {
            return(4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }

        public void Imprimir(double radioCirculo, double largoRectangulo, double anchoRectangulo, double ladoCubo, double radioEsfera)
        {
            Console.WriteLine("Resultados de las Operaciones:");
            Console.WriteLine($"Área del círculo (radio {radioCirculo}): {CalcularAreaCirculo(radioCirculo)}");
            Console.WriteLine($"Área del rectángulo (largo {largoRectangulo}, ancho {anchoRectangulo}): {CalcularAreaRectangulo(largoRectangulo, anchoRectangulo)}");
            Console.WriteLine($"Volumen del cubo (lado {ladoCubo}): {CalcularVolumenCubo(ladoCubo)}");
            Console.WriteLine($"Longitud de la circunferencia (radio {radioCirculo}): {CalcularLongitudCircunferencia(radioCirculo)}");
            Console.WriteLine($"Volumen de la esfera (radio {radioEsfera}): {CalcularVolumenEsfera(radioEsfera)}");
        }
    }
}
