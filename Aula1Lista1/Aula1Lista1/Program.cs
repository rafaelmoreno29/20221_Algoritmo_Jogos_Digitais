using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            int comprimento;
            int area;
            int altura;
            Console.WriteLine("Digite o comprimento");
            comprimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = Convert.ToInt32(Console.ReadLine());

            area = comprimento * altura;

            Console.WriteLine("A área é: " + area);
            Console.ReadKey();

        }
    }
}
