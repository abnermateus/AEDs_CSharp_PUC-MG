using System;


namespace AEDs_CSharp_PUC_MG.Lista_Queue
{
    public class Exercicio1_QueueVetor
    {
        /*
        public static void Main(String[] args)
        {
            QueueString pista = new QueueString(10);
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

        public static void ListarQtdAvioes(QueueString pista)
        {
            Console.WriteLine("Quantidade de aviões na pista: " + pista.quantidadeItensFila());
        }

        public static void AutorizarDecolagem(QueueString pista)
        {
            try
            {
                Console.WriteLine("Autorizando decolagem do avião: " + pista.desenfileirar() + "...");
                Console.WriteLine("Avião decolado!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void AdicionarAviao(QueueString pista)
        {
            Console.Write("Informe o identificador do avião: ");
            string id = Console.ReadLine();

            pista.enfileirar(id);
            Console.WriteLine("Avião " + id + " adicionado na fila de decolagem");
        }

        public static void ListarAvioes(QueueString pista)
        {
            try
            {
                Console.WriteLine("Aviões na fila de decolagem: ");
                pista.imprimir();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExibirPrimeiroAviao(QueueString pista)
        {
            try
            {
                Console.Write("Primeiro avião da fila: ");
                pista.imprimirPrimeiro();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}