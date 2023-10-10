using System;

namespace AEDs_CSharp_PUC_MG.Lista_Stack_Flexivel
{
    public class Celula
    {
        private Item entrada;
        private Celula proximo;
        public Celula Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }
        public Item Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }
        public Celula()
        {
            entrada = new Item();
            proximo = null;
        }
        public Celula(Item entrada)
        {
            this.entrada = entrada;
            proximo = null;
        }
        public Celula(Item entrada, Celula proximo)
        {
            this.entrada = entrada;
            this.proximo = proximo;
        }
    }
}
