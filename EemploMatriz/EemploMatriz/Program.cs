using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EemploMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[4, 6];

            //receber valores da matriz
            for (int i = 0; i < 4; i++) //loop das linhas
            {
                for (int j = 0; j < 6; j++) //loop das colunas
                {
                    Console.WriteLine("Digite um número para a posição [" + i + "," + j + "]:");
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //mostrar valores digitados
            for (int i = 0; i < 4; i++) //loop das linhas
            {
                for (int j = 0; j < 6; j++) //loop das colunas
                {
                    Console.WriteLine("Posição [" + i + "," + j + "]: " + numeros[i, j]);     
                }
            }
            Console.ReadKey();
        }
    }
}
