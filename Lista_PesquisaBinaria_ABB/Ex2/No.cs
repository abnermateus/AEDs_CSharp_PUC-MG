using System;

namespace AEDs_CSharp_PUC_MG.Lista_PesquisaBinaria_ABB.Ex2
{
    public class No
    {
        private Inteiro item;
        private No esquerda;
        private No direita;

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

        public No()
        {
            item = new Inteiro();
            esquerda = null;
            direita = null;
        }

        public No(Inteiro registro)
        {
            item = registro;
            esquerda = null;
            direita = null;
        }
    }
}