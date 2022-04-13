using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstruturaFacaEnquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1, n2, soma = 0;
            do
            {
                Console.WriteLine("Digite um número");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um número");
                n2 = Convert.ToInt32(Console.ReadLine());

                soma = n1 + n2;

                Console.WriteLine(soma);
            } 
            while (soma < 15);
            */

            /*int x = 1;
            do
            {
                Console.WriteLine(x);
                x++; // x = x + 1;
            }
            while (x <= 10);

            Console.ReadKey();
            */

            string texto = "";
            do
            {
                Console.WriteLine("Digite o texto");
                texto = Console.ReadLine();
            }
            while (texto != "UNISO");
        }
    }
}
