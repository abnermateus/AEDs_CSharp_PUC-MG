using System;

namespace AEDs_CSharp_PUC_MG.Lista_AVL.Ex3
{
    public class No
    {
        private Inteiro item;
        private No esquerda;
        private No direita;
        private int altura;

        public Inteiro Item
        {
            get { return item; }
            set { item = value; }
        }

        public No Esquerda
        {
            get { return esquerda; }
            set { esquerda = value; }
        }

        public No Direita
        {
            get { return direita; }
            set { direita = value; }
        }

        public int Altura
        {
            get { return altura; }
        }

        public No()
        {
            item = new Inteiro();
            esquerda = null;
            direita = null;
            altura = 0;
        }

        public No(Inteiro registro)
        {
            item = registro;
            esquerda = null;
            direita = null;
            altura = 0;
        }

        public void setAltura()
        {
            int alturaEsq, alturaDir;

            if (this.direita == null)
                alturaDir = -1;
            else
                alturaDir = this.direita.Altura;

            if (this.esquerda == null)
                alturaEsq = -1;
            else
                alturaEsq = this.esquerda.Altura;

            if (alturaEsq > alturaDir)
                this.altura = alturaEsq + 1;
            else
                this.altura = alturaDir + 1;
        }

        public int getFatorBalanceamento()
        {
            int alturaEsq, alturaDir;

            if (this.direita == null)
                alturaDir = -1;
            else
                alturaDir = this.direita.Altura;

            if (this.esquerda == null)
                alturaEsq = -1;
            else
                alturaEsq = this.esquerda.Altura;

            return (alturaEsq - alturaDir);
        }
    }
}