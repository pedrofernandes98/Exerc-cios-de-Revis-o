using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    class Program
    {
        static void Preenche(int[,] m)
        {
            Random x = new Random();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    m[i, j] = x.Next(100);
                }
            }
        }

        static void MostraMatriz(int[,] m)
        {
            Console.WriteLine("Matriz: \n");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("{0} |", m[i, j]);
                }
                Console.Write("\n");
            }
        }

        static void MostraVetor(int[] v)
        {
            Console.Write("\nVetor Resultante: ");
            for(int i = 0; i < v.Length; i++)
            {
                Console.Write("{0} |", v[i]);
            }
        }

        static int[] VetorFora(int[,] m)
        {
            int[] vet = new int[6];
            int pos = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if( i != j)
                    {
                        vet[pos++] = m[i, j]; 
                    }
                }
            }

            return vet;
        }



        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int[] VetorResultante = new int[6];

            Preenche(matriz);
            MostraMatriz(matriz);
            VetorResultante = VetorFora(matriz);

            MostraVetor(VetorResultante);

            Console.ReadKey();

        }
    }
}
