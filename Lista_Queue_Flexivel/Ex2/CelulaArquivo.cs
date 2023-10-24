using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel.Ex2
{
    public class CelulaArquivo
    {
        private Arquivo arquivo;
        private CelulaArquivo proximo;

        public Arquivo Arquivo
        {
            get { return arquivo; }
            set { arquivo = value; }
        }

        public CelulaArquivo Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public CelulaArquivo(Arquivo novo)
        {
            arquivo = novo;
            proximo = null;
        }

        public CelulaArquivo()
        {
            arquivo = new Arquivo();
            proximo = null;
        }
    }
}