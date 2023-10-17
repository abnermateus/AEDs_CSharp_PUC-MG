using System;
using System.Collections.Generic;

namespace AEDs_CSharp_PUC_MG.Lista_Queue
{
    public class Exercicio2_QueueNativa
    {
        /*
        public static void Main(String[] args)
        {
            Queue<Arquivo> fila = new Queue<Arquivo>();

            int opcao = 0;

            do
            {
                Console.WriteLine("1 - Inserir arquivo na fila de impressão");
                Console.WriteLine("2 - Executar impressão");
                Console.WriteLine("3 - Listar arquivos na fila de impressão");
                Console.WriteLine("4 - Sair");

                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        InserirArquivo(fila);
                        Console.WriteLine();
                        break;
                    case 2:
                        ExecutarImpressao(fila);
                        Console.WriteLine();
                        break;
                    case 3:
                        ListarArquivos(fila);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 4);
        }
        */

        public static void InserirArquivo(Queue<Arquivo> fila)
        {
            Console.Write("Digite o nome do arquivo: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número de páginas do arquivo: ");
            int numPaginas = int.Parse(Console.ReadLine());
            Arquivo arquivo = new Arquivo(nome, numPaginas);

            fila.Enqueue(arquivo);
        }

        public static void ExecutarImpressao(Queue<Arquivo> fila)
        {
            if (fila.Count > 0)
            {
                Arquivo arquivo = fila.Dequeue();
                Console.WriteLine("Imprimindo arquivo: " + arquivo.Nome);
            }
            else
            {
                Console.WriteLine("Não há arquivos para imprimir.");
            }
        }

        public static void ListarArquivos(Queue<Arquivo> fila)
        {
            if (fila.Count > 0)
            {
                Console.WriteLine("Arquivos na fila de impressão:");
                foreach (Arquivo arquivo in fila)
                {
                    Console.WriteLine(arquivo.Nome);
                }
            }
            else
            {
                Console.WriteLine("Não há arquivos na fila de impressão.");
            }
        }
    }
}