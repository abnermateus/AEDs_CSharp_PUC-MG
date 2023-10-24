using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel
{
    public class QueueIdentificador
    {
        private CelulaAviao frente;
        private CelulaAviao tras;

        public QueueIdentificador()
        {
            CelulaAviao sentinela;

            sentinela = new CelulaAviao();
            frente = sentinela;
            tras = sentinela;
        }

        public Boolean filaVazia()
        {
            if (frente == tras)
                return true;
            else
                return false;
        }

        public int tamanhoFila()
        {
            int tamanho = 0;
            CelulaAviao aux = frente.Proximo;

            while (aux != null)
            {
                tamanho++;
                aux = aux.Proximo;
            }
            return tamanho;
        }

        public void imprimirFila()
        {
            CelulaAviao aux = frente.Proximo;

            if (!filaVazia())
            {

                while (aux != null)
                {
                    aux.Aviao.imprimir();
                    aux = aux.Proximo;
                }
            }
            else
                throw new Exception("Fila vazia!");
        }

        public void imprimirPrimeiro()
        {
            if (!filaVazia())
                frente.Proximo.Aviao.imprimir();
            else
                throw new Exception("Fila vazia!");
        }

        public void enfileirar(Identificador novo)
        {
            CelulaAviao novaCelula;

            novaCelula = new CelulaAviao(novo);

            tras.Proximo = novaCelula;
            tras = novaCelula;
        }

        public Identificador desenfileirar()
        {
            CelulaAviao celulaDesenfileirada;
            CelulaAviao proximaCelula;

            if (!filaVazia())
            {
                celulaDesenfileirada = frente.Proximo;
                proximaCelula = celulaDesenfileirada.Proximo;
                frente.Proximo = proximaCelula;

                if (celulaDesenfileirada == tras)
                    tras = frente;

                return (celulaDesenfileirada.Aviao);
            }
            else
                throw new Exception("Fila vazia!");
        }
    }
}