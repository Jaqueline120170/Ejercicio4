using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio4.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero()
        {
            Console.WriteLine("Introduzca un número");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número introducido es " + numero);
            return numero;
        }
    }
}
