using System;
using System.Collections.Generic;

namespace AEDs_CSharp_PUC_MG.Lista_List.Ex1
{
    public class Ex1_ListaNativa
    {
        /*
        public static void Main(String[] args)
        {
            List<double> lista = new List<double>();
            int opcao;

            do
            {
                Menu();

                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirInicio(lista);
                        break;

                    case 2:
                        InserirFim(lista);
                        break;

                    case 3:
                        InserirPosicao(lista);
                        break;

                    case 4:
                        RemoverInicio(lista);
                        break;

                    case 5:
                        RemoverFim(lista);
                        break;

                    case 6:
                        RemoverPosicao(lista);
                        break;

                    case 7:
                        RemoverTempo(lista);
                        break;

                    case 8:
                        QuantasRepeticoes(lista);
                        break;

                    case 9:
                        MostrarTempos(lista);
                        break;

                    case 10:
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 10);
        }
        */

        public static void Menu()
        {
            Console.WriteLine("1 - Inserir um tempo no início da lista");
            Console.WriteLine("2 - Inserir um tempo no final da lista");
            Console.WriteLine("3 - Inserir um tempo em uma posição específica");
            Console.WriteLine("4 - Remover o primeiro tempo da lista");
            Console.WriteLine("5 - Remover o último tempo da lista");
            Console.WriteLine("6 - Remover um tempo de uma posição específica");
            Console.WriteLine("7 - Remover um tempo específico da lista");
            Console.WriteLine("8 - Pesquisar quantas vezes um determinado tempo consta na lista");
            Console.WriteLine("9 - Mostrar todos os tempos da lista");
            Console.WriteLine("10 - Encerrar o programa");
            Console.WriteLine();
        }

        public static void InserirInicio(List<double> lista)
        {
            Console.Write("Digite o tempo a ser inserido no início: ");
            double tempo = double.Parse(Console.ReadLine());
            lista.Insert(0, tempo);
            Console.WriteLine(tempo + " inserido no início");
            Console.WriteLine();
        }

        public static void InserirFim(List<double> lista)
        {
            Console.Write("Digite o tempo a ser inserido no fim: ");
            double tempo = double.Parse(Console.ReadLine());
            lista.Add(tempo);
            Console.WriteLine(tempo + " inserido no fim");
            Console.WriteLine();
        }

        public static void InserirPosicao(List<double> lista)
        {
            Console.Write("Digite o tempo a ser inserido: ");
            double tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite em qual posição será inserido: ");
            int posicao = int.Parse(Console.ReadLine());

            try
            {
                lista.Insert(posicao, tempo);
                Console.WriteLine("Tempo {0} inserido na posição {1}", tempo, posicao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Posição inválida!");
            }
            Console.WriteLine();
        }

        public static void RemoverInicio(List<double> lista)
        {
            Console.WriteLine("Tempo {0} removido do início", lista[0]);
            lista.RemoveAt(0);
            Console.WriteLine();
        }

        public static void RemoverFim(List<double> lista)
        {
            Console.WriteLine("Tempo {0} removido do fim", lista[lista.Count - 1]);
            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine();
        }

        public static void RemoverPosicao(List<double> lista)
        {
            Console.Write("Digite a posição a ser removida: ");
            int posicao = int.Parse(Console.ReadLine());

            try
            {
                lista.RemoveAt(posicao);
                Console.WriteLine("Tempo na posição {0} removido", posicao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Posição inválida!");
            }
            Console.WriteLine();
        }

        public static void RemoverTempo(List<double> lista)
        {
            Console.Write("Digite o tempo a ser removido: ");
            double removido = int.Parse(Console.ReadLine());

            foreach (double tempo in lista)
            {
                if (tempo == removido)
                {
                    Console.WriteLine("Tempo {0} removido", tempo);
                    lista.Remove(tempo);
                }
            }
            Console.WriteLine();
        }

        public static void QuantasRepeticoes(List<double> lista)
        {
            Console.Write("Digite o tempo a ser pesquisado: ");
            double procurado = double.Parse(Console.ReadLine());

            int cont = 0;

            foreach (double tempo in lista)
            {
                if (tempo == procurado)
                {
                    cont++;
                }
            }
            Console.WriteLine("O tempo {0} se repete {1} vez(es)", procurado, cont);
            Console.WriteLine();
        }

        public static void MostrarTempos(List<double> lista)
        {
            foreach (double tempo in lista)
            {
                Console.WriteLine(tempo.ToString("F"));
            }
            Console.WriteLine();
        }
    }
}