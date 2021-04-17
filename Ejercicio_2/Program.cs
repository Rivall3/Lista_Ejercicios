using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            Console.WriteLine("Escribe un numero:",par);
            par = int.Parse(Console.ReadLine());
            if (par % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }


            Console.ReadKey();
        }

    }
}
