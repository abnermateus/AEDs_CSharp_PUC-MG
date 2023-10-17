using System;
using System.Collections.Generic;

namespace AEDs_CSharp_PUC_MG.Lista_Queue
{
    public class Exercicio1_QueueNativa
    {
        /*
        public static void Main(String[] args)
        {
            Queue<string> pista = new Queue<string>();
            int opcao;

            do
            {
                Console.WriteLine("1 - Listar quantidade de aviões na pista");
                Console.WriteLine("2 - Autorizar a decolagem do primeiro avião da fila");
                Console.WriteLine("3 - Adicionar avião na fila de decolagem");
                Console.WriteLine("4 - Listar aviões na fila de decolagem");
                Console.WriteLine("5 - Exibir primeiro avião da fila de decolagem");
                Console.WriteLine("6 - Sair");

                Console.Write("Informe a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        ListarQtdAvioes(pista);
                        Console.WriteLine();
                        break;
                    case 2:
                        AutorizarDecolagem(pista);
                        Console.WriteLine();
                        break;
                    case 3:
                        AdicionarAviao(pista);
                        Console.WriteLine();
                        break;
                    case 4:
                        ListarAvioes(pista);
                        Console.WriteLine();
                        break;
                    case 5:
                        ExibirPrimeiroAviao(pista);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 6);
        }
        */

        public static void ListarQtdAvioes(Queue<string> pista)
        {
            Console.WriteLine("Quantidade de aviões na pista: " + pista.Count);
        }

        public static void AutorizarDecolagem(Queue<string> pista)
        {
            if (pista.Count > 0)
            {
                Console.WriteLine("Autorizando decolagem do avião: " + pista.Dequeue() + "...");
                Console.WriteLine("Avião decolado!");
            }
            else
            {
                Console.WriteLine("Não há aviões na pista!");
            }
        }

        public static void AdicionarAviao(Queue<string> pista)
        {
            Console.Write("Informe o identificador do avião: ");
            string id = Console.ReadLine();

            pista.Enqueue(id);
            Console.WriteLine("Avião " + id + " adicionado na fila de decolagem");
        }

        public static void ListarAvioes(Queue<string> pista)
        {
            Console.WriteLine("Aviões na fila de decolagem: ");

            foreach (string aviao in pista)
            {
                Console.WriteLine(aviao);
            }
        }

        public static void ExibirPrimeiroAviao(Queue<string> pista)
        {
            if (pista.Count > 0)
            {
                Console.WriteLine("Primeiro avião da fila: " + pista.Peek());
            }
            else
            {
                Console.WriteLine("Não há aviões na pista!");
            }
        }
    }
}