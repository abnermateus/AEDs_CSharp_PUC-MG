using System;

namespace Lista_Nivelamento_POO_Arquivo
{
    public class Jogador
    {
        private int numero;
        private string nome;
        private string posicao;

        public Jogador(int numero, string nome, string posicao)
        {
            this.numero = numero;
            this.nome = nome;
            this.posicao = posicao;
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
    }
}