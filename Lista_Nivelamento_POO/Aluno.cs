using System;

namespace Lista_Nivelamento_POO
{
    public class Aluno
    {
        private string nome;
        private int idade;
        private double peso;
        private bool formando;
        private char sexo;

        public Aluno(string nome, int idade, double peso, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            formando = false;
            this.sexo = sexo;
        }

        public string GetNome()
        {
            return nome; 
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public double GetPeso()
        {
            return peso;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public bool GetFormando()
        {
            return formando;
        }

        public void SetFormando(bool formando)
        {
            this.formando = formando;
        }

        public char GetSexo()
        {
            return sexo;
        }
        
        public void SetSexo(char sexo)
        {
            this.sexo = sexo;
        }
    }
}