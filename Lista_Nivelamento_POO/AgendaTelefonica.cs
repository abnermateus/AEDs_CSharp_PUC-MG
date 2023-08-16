using System;

namespace Lista_Nivelamento_POO
{
    public class AgendaTelefonica
    {
        private Contato[] agenda;
        private int quant;

        public AgendaTelefonica(int tamanho)
        {
            agenda = new Contato[tamanho];
            quant = 0;
        }

        public void InserirContato(Contato contato)
        {
            if (quant < agenda.Length)
            {
                agenda[quant] = contato;
                Console.WriteLine("Contato inserido com sucesso!");
                quant++;
            }
            else
            {
                Console.WriteLine("Agenda cheia!");
            }
        }

        public Contato BuscarContato(string nome)
        {
            for (int i = 0; i < quant; i++)
            {
                if (agenda[i].Nome == nome)
                {
                    return agenda[i];
                }
            }
            return null;
        }

        public void ImprimirAgenda()
        {
            if (quant == 0)
            {
                Console.WriteLine("Agenda vazia!");
                return;
            }

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Nome: " + agenda[i].Nome);
                Console.WriteLine("Celular: " + agenda[i].Celular);
                Console.WriteLine("Email: " + agenda[i].Email);
                Console.WriteLine("Aniversário: " + agenda[i].Aniversario.Dia + "/" + agenda[i].Aniversario.Mes);
            }
        }
    }
}