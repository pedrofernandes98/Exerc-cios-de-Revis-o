using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    class Program
    {
        static void VerificaPalindromo()
        {
            int aux, aux2, div, div2, sub, aux3, aux4;
            Console.Write("Números Palíndromos de 4 algarismos: ");
            for(int i=1000; i<10000; i++)
            {
                //Pega o 4° algarismo
                aux = i / 1000;
                //Pega o 1° algarismo
                aux2 = i % 10;

                //Pega o 3° algarismo
                aux3 = i / 100;
                aux3 = aux3 % 10;

                //Pega o 2° algarismo
                aux4 = i % 100;
                aux4 = aux4 / 10; 


                if(aux == aux2 && aux3 == aux4)
                {
                                  
                    
                    Console.Write("| {0} |", i);
                    

                    

                }


                

               

                
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            VerificaPalindromo();

        }
    }
}
