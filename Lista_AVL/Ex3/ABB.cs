using System;

namespace AEDs_CSharp_PUC_MG.Lista_AVL.Ex3
{
    public class ABB
    {
        private No raiz;

        public ABB()
        {
            raiz = null;
        }

        public Inteiro pesquisar(int chave)
        {
            return pesquisar(this.raiz, chave);
        }

        private Inteiro pesquisar(No raizSubarvore, int chave)
        {
            if (raizSubarvore == null)
                return null;
            else if (chave == raizSubarvore.Item.Valor)
                return raizSubarvore.Item;
            else if (chave > raizSubarvore.Item.Valor)
                return pesquisar(raizSubarvore.Direita, chave);
            else
                return pesquisar(raizSubarvore.Esquerda, chave);
        }

        public void inserir(Inteiro novo)
        {
            this.raiz = inserir(this.raiz, novo);
        }

        private No inserir(No raizSubarvore, Inteiro novo)
        {

            if (raizSubarvore == null)
                raizSubarvore = new No(novo);
            else if (novo.Valor == raizSubarvore.Item.Valor)
                throw new Exception("Não foi possível inserir o item na árvore: chave já inseriada anteriormente!");
            else if (novo.Valor < raizSubarvore.Item.Valor)
                raizSubarvore.Esquerda = inserir(raizSubarvore.Esquerda, novo);
            else
                raizSubarvore.Direita = inserir(raizSubarvore.Direita, novo);

            return balancear(raizSubarvore);
        }

        private No balancear(No raizSubarvore)
        {
            int fatorBalanceamento;
            int fatorBalanceamentoFilho;

            fatorBalanceamento = raizSubarvore.getFatorBalanceamento();

            if (fatorBalanceamento == 2)
            {
                fatorBalanceamentoFilho = raizSubarvore.Esquerda.getFatorBalanceamento();

                if (fatorBalanceamentoFilho == -1)
                {
                    raizSubarvore.Esquerda = rotacionarEsquerda(raizSubarvore.Esquerda);
                }
                raizSubarvore = rotacionarDireita(raizSubarvore);
            }
            else if (fatorBalanceamento == -2)
            {
                fatorBalanceamentoFilho = raizSubarvore.Direita.getFatorBalanceamento();

                if (fatorBalanceamentoFilho == 1)
                {
                    raizSubarvore.Direita = rotacionarDireita(raizSubarvore.Direita);
                }
                raizSubarvore = rotacionarEsquerda(raizSubarvore);
            }
            else
                raizSubarvore.setAltura();

            return raizSubarvore;
        }

        private No rotacionarDireita(No p)
        {
            No u = p.Esquerda;
            No filhoEsquerdaDireita = u.Direita;

            u.Direita = p;
            p.Esquerda = filhoEsquerdaDireita;

            p.setAltura();
            u.setAltura();

            return u;
        }

        private No rotacionarEsquerda(No p)
        {
            No z = p.Direita;
            No filhoDireitaEsquerda = z.Esquerda;

            z.Esquerda = p;
            p.Direita = filhoDireitaEsquerda;

            p.setAltura();
            z.setAltura();

            return z;
        }

        public void remover(int chaveRemover)
        {
            this.raiz = remover(this.raiz, chaveRemover);
        }

        private No remover(No raizSubarvore, int chaveRemover)
        {
            if (raizSubarvore == null)
                throw new Exception("Não foi possível remover o item da árvore: chave não encontrada!");
            else if (chaveRemover == raizSubarvore.Item.Valor)
            {
                if (raizSubarvore.Esquerda == null)
                    raizSubarvore = raizSubarvore.Direita;
                else if (raizSubarvore.Direita == null)
                    raizSubarvore = raizSubarvore.Esquerda;
                else
                    raizSubarvore.Esquerda = antecessor(raizSubarvore, raizSubarvore.Esquerda);
            }
            else if (chaveRemover > raizSubarvore.Item.Valor)
                raizSubarvore.Direita = remover(raizSubarvore.Direita, chaveRemover);
            else
                raizSubarvore.Esquerda = remover(raizSubarvore.Esquerda, chaveRemover);

            return balancear(raizSubarvore);
        }

        private No antecessor(No noRetirar, No raizSubarvore)
        {
            if (raizSubarvore.Direita != null)
                raizSubarvore.Direita = antecessor(noRetirar, raizSubarvore.Direita);
            else
            {
                noRetirar.Item = raizSubarvore.Item;
                raizSubarvore = raizSubarvore.Esquerda;
            }
            return balancear(raizSubarvore);
        }

        public void caminhamentoEmOrdem()
        {
            caminhamentoEmOrdem(this.raiz);
        }

        private void caminhamentoEmOrdem(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                caminhamentoEmOrdem(raizSubarvore.Esquerda);
                raizSubarvore.Item.imprimir();
                caminhamentoEmOrdem(raizSubarvore.Direita);
            }
        }

        public void caminhamentoPreOrdem()
        {
            caminhamentoPreOrdem(this.raiz);
        }

        private void caminhamentoPreOrdem(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                raizSubarvore.Item.imprimir();
                caminhamentoPreOrdem(raizSubarvore.Esquerda);
                caminhamentoPreOrdem(raizSubarvore.Direita);
            }
        }

        public void caminhamentoPosOrdem()
        {
            caminhamentoPosOrdem(this.raiz);
        }

        private void caminhamentoPosOrdem(No raizSubarvore)
        {
            if (raizSubarvore != null)
            {
                caminhamentoPosOrdem(raizSubarvore.Esquerda);
                caminhamentoPosOrdem(raizSubarvore.Direita);
                raizSubarvore.Item.imprimir();
            }
        }
    }
}