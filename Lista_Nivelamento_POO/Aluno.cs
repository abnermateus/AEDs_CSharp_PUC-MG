using System;

namespace Lista_Nivelamento_POO
{
    public class Aluno
    {
        private string nome;
        private int idade;
        private Turma turma;
        private double peso;
        private bool formando;
        private char sexo;

        public Aluno(string nome, int idade, Turma turma, double peso, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.turma = turma;
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

        public Turma GetTurma()
        {
            return turma;
        }

        public void SetTurma(Turma turma)
        {
            this.turma = turma;
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

        public string ToString()
        {
            return "\nNome: " + nome + "\nIdade: " + idade + " anos" + turma.ToString() + "\nPeso: "  + peso + " kg" + "\nEstá formando: " + formando + "\nSexo: " + sexo;
        }
    }
}