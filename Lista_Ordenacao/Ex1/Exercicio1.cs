using System;

namespace AEDs_CSharp_PUC_MG.Lista_Ordenacao.Ex1
{
    public class Exercicio1
    {
        /*
        public static void Main(String[] args)
        {
            int op1;
            char op2;
            int[] vet;

            MenuMetodo();
            op1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            MenuOrdem();
            op2 = char.Parse(Console.ReadLine());

            Console.Write("Informe o tamanho do vetor: ");
            vet = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = new Random().Next(0, 100);
            }

            Console.WriteLine("Vetor desordenado: ");
            ImprimeVetor(vet);

            switch (op1)
            {
                case 1:
                    switch (op2)
                    {
                        case 'C':
                            SelecaoCrescente(vet);
                            break;

                        case 'D':
                            SelecaoDecrescente(vet);
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;
                case 2:
                    switch (op2)
                    {
                        case 'C':
                            BubblesortCrescente(vet);
                            break;

                        case 'D':
                            BubblesortDecrescente(vet);
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;
                case 3:
                    switch (op2)
                    {
                        case 'C':
                            InsercaoCrescente(vet);
                            break;

                        case 'D':
                            InsercaoDecrescente(vet);
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Vetor ordenado: ");
            ImprimeVetor(vet);
        }
        */

        public static void MenuMetodo()
        {
            Console.WriteLine("Escolha o método de ordenação:");

            Console.WriteLine("1 - Seleção");
            Console.WriteLine("2 - Bubble Sort");
            Console.WriteLine("3 - Inserção");
            Console.WriteLine("4 - Sair");
            Console.Write("\nOpção: ");
        }

        public static void MenuOrdem()
        {
            Console.WriteLine("Escolha a ordem de ordenação (crescente ou decrescente):");

            Console.WriteLine("C - Crescente");
            Console.WriteLine("D - Decrescente");
            Console.Write("\nOpção: ");
        }

        public static void ImprimeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();
        }

        public static void SelecaoCrescente(int[] vet)
        {
            for (int i = 0; i < (vet.Length - 1); i++)
            {
                int menor = i;

                for (int j = (i + 1); j < vet.Length; j++)
                {
                    if (vet[menor] > vet[j])
                    {
                        menor = j;
                    }
                }
                int aux = vet[i];
                vet[i] = vet[menor];
                vet[menor] = aux;
            }
        }

        public static void SelecaoDecrescente(int[] vet)
        {
            for (int i = 0; i < (vet.Length - 1); i++)
            {
                int menor = i;

                for (int j = (i + 1); j < vet.Length; j++)
                {
                    if (vet[menor] < vet[j])
                    {
                        menor = j;
                    }
                }
                int aux = vet[i];
                vet[i] = vet[menor];
                vet[menor] = aux;
            }
        }

        public static void BubblesortCrescente(int[] vet)
        {
            for (int i = vet.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        int aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                    }
                }
            }
        }

        public static void BubblesortDecrescente(int[] vet)
        {
            for (int i = vet.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] < vet[j + 1])
                    {
                        int aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                    }
                }
            }
        }

        public static void InsercaoCrescente(int[] vet)
        {
            for (int i = 1; i < vet.Length; i++)
            {
                int aux = vet[i];
                int j = i - 1;

                while ((j >= 0) && (vet[j] > aux))
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = aux;
            }
        }

        public static void InsercaoDecrescente(int[] vet)
        {
            for (int i = 1; i < vet.Length; i++)
            {
                int aux = vet[i];
                int j = i - 1;

                while ((j >= 0) && (vet[j] < aux))
                {
                    vet[j + 1] = vet[j];
                    j--;
                }
                vet[j + 1] = aux;
            }
        }
    }
}