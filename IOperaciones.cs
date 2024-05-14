using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double CalcularAreaCirculo(double radio);
        double CalcularAreaRectangulo(double largo, double ancho);
        double CalcularVolumenCubo(double lado);
        double CalcularLongitudCircunferencia(double radio);
        double CalcularVolumenEsfera(double radio);
    }
}
