using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel
{
    public class Identificador
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Identificador(string id)
        {
            this.id = id;
        }

        public Identificador()
        {
            id = "";
        }

        public void imprimir()
        {
            Console.WriteLine(id);
        }
    }
}