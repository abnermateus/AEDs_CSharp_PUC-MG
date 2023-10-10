using System;

namespace AEDs_CSharp_PUC_MG.Lista_Stack_Flexivel
{
    public class Item
    {
        private double entrada;
        
        public Double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        public Item(double entrada)
        {
            this.entrada = entrada;
        }

        public Item()
        {
            entrada = 0.0;
        }
    }
}