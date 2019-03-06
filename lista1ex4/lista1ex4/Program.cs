using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    class Program
    {
        static void Preenche(int[] A, int[] B)
        {
            Random x = new Random();


            for (int i = 0; i < 10; i++)
            {
                A[i] = x.Next(100);
                B[i] = x.Next(100);
            }
        }

        static int[] SomaVetores(int[] A, int[] B)
        {
            int[] s = new int[10];

            for(int i = 0; i < 10; i++)
            {
                s[i] = A[i] + B[i];
            }

            return s;
        }

        static void Imprime(int[] x)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(" {0} |", x[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] soma = new int[10];

            Preenche(A, B);
            Console.WriteLine("Vetor A:");
            Imprime(A);
            Console.WriteLine("\nVetor B:");
            Imprime(B);
            soma = SomaVetores(A, B);
            Console.WriteLine("\nVetor Soma:");
            Imprime(soma);

            Console.ReadKey();
        }
    }
}
