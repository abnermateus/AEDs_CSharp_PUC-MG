using System;

namespace AEDs_CSharp_PUC_MG.Lista_Recursividade2
{
    public class Exercicios
    {
        /*
        public static void Main(String[] args)
        {
            int n = 5;
            Console.WriteLine(Soma(n));

            NumerosNaturais(n);

            int[] v = { 1, 10, 1, 8, 7, -10, -15, -7};
            int x = v.Length;
            Console.WriteLine("\n" + MaiorElemento(v, x));

            Console.WriteLine(NumerosNegativos(v, x));

            Console.WriteLine(SequenciaTribonacci(12));
        }
        */

        public static int Soma(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Soma(n - 1);
        }

        public static void NumerosNaturais(int n)
        {
            if (n >= 0)
            {
                NumerosNaturais(n - 1);
                Console.Write(n);
                Console.Write(", ");
            }
        }

        public static int MaiorElemento(int[] v, int n)
        {
            if (n == 1)
                return v[0];
            else
            {
                int x = MaiorElemento(v, n - 1);
                if (x > v[n - 1])
                    return x;
                else
                    return v[n - 1];
            }
        }

        public static int NumerosNegativos(int[] v, int n)
        {
            if (n == 1)
            {
                if (v[0] < 0)
                    return 1;
                else
                    return 0;
            }
            else
            {
                int x = NumerosNegativos(v, n - 1);
                if (v[n - 1] < 0)
                    return x + 1;
                else
                    return x;
            }
        }

        public static int SequenciaTribonacci(int N)
        {
            if(N == 1 || N == 2)
            {
                return 0;
            }
            else if(N == 3)
            {
                return 1;
            }
            else
            {
                return SequenciaTribonacci(N - 1) + SequenciaTribonacci(N - 2) + SequenciaTribonacci(N - 3);
            }
        }

    }
}

