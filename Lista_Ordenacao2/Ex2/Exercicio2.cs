using System;

namespace AEDs_CSharp_PUC_MG.Lista_Ordenacao2.Ex2
{
    public class Exercicio2
    {
        /*
        public static void Main(String[] args)
        {
            int[] vet = { 10, 1, 3, 20, 5, 6, 1, 4, 9, 2 };

            ImprimeVetor(vet);

            QuicksortCrescente(vet, 0, vet.Length - 1);
        }
        */

        public static void ImprimeVetor(int[] vet)
        {
            Console.Write("[");
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine("]");
        }

        public static int ParticaoCrescente(int[] vet, int inicio, int fim)
        {
            int meio = (inicio + fim) / 2;
            Troca(vet, meio, fim);

            int pivot = vet[fim];
            int part = inicio - 1;

            for (int i = inicio; i < fim; i++)
            {
                if (vet[i] <= pivot)
                {
                    part++;
                    Troca(vet, part, i);
                }
            }
            part++;
            Troca(vet, part, fim);
            ImprimeVetor(vet);
            return part;
        }

        public static void Troca(int[] vet, int i, int j)
        {
            int aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }

        public static void QuicksortCrescente(int[] vet, int esq, int dir)
        {
            int part;

            if (esq < dir)
            {
                part = ParticaoCrescente(vet, esq, dir);
                QuicksortCrescente(vet, esq, part - 1);
                QuicksortCrescente(vet, part + 1, dir);
            }
        }
    }
}