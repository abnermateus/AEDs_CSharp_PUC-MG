using System;
namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel.Ex2
{
    public class Exercicio2
    {
        /*
        public static void Main(String[] args)
        {
            QueueArquivo fila = new QueueArquivo();
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
        public static void InserirArquivo(QueueArquivo fila)
        {
            Console.Write("Digite o nome do arquivo: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número de páginas do arquivo: ");
            int numPaginas = int.Parse(Console.ReadLine());
            fila.enfileirar(nome, numPaginas);
        }

        public static void ExecutarImpressao(QueueArquivo fila)
        {
            if (!fila.filaVazia())
            {
                Arquivo arquivo = fila.desenfileirar();
                Console.WriteLine("Imprimindo arquivo: " + arquivo.Nome);
            }
            else
            {
                Console.WriteLine("Não há arquivos para imprimir.");
            }
        }

        public static void ListarArquivos(QueueArquivo fila)
        {
            if (!fila.filaVazia())
            {
                Console.WriteLine("Arquivos na fila de impressão");
                fila.imprimirFila();
            }
            else
            {
                Console.WriteLine("Não há arquivos na fila de impressão.");
            }
        }
    }
}