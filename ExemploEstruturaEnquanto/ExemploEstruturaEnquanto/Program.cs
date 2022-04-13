using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstruturaEnquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int x = 0;
            while(x >= 0)
            {
                Console.WriteLine("Digite um número");
                x = Convert.ToInt32(Console.ReadLine());
            }*/

            /* int n1, n2, soma = 0;
             while(soma < 15)
             {
                 Console.WriteLine("Digite um número");
                 n1 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Digite um número");
                 n2 = Convert.ToInt32(Console.ReadLine());

                 soma = n1 + n2;

                 Console.WriteLine(soma);
             }*/
            /*
                        int x = 1;
                        while (x <= 10)
                        {
                            Console.WriteLine(x);
                            x++; // x = x + 1;
                        }
                        Console.ReadKey();
            */
            string texto = "";
            while(texto != "UNISO")
            {
                Console.WriteLine("Digite o texto");
                texto = Console.ReadLine();
            }

        }
    }
}
