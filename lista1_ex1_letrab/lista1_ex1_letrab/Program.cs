using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1_ex1_letrab
{
    class Program
    {
        static int CalculaSoma(int n)
        {
            int s = 100;
             
            for(int i = 1; i <= n; i++)
            {
                if((i%2) == 0)
                {
                    s += i;
                }
                else
                {
                    s -= i;
                }
            }

            return s;
        }

        static void Imprime(int soma, int n)
        {
            Console.Write("S = 100");
            for (int i = 1; i <= n; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(" + {0}", i);
                }
                else
                {
                    Console.Write(" - {0}", i);
                }
            }

            Console.Write(" = {0}", soma);

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            int n;
            int soma;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            soma = CalculaSoma(n);

            Imprime(soma, n);



            

        }
    }
}
