using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue
{
    public class Arquivo
    {
        private string nome;
        private int numPaginas;

        public Arquivo(string nome, int numPaginas)
        {
            this.nome = nome;
            this.numPaginas = numPaginas;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumPaginas
        {
            get { return numPaginas; }
            set { numPaginas = value; }
        }
    }
}