using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.Write("Os números perfeitos de 1 a 1000 são: ");
            for(int i=1; i<= 1000; i++)
            {
                soma = 0;

                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        soma += j;
                    }

                    
                }

                if(soma == i)
                {
                    Console.Write("| {0} |", i);
                }
            }

            Console.ReadKey();
        }
    }
}
