using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    class Program
    {
        static void Preenche(double[] a,char[] s)
        {
            Random x = new Random();

            double num;
            

            for (int i = 0; i < 15; i++)
            {
                num = x.NextDouble();//Sorteia um decimal aleatório ente 0.0 e 1.0
                num += 1;//Soma mais 1 para dar a minha altura desejada

                a[i] = num;//Altura Preenchida

                num = x.Next(2);

                if(num == 1)
                {
                    s[i] = 'M';
                }
                else
                {
                    s[i] = 'F';
                }


            }

        }

        static void Imprime(double[] a, char[] s)
        {
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Pessoa {0}: ", i + 1);
                Console.Write("    Altura - {0:F2} | Sexo - {1}\n", a[i], s[i]);
            }
        }

        static void MostraMaiorMenor(double[] a)
        {
            double maior = 0, menor = 0;

            for(int i = 0; i < 15; i++)
            {

                if(i == 0)
                {
                    menor = a[i];
                }

                if(a[i] > maior)
                {
                    maior = a[i];
                }

                if(a[i] < menor)
                {
                    menor = a[i];
                }
            }

            Console.WriteLine("\nMaior Altura do Grupo : {0:F2}", maior);
            Console.WriteLine("Menor Altura do Grupo : {0:F2}", menor);
        }

        static double CalculaMedia(double[] a, char[] s)
        {
            double media, soma = 0;
            int cont = 0;

            for(int i = 0; i < 15; i++)
            {
                if(s[i] == 'F')
                {
                    soma += a[i];
                    ++cont;
                }
            }

            media = soma / (double)cont;

            return media;

        }

        static int NumeroHomens(char[] s)
        {
            int cont = 0 ;
            for(int i = 0; i < 15; i++)
            {
                if(s[i] == 'M')
                {
                    ++cont;
                }
            }

            return cont;
        }

        static void Main(string[] args)
        {
            double[] altura = new double[15];
            char[] sexo = new char[15];
            double media;
            int n_homens;

            Preenche(altura, sexo);
            Imprime(altura, sexo);
            MostraMaiorMenor(altura);

            media = CalculaMedia(altura, sexo);
            Console.WriteLine("\nA média de alturas das mulheres é {0:F2}", media);

            n_homens = NumeroHomens(sexo);
            Console.WriteLine("\nNumero de Homens: {0}", n_homens);

            Console.ReadKey();

            
        }
    }
}
