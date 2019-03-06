using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex9
{
    class Program
    {
        static void ContaMultiplo3(int[] v)
        {
            int cont = 0;

            Console.Write("Números Mútiplos de 3 no vetor: ");
            for(int i = 0; i < 10; i++)
            {
                if(v[i] % 3 == 0)
                {
                    ++cont;
                    Console.Write("| {0} |", v[i]);
                }
            }
            Console.WriteLine("\nTotal de Números múltiplos de 3 presentes no vetor: {0}", cont);

            Console.ReadKey();
        }

        static void Preenche(int[] v)
        {
            Random x = new Random();

            for(int i = 0; i < 10; i++)
            {
                v[i] = x.Next(100);
            }
        }

        static void Imprime(int[] v)
        {
            Console.Write("Vetor:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0} |", v[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Preenche(vetor);
            Imprime(vetor);
            ContaMultiplo3(vetor);

        }
    }
}
