using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1_ex1_letra_a
{
    class Program
    {
        static double CalculaSoma(int x)
        {
            double soma = 0;

            for (int i = 2; i <= x; i++)
            {
                soma += (i - 1) / (double)i;
            }

            return soma;
        }

        static void ImprimeSoma(double s, int n)
        {
            for (int i = 2; i <= n; i++)
            {

                if (i == 2)
                {
                    Console.Write(" ({0}/{1}) ", i - 1, i);
                }
                else
                {
                    Console.Write("+ ({0}/{1}) ", i - 1, i);
                }

            }

            Console.Write(" = {0:F2} ", s);
        }

        static void Main(string[] args)
        {
            int n;
            double soma = 0;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            soma = CalculaSoma(n);

            ImprimeSoma(soma, n);




            Console.ReadKey();


        }
    }
}
