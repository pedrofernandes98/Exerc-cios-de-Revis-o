using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    class Program
    {
        /// <summary>
        /// Funççai teste
        /// </summary>
        /// <param name="m">Matriz</param>
        /// <param name="random">Randomico</param>
        static void Preenche(int[,] m,Random random)
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = random.Next(100);
                }
            }

            

            //Como fazer os números aleatórios sem fazer 2 fors
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        n[i, j] = x.Next(100);
            //    }
            //}
        }

        static void Imprime(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} |", m[i, j]);
                }
                Console.Write("\n");
            }
        }

        static int[,] CalculaSoma(int[,] A, int[,] B)
        {
            int[,] soma = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma[i, j] = A[i, j] + B[i, j];
                }
            }

            return soma;
        }

        static int[,] CalculaDif(int[,] A, int[,] B)
        {
            int[,] dif = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dif[i, j] = A[i, j] - B[i, j];
                }
            }

            return dif;
        }

        static void Main(string[] args)
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] Soma = new int[3, 3];
            int[,] Diferenca = new int[3, 3];
            Random x = new Random();

            Preenche(A,x);
            Console.WriteLine("Matriz A: \n");
            Imprime(A);


            Preenche(B,x);
            Console.WriteLine("\nMatriz B: \n");
            Imprime(B);


            Soma = CalculaSoma(A, B);
            Diferenca = CalculaDif(A, B);

            Console.WriteLine("\nMatriz Soma: \n");
            Imprime(Soma);

            Console.WriteLine("\nMatriz Diferença: \n");
            Imprime(Diferenca);

            Console.ReadKey();


        }
    }
}
