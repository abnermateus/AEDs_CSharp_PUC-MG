using System;

namespace AEDs_CSharp_PUC_MG.Lista_Queue
{
    public class QueueString
    {
        private string[] fila;
        private int frente;
        private int tras;
        private int tamanho;

        public QueueString(int tamanho)
        {
            this.fila = new string[tamanho];
            this.frente = 0;
            this.tras = 0;
            this.tamanho = tamanho;
        }

        public void imprimirPrimeiro()
        {
            if (!filaVazia())
            {
                Console.WriteLine(fila[frente]);
            }
            else
            {
                throw new Exception("Fila vazia");
            }
        }

        public int quantidadeItensFila()
        {
            if (tras >= frente)
            {
                return tras - frente;
            }
            else
            {
                return tamanho - (frente - tras);
            }
        }

        public Boolean filaVazia()
        {
            if (frente == tras)
                return true;
            else
                return false;
        }

        public Boolean filaCheia()
        {
            if ((tras + 1) % tamanho == (frente % tamanho))
                return true;
            else
                return false;
        }

        public void enfileirar(string novo)
        {
            int posicao;

            if (!filaCheia())
            {
                posicao = tras % tamanho;
                fila[posicao] = novo;
                tras++;
            }
            else
            {
                throw new Exception("Fila cheia");
            }
        }

        public string desenfileirar()
        {
            string desenfileirado;
            int posicao;

            if (!filaVazia())
            {
                posicao = frente % tamanho;
                desenfileirado = fila[posicao];
                frente++;
                return desenfileirado;
            }
            else
            {
                throw new Exception("Fila vazia");
            }
        }

        public void imprimir()
        {
            int posicao;

            if (!filaVazia())
            {
                for (int i = frente; i < tras; i++)
                {
                    posicao = i % tamanho;
                    Console.WriteLine(fila[posicao]);
                }
            }
            else
                throw new Exception("Fila vazia");
        }
    }
}