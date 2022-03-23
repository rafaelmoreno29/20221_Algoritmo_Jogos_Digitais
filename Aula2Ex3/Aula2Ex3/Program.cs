using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite a nota 1");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média é: " + media);
            Console.ReadKey();
        }
    }
}
