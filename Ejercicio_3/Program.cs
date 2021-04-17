using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dis = 0;
            Console.WriteLine("Inserte La distancia a calcular");
            dis = double.Parse(Console.ReadLine());
            double vel = dis/6;
            Console.WriteLine("La velocidad sera de: "+vel);




            Console.ReadKey();

        }
    }
}
