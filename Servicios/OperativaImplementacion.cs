using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void hacerMultiplicacion(int numero)
        {
            int multiplicacion = 1;
            for (int i = 1; i <= numero; i++)
            {
                multiplicacion = i * multiplicacion;
            }
            Console.WriteLine("El resultado de la multiplicación es: " + multiplicacion);
        }
    }
}