using System;

namespace Lista_Nivelamento_POO
{
    public class Teste
    {
        /*
        public static void Main(String[] args)
        {
            AgendaTelefonica agenda = new AgendaTelefonica(50);
            int opcao;

            do
            {
                Console.WriteLine("Seja bem-vindo(a) à sua agenda telefônica!");
                Console.WriteLine("1 - Inserir contato");
                Console.WriteLine("2 - Buscar contato");
                Console.WriteLine("3 - Imprimir agenda");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do contato: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o celular do contato: ");
                        string celular = Console.ReadLine();
                        Console.Write("Digite o email do contato: ");
                        string email = Console.ReadLine();
                        Console.Write("Digite o dia do aniversário do contato: ");
                        int dia = int.Parse(Console.ReadLine());
                        Console.Write("Digite o mês do aniversário do contato: ");
                        int mes = int.Parse(Console.ReadLine());

                        Data aniversario = new Data(dia, mes);
                        Contato contato = new Contato(nome, celular, email, aniversario);
                        agenda.InserirContato(contato);
                        break;

                    case 2:
                        Console.Write("Digite o nome do contato: ");
                        string nomeBusca = Console.ReadLine();
                        Contato contatoBusca = agenda.BuscarContato(nomeBusca);
                        if (contatoBusca != null)
                        {
                            Console.WriteLine("\nNome: " + contatoBusca.Nome);
                            Console.WriteLine("Celular: " + contatoBusca.Celular);
                            Console.WriteLine("Email: " + contatoBusca.Email);
                            Console.WriteLine("Aniversário: " + contatoBusca.Aniversario.Dia + "/" + contatoBusca.Aniversario.Mes);
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado!");
                        }
                        break;

                    case 3:
                        agenda.ImprimirAgenda();
                        break;

                    case 4:
                        Console.WriteLine("Obrigado por utilizar a agenda telefônica!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 4);
        }
        */
    }
}