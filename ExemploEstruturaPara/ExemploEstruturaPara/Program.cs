using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEstruturaPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            for(int x = 50; x <= 100; x++)
            {
                Console.WriteLine(x);
            }
            
            */

            //Exercício 2
            /*
            for(int x = 30; x <= 50; x += 2)
            {
                Console.WriteLine(x);
            }
            */

            //Exercício 3
            for(int x = 80; x >= 40; x -= 5)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
