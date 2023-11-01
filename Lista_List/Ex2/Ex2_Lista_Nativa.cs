using System;

namespace AEDs_CSharp_PUC_MG.Lista_List.Ex2
{
    public class Ex2_Lista_Nativa
    {
        /*
        public static void Main(String[] args)
        {
            List<Site> lista = new List<Site>();
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
                        MostrarSites(lista);
                        break;

                    case 8:
                        Console.WriteLine("Encerrando o programa...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 8);
        }
        */

        public static void Menu()
        {
            Console.WriteLine("1 - Inserir um site no início da lista");
            Console.WriteLine("2 - Inserir um site no final da lista");
            Console.WriteLine("3 - Inserir um site em uma posição específica");
            Console.WriteLine("4 - Remover o primeiro site da lista");
            Console.WriteLine("5 - Remover o último site da lista");
            Console.WriteLine("6 - Remover um site de uma posição específica");
            Console.WriteLine("7 - Mostrar todos os tempos da lista");
            Console.WriteLine("8 - Encerrar o programa");
            Console.WriteLine();
        }

        public static void InserirInicio(List<Site> lista)
        {
            Console.Write("Digite o nome do site a ser inserido no início: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o link do site a ser inserido no início: ");
            string link = Console.ReadLine();

            Site site = new Site(nome, link);

            lista.Insert(0, site);
            Console.WriteLine(site.Nome + " inserido no início");
            Console.WriteLine();
        }

        public static void InserirFim(List<Site> lista)
        {
            Console.Write("Digite o nome do site a ser inserido no fim: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o link do site a ser inserido no fim: ");
            string link = Console.ReadLine();

            Site site = new Site(nome, link);

            lista.Add(site);
            Console.WriteLine(site.Nome + " inserido no fim");
            Console.WriteLine();
        }

        public static void InserirPosicao(List<Site> lista)
        {
            Console.Write("Digite o nome do site a ser inserido: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o link do site a ser inserido: ");
            string link = Console.ReadLine();

            Site site = new Site(nome, link);

            Console.Write("Digite em qual posição será inserido: ");
            int posicao = int.Parse(Console.ReadLine());

            try
            {
                lista.Insert(posicao, site);
                Console.WriteLine("Site {0} inserido na posição {1}", site.Nome, posicao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Posição inválida!");
            }
            Console.WriteLine();
        }

        public static void RemoverInicio(List<Site> lista)
        {
            Console.WriteLine("Site {0} removido do início", lista[0].Nome);
            lista.RemoveAt(0);
            Console.WriteLine();
        }

        public static void RemoverFim(List<Site> lista)
        {
            Console.WriteLine("Site {0} removido do fim", lista[lista.Count - 1].Nome);
            lista.RemoveAt(lista.Count - 1);
            Console.WriteLine();
        }

        public static void RemoverPosicao(List<Site> lista)
        {
            Console.Write("Digite a posição a ser removida: ");
            int posicao = int.Parse(Console.ReadLine());

            try
            {
                lista.RemoveAt(posicao);
                Console.WriteLine("Site na posição {0} removido", posicao);
            }
            catch (Exception e)
            {
                Console.WriteLine("Posição inválida!");
            }
            Console.WriteLine();
        }

        public static void MostrarSites(List<Site> lista)
        {
            foreach (Site site in lista)
            {
                Console.WriteLine(site.Nome);
            }
            Console.WriteLine();
        }

    }
}