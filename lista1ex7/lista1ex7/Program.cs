using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double arvoreA = 0.80;
            double arvoreB = 1.30;
            int ano = 0;

            do
            {
                arvoreA += 0.12;
                arvoreB += 0.08;
                ++ano;

                Console.WriteLine("Ano: {0}\nÁrvore A: {1:F2}\nÁrvore B: {2:F2}\n",ano,arvoreA,arvoreB);
            } while (arvoreA < arvoreB);

            Console.WriteLine("No ano {0} a árvore A estará maior que a árvore B",ano);
           

            Console.ReadKey();
        }
    }
}
