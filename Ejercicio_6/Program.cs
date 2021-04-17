using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());
            for (int contador = 0; contador < num;contador++)
            {
                if ((contador % 2 ) != 0)
                {
                    Console.WriteLine(contador);
                }
            }

            Console.ReadLine();
            
            
             
        }
    }
}
