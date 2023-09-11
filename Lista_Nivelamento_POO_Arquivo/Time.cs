using System;
using System.Text;

namespace Lista_Nivelamento_POO_Arquivo
{
    public class Time
    {
        private string nome;
        private Jogador[] titulares;
        private int quantTitulares;
        private Jogador[] reservas;
        private int quantReservas;

        public Time(string nome)
        {
            this.nome = nome;
            titulares = new Jogador[11];
            reservas = new Jogador[12];
            quantTitulares = 0;
            quantReservas = 0;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool AdicionarTitular(Jogador jogador)
        {
            if (quantTitulares < 11)
            {
                titulares[quantTitulares] = jogador;
                quantTitulares++;
                return true;
            }
            return false;
        }

        public bool AdicionarReserva(Jogador jogador)
        {
            if (quantReservas < 12)
            {
                reservas[quantReservas] = jogador;
                quantReservas++;
                return true;
            }
            return false;
        }

        public bool SubstituirTitular(string nome, Jogador jogador)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == nome)
                {
                    titulares[i] = jogador;
                    return true;
                }
            }
            return false;
        }

        public bool SubstituirReserva(string nome, Jogador jogador)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == nome)
                {
                    reservas[i] = jogador;
                    return true;
                }
            }
            return false;
        }

        public bool ConsultarTitular(string nome)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (titulares[i].Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ConsultarReserva(string nome)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (reservas[i].Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }

        public void ExcluirTitular(string nome)
        {
            for (int i = 0; i < quantTitulares; i++)
            {
                if (ConsultarTitular(nome))
                {
                    for (int j = i; j < quantTitulares - 1; j++)
                    {
                        titulares[j] = titulares[j + 1];
                    }

                    quantTitulares--;
                }
            }
        }

        public void ExcluirReserva(string nome)
        {
            for (int i = 0; i < quantReservas; i++)
            {
                if (ConsultarReserva(nome))
                {
                    for (int j = i; j < quantReservas - 1; j++)
                    {
                        reservas[j] = reservas[j + 1];
                    }
                    quantReservas--;
                }
            }
        }

        public void GerarArqTime(string diretorio)
        {
            StreamWriter arq = new StreamWriter(diretorio, false, Encoding.UTF8);

            arq.WriteLine("Nome do time: " + nome);
            arq.WriteLine("Titulares: ");

            foreach (Jogador jogador in titulares)
            {
                arq.WriteLine("Nome: " + jogador.Nome + " - Número: " + jogador.Numero + " - Posição: " + jogador.Posicao);
            }

            arq.WriteLine("\nReservas: ");

            foreach (Jogador jogador in reservas)
            {
                arq.WriteLine("Nome: " + jogador.Nome + " - Número: " + jogador.Numero + " - Posição: " + jogador.Posicao);
            }

            arq.Close();
        }
    }
}