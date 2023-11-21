using System;

namespace AEDs_CSharp_PUC_MG.Lista_PesquisaBinaria_ABB.Ex2
{
    public class Inteiro
    {
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Inteiro(int valor)
        {
            this.valor = valor;
        }

        public Inteiro()
        {
            valor = 0;
        }

        public void imprimir()
        {
            Console.WriteLine("Valor -> " + valor);
        }
    }
}