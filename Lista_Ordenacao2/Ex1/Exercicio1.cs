using System;

namespace AEDs_CSharp_PUC_MG.Lista_Ordenacao2.Ex1
{
    public class Exercicio1
    {
        /*
        public static void Main(String[] args)
        {
            int[] vet;

            Console.Write("Informe o tamanho do vetor: ");
            vet = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = new Random().Next(0, 10);
            }

            switch (Menu())
            {
                case 1:
                    Console.WriteLine("\nVetor desordenado: ");
                    ImprimeVetor(vet);
                    QuicksortCrescente(vet, 0, vet.Length - 1);
                    Console.WriteLine("Vetor ordenado: ");
                    ImprimeVetor(vet);
                    break;
                case 2:
                    Console.WriteLine("\nVetor desordenado: ");
                    ImprimeVetor(vet);
                    QuicksortDecrescente(vet, 0, vet.Length - 1);
                    Console.WriteLine("Vetor ordenado: ");
                    ImprimeVetor(vet);
                    break;
                case 3:
                    Console.WriteLine("\nSaindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        */

        public static int Menu()
        {
            int op;

            Console.WriteLine("1 - Quicksort Crescente");
            Console.WriteLine("2 - Quicksort Decrescente");
            Console.WriteLine("3 - Sair\n");

            Console.Write("Informe a opção desejada: ");
            op = int.Parse(Console.ReadLine());

            return op;
        }

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
            int pivot = vet[fim];
            int part = inicio - 1;

            for (int i = inicio; i < fim; i++)
            {
                if (vet[i] <= pivot)
                {
                    part++;
                    int aux = vet[part];
                    vet[part] = vet[i];
                    vet[i] = aux;
                }
            }
            part++;
            Troca(vet, part, fim);
            return part;
        }

        public static int ParticaoDecrescente(int[] vet, int inicio, int fim)
        {
            int pivot = vet[fim];
            int part = inicio - 1;

            for (int i = inicio; i < fim; i++)
            {
                if (vet[i] >= pivot)
                {
                    part++;
                    Troca(vet, part, i);
                }
            }
            part++;
            Troca(vet, part, fim);
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

        public static void QuicksortDecrescente(int[] vet, int esq, int dir)
        {
            int part;

            if (esq < dir)
            {
                part = ParticaoDecrescente(vet, esq, dir);
                QuicksortDecrescente(vet, esq, part - 1);
                QuicksortDecrescente(vet, part + 1, dir);
            }
        }
    }
}