using System;

namespace AEDs_CSharp_PUC_MG.Lista_PesquisaBinaria_ABB.Ex1
{
    public class PesquisaBinaria
    {
        /*
        public static void Main(String[] args)
        {
            int[] vet;

            Console.Write("Digite a quantidade de elementos do vetor: ");
            vet = new int[int.Parse(Console.ReadLine())];

            Console.Write("Digite os elementos do vetor: ");

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o elemento procurado: ");
            int procurado = int.Parse(Console.ReadLine());

            Console.Write("Posição do elemento procurado: " + PesquisaBinariaRecursiva(vet, procurado));
        }
        */

        public static int PesquisaBinariaRecursiva(int[] vet, int x)
        {
            return PesquisaBinariaRecursiva(vet, x, 0, (vet.Length - 1));
        }

        public static int PesquisaBinariaRecursiva(int[] vet, int x, int esq, int dir)
        {
            int resp;
            int meio = (esq + dir) / 2;

            if (esq > dir)
            {
                resp = -1;
            }
            else if (x == vet[meio])
            {
                resp = meio;
            }
            else if (x > vet[meio])
            {
                resp = PesquisaBinariaRecursiva(vet, x, meio + 1, dir);
            }
            else
            {
                resp = PesquisaBinariaRecursiva(vet, x, esq, meio - 1);
            }

            return resp;
        }
    }
}
