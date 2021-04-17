using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Por favor ingrese una nota");
            int nota = int.Parse(Console.ReadLine());
            if (nota < 1)
            {
                Console.WriteLine("La nota esta fuera de rango");
            }
            else if (nota > 7)
            {
                Console.WriteLine("La nota esta fuera de rango");
            }
            else if (nota >= 1 && nota <= 7)
            {
                Console.WriteLine("La nota es correcta");
            }
        }







        }
    
    }

