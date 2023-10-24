using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue_Flexivel.Ex2
{
    public class QueueArquivo
    {
        private CelulaArquivo frente;
        private CelulaArquivo tras;

        public QueueArquivo()
        {
            CelulaArquivo sentinela;

            sentinela = new CelulaArquivo();
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
            CelulaArquivo aux = frente.Proximo;

            while (aux != null)
            {
                tamanho++;
                aux = aux.Proximo;
            }
            return tamanho;
        }

        public void imprimirFila()
        {
            CelulaArquivo aux = frente.Proximo;

            if (!filaVazia())
            {

                while (aux != null)
                {
                    aux.Arquivo.imprimir();
                    aux = aux.Proximo;
                }
            }
            else
                throw new Exception("Fila vazia!");
        }

        public void enfileirar(string nome, int numeroPaginas)
        {
            CelulaArquivo novaCelula;
            Arquivo novo;

            novo = new Arquivo(nome, numeroPaginas);
            novaCelula = new CelulaArquivo(novo);

            tras.Proximo = novaCelula;
            tras = novaCelula;
        }


        public Arquivo desenfileirar()
        {
            CelulaArquivo celulaDesenfileirada;
            CelulaArquivo proximaCelula;

            if (!filaVazia())
            {
                celulaDesenfileirada = frente.Proximo;
                proximaCelula = celulaDesenfileirada.Proximo;
                frente.Proximo = proximaCelula;

                if (celulaDesenfileirada == tras)
                    tras = frente;

                return (celulaDesenfileirada.Arquivo);
            }
            else
                throw new Exception("Fila vazia!");
        }
    }
}