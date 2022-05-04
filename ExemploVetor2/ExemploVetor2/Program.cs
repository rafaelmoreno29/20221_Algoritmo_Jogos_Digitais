using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVetor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* exercício 1 */
            /* int[] numeros = new int[6];

             for (int i = 0; i < numeros.Length; i++)
             {
                 Console.WriteLine("Digite o número " + (i + 1) + ":");
                 numeros[i] = Convert.ToInt32(Console.ReadLine());
             }

             for(int i = 5;i >= 0; i--)
             {
                 Console.Write(numeros[i] + ", ");
             }

             Console.ReadKey();
            */

            /* EXERCICIO 2 */
            //double[] notas = new double[20];
            //double somaNotas = 0;

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("Digite a nota " + (i + 1) + ":");
            //    notas[i] = Convert.ToDouble(Console.ReadLine());
            //    somaNotas = somaNotas + notas[i];
            //}
            //double media = somaNotas / 20;

            //Console.WriteLine("A média é: " + media);
            //Console.WriteLine("As notas digitadas são: ");
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.Write(notas[i] + ", ");
            //}
            //Console.ReadKey();

            /*EXERCICIO 3*/
            int[] numeros = new int[12];
            int[] numerosImpares = new int[12];
            int i = 0;
            int j = 0;
            int num;
            while(i < numeros.Length)
            {
                Console.WriteLine("Digite o número "+(i+1) +":");
                num = Convert.ToInt32(Console.ReadLine());

                if(num >= 0 && num <= 30)
                {
                    numeros[i] = num;
                    i++;
                    if(num % 2 > 0)
                    {
                        numerosImpares[j] = num;
                        j++;
                    }
                }
            }
            Console.WriteLine("Números digitados:");
            for (int x = 0; x < numeros.Length; x++)
            {               
                Console.Write(numeros[x] + ", ");
            }
            Console.WriteLine("\nNúmeros Impares:");
            for (int x = 0; x < numerosImpares.Length; x++)
            {
                if(numerosImpares[x] > 0)
                    Console.Write(numerosImpares[x] + ", ");
            }
            Console.ReadKey();

        }
    }
}
