using System;
using System.Security.Cryptography.X509Certificates;

namespace AEDs_CSharp_PUC_MG.Lista_Recursividade
{
    public class Exercícios
    {
        /*
        public static void Main(String[] args)
        {
            int a = 2, n = 2;
            Console.WriteLine("{0} ^ {1} = {2}", a, n, PotenciaRecursiva(2, 2));

            int x = 4, y = 7;
            Console.WriteLine("A soma recursiva no intervalo entre os números {0} e {1} é {2}", x, y, SomaIntervaloRecursiva(x, y));

            int b = 2;
            Console.Write("O número {0} em binário é: ", b);
            DecimalParaBinario(b);
            Console.WriteLine();
            
            int c = 30, d = 120;
            Console.WriteLine("MDC({0}, {1}) = {2}", c, d, MDCRecursivo(c, d));
        }
        */

        public static int PotenciaRecursiva(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return a * PotenciaRecursiva(a, n - 1);
        }

        public static int SomaIntervaloRecursiva(int m, int n)
        {
            if (m == n)
            {
                return m;
            }

            return m + SomaIntervaloRecursiva(m + 1, n);
        }

        public static void DecimalParaBinario(int n)
        {
            if (n > 0)
            {
                DecimalParaBinario(n / 2);
                Console.Write(n % 2);
            }
        }

        public static int MDCRecursivo(int m, int n)
        {
            if (m > n)
            {
                return MDCRecursivo(m - n, n);
            }
            else if (m == n)
            {
                return m;
            }

            return MDCRecursivo(n, m);
        }
    }
}