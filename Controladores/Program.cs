using Ejercicio4.Servicios;

namespace Ejercicio4.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            int numero = mi.pedirNumero();
            oi.hacerMultiplicacion(numero);

            char tecla;
            Console.WriteLine("¿Quiere introducir un nuevo numero?");
            tecla = Convert.ToChar(Console.ReadLine());
            if (tecla == 's')
            {
               int otroNumero= mi.pedirNumero();
               oi.hacerMultiplicacion(otroNumero);
            }
            else
            {
                Console.WriteLine("Hasta pronto");
              
            }
        }
    }
}
