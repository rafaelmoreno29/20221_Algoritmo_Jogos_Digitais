using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex4();
        }
        static void Ex1()
        {
            int total = 0, valor;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o número " + i);
                valor = Convert.ToInt32(Console.ReadLine());

                total += valor;
            }
            Console.WriteLine("A média é: " + (total / 10));
            Console.WriteLine("O total é: " + total);
            Console.ReadKey();
        }

        static void Ex4()
        {
            int num, totalPar = 0, totalImpar = 0;

            do
            {
                Console.WriteLine("Digite um número");
                num = Convert.ToInt32(Console.ReadLine());

                if( num % 2 == 0 )
                    totalPar++;
                else
                    totalImpar++;
            }
            while(num != 0);
            Console.WriteLine("Total Par: " + totalPar);
            Console.WriteLine("Total Ímpar: " + totalImpar);
            Console.ReadKey();
        }

    }
}
