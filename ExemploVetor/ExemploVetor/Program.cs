using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + "º número");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 5;i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();




            //Criei um vetor com 10 posições
          //  int[] numeros = new int[10];

            //coloquei valor 1 na posição 0
            // numeros[0] = 1;
            //coloquei valor 2 na posição 1
            // numeros[1] = 2;

            //gerar números randomicos para o vetor
            // Random random = new Random();
            //for(int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = random.Next(1,101);
            //}

            //usuario digitar o valores do vetor
           // for (int i = 0; i < numeros.Length; i++)
           // {
            //    Console.WriteLine("Digite o valor da posição " + i);
           //     numeros[i] = Convert.ToInt32(Console.ReadLine());
           // }

            //Mostrei na tela todos os valores do vetor
            //for (int i = 0; i < numeros.Length; i++)
            //{
           //     Console.WriteLine("Posição " + i + ": " + numeros[i]);
           // }
            

          //  Console.ReadKey();
        }
    }
}
