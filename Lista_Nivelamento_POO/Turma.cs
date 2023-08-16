using System;

namespace Lista_Nivelamento_POO
{
    public class Turma
    {
        private int codigo;
        private int ano;

        public Turma(int codigo, int ano)
        {
            this.codigo = codigo;
            this.ano = ano;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int GetAno()
        {
            return ano;
        }

        public void SetAno(int ano)
        {
            this.ano = ano;
        }

        public string ToString()
        {
            return "\nTurma: " + codigo + "\nAno: " + ano;
        }
    }
}