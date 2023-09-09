using System;
using System.Text;

namespace Lista_Nivelamento_POO_Arquivo
{
    public class TestePessoa
    {
        /*
        public static void Main(String[] args)
        {
            StreamWriter arqEscr = new StreamWriter("Lista_Nivelamento_POO_Arquivo//pessoas.txt", false, Encoding.UTF8);
            StreamReader arqLeit;

            Pessoa p1 = new Pessoa("01/01/2000", 70, 1.70);
            Pessoa p2 = new Pessoa("01/01/2000", 80, 1.80);
            Pessoa p3 = new Pessoa("01/01/2000", 90, 1.90);
            Pessoa p4 = new Pessoa("01/01/2000", 100, 2.0);
            Pessoa[] pessoas = { p1, p2, p3, p4 };
            
            string linha = "";
            string[] dados;
       
            foreach (Pessoa pessoa in pessoas)
            {
                arqEscr.Write(pessoa.DataNascimento + "; ");
                arqEscr.Write(pessoa.InformarIdadeAtual() + "; ");
                arqEscr.Write(pessoa.Peso + "; ");
                arqEscr.Write(pessoa.Altura + "; ");
                arqEscr.Write(pessoa.CalcularIMC().ToString("N1"));
                arqEscr.WriteLine();
            }

            arqEscr.Close();
            arqLeit = new StreamReader("Lista_Nivelamento_POO_Arquivo//pessoas.txt", Encoding.UTF8);

            try
            {
                do
                {
                    linha = arqLeit.ReadLine();

                    if (linha != null)
                    {
                        dados = linha.Split(';');
                        Console.WriteLine("Data de Nascimento: " + dados[0]);
                        Console.WriteLine("Idade:" + dados[1] + " anos");
                        Console.WriteLine("Peso:" + dados[2] + " kg");
                        Console.WriteLine("Altura:" + dados[3] + " m");
                        Console.WriteLine("IMC: " + (Convert.ToDouble(dados[4])));
                        Console.WriteLine();
                    }
                } while (linha != null);

                arqLeit.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
        */
    }
}