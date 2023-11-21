using System;

namespace AEDs_CSharp_PUC_MG.Lista_PesquisaBinaria_ABB.Ex2
{
    public class Program
    {
        /*
        public static void Main(String[] args)
        {
            ABB arvore = new ABB();
            int opcao = 0;

            do
            {
                Menu();
                Console.Write("\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        inserir(arvore);
                        break;
                    case 2:
                        remover(arvore);
                        break;
                    case 3:
                        pesquisar(arvore);
                        break;
                    case 4:
                        maior(arvore);
                        break;
                    case 5:
                        menor(arvore);
                        break;
                    case 6:
                        central(arvore);
                        break;
                    case 7:
                        posOrdem(arvore);
                        break;
                    case 8:
                        preOrdem(arvore);
                        break;
                    case 9:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 9);
        }
        */

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("1 - Inserir um número na árvore binária de busca");
            Console.WriteLine("2 - Remover um número da árvore binária de busca");
            Console.WriteLine("3 - Pesquisar um número na árvore binária de busca");
            Console.WriteLine("4 - Mostrar o maior elemento da árvore binária de busca");
            Console.WriteLine("5 - Mostrar o menor elemento da árvore de pesquisa de busca");
            Console.WriteLine("6 - Mostrar todos os elementos da árvore, usando o caminhamento central");
            Console.WriteLine("7 - Mostrar todos os elementos da árvore, usando o caminhamento pós-ordem");
            Console.WriteLine("8 - Mostrar todos os elementos da árvore, usando o caminhamento pré-ordem");
            Console.WriteLine("9 - Sair");
        }

        public static void inserir(ABB arvore)
        {
            Console.Write("Digite o valor a ser inserido: ");
            int valor = int.Parse(Console.ReadLine());

            arvore.inserir(new Inteiro(valor));

            Console.WriteLine("Valor {0} inserido com sucesso!", valor);
        }

        public static void remover(ABB arvore)
        {
            Console.Write("Digite o valor a ser removido: ");
            int valor = int.Parse(Console.ReadLine());

            try
            {
                arvore.remover(valor);
                Console.WriteLine("Valor {0} removido com sucesso!", valor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void pesquisar(ABB arvore)
        {
            Console.Write("Digite o valor a ser pesquisado: ");
            int valor = int.Parse(Console.ReadLine());

            Inteiro item = arvore.pesquisar(valor);
            if (item != null)
                Console.WriteLine("Item encontrado: " + item.Valor);
            else
                Console.WriteLine("Item não encontrado!");
        }

        public static void maior(ABB arvore)
        {
            Console.WriteLine("Maior elemento da árvore: " + arvore.maiorElemento());
        }

        public static void menor(ABB arvore)
        {
            Console.WriteLine("Menor elemento da árvore: " + arvore.menorElemento());
        }

        public static void central(ABB arvore)
        {
            Console.WriteLine("Caminhamento central: ");
            arvore.caminhamentoEmOrdem();
        }

        public static void posOrdem(ABB arvore)
        {
            Console.WriteLine("Caminhamento pós-ordem: ");
            arvore.caminhamentoPosOrdem();
        }

        public static void preOrdem(ABB arvore)
        {
            Console.WriteLine("Caminhamento pré-ordem: ");
            arvore.caminhamentoPreOrdem();
        }
    }
}