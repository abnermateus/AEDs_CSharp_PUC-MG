using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel
{
    public class CelulaAviao
    {
        private Identificador aviao;
        private CelulaAviao proximo;

        public Identificador Aviao
        {
            get { return aviao; }
            set { aviao = value; }
        }

        public CelulaAviao Proximo
        {
            get { return proximo; }
            set { proximo = value; }
        }

        public CelulaAviao(Identificador novo)
        {
            aviao = novo;
            proximo = null;
        }

        public CelulaAviao()
        {
            aviao = new Identificador();
            proximo = null;
        }
    }
}
