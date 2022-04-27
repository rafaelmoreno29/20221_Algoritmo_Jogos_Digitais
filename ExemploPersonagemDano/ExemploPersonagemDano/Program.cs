using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPersonagemDano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int classe, dano, vida;

            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Escolha: 1 - Paladino ou 2 - Arqueiro");
            classe = Convert.ToInt32(Console.ReadLine());

            if (classe == 1)
                vida = 20;
            else
                vida = 10;

            while (vida > 0)
            {
                Random random = new Random();
                int escapou = random.Next(1,3);

                if (escapou == 1)
                {
                    Console.WriteLine("Você escapou do ataque!!!");
                }
                else
                {
                    dano = random.Next(1, 6);
                    Console.WriteLine("Você sofreu um dano de: " + dano);
                    vida = vida - dano;
                    Console.WriteLine("Restou " + vida + " vida");
                }

                Console.WriteLine("Aperte uma tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
