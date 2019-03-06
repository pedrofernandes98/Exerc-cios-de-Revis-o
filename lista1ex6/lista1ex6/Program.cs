using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    class Program
    {
        static void Compara(int[] A, int[] B, ref int aux)
        {
            int cont = 0;
            for(int i = 0; i < 10; i++)
            {
                cont = 0;
                for(int j = 0; j < aux; j++)
                {
                    if(A[i] == B[j])
                    {
                        ++cont;
                    }

                }

                if(cont == 0)
                {
                    B[aux] = A[i];
                    aux++;
                }
            }
        }

        static void Preenche(int[] A, Random X)
        {
            

            for(int i = 0; i < 10; i++)
            {
                A[i] = X.Next(10);
            }

        }

        static void Imprime(int[] A)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(" {0} |", A[i]);
            }
        }

        static void Imprime2(int[] A,int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                Console.Write(" {0} |", A[i]);
            }
        }

        static void Main(string[] args)
        {
            int[] R = new int[10];
            int[] S = new int[10];
            int pos = 0;
            int[] V = new int[20];
            Random X = new Random();


            Preenche(R, X);
            Console.WriteLine("Vetor R: ");
            Imprime(R);
            Preenche(S, X);
            Console.WriteLine("\nVetor S: ");
            Imprime(S);
            Compara(R, V, ref pos);
            Compara(S, V, ref pos);


            Console.WriteLine("\nVetor V: ");
            Imprime2(V, pos);

            Console.ReadKey();

        }
    }
}
