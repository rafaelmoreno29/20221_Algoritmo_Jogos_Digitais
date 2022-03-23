using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo1();
            Exemplo2();
            Console.ReadKey();
        }
        static void Exemplo2()
        {
            int n1, n2, soma, resultado;

            Console.WriteLine("Digite o número 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;

            if (soma >= 10)
                resultado = soma + 5;
            else
                resultado = soma - 7;

            Console.WriteLine("O resultado é: " + resultado);
        }
        static void Exemplo1()
        {
            int n1, n2, soma;
            Console.WriteLine("Digite o número 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;

            if (soma > 10)
                Console.WriteLine(soma);
        }

        static void Exemplo3()
        {
            double salario, novoSalario = 0;

            Console.WriteLine("Digite o salário");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario < 500)
            {
                novoSalario = salario + (salario * 15 / 100);
            }
            else if (salario <= 1000)
            {
                novoSalario = salario + (salario * 10 / 100);
            }
            else
            {
                novoSalario = salario - (salario * 5 / 100);
            }
            Console.WriteLine("Novo salário: " + novoSalario);
        }
    }
}
