using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double notas = 0;
            double prom = 0;
            Console.WriteLine("Ingrese una cantidad de notas: ");
            int cantidad = int.Parse(Console.ReadLine());
            while (contador < cantidad)
            {
                Console.WriteLine("Ingrese una notas: ");
                notas = double.Parse(Console.ReadLine());
                contador++;
                int a = 0;
                while (a == 0)
                {
                    if (notas >= 1 && notas <=7)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                        Console.WriteLine("Ingrese una nota valida: ");
                        notas = double.Parse(Console.ReadLine());


                    }
                }
                prom += notas;

            }
            prom /= cantidad;
            Console.WriteLine("Su Promedio es:  "+prom);
            Console.WriteLine("Gracias por preferirnos entel, nadie te da mas");

            

            

            


            Console.ReadKey();
        }
    }
}
