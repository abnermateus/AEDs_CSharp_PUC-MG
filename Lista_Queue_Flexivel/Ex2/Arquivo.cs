using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel.Ex2
{
    public class Arquivo
    {
        private string nome;
        private int numeroPaginas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        public Arquivo(string nome, int numeroPaginas)
        {
            this.nome = nome;
            this.numeroPaginas = numeroPaginas;
        }

        public Arquivo()
        {
            nome = "";
            numeroPaginas = 0;
        }

        public void imprimir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Número de páginas: " + numeroPaginas);
        }
    }
}