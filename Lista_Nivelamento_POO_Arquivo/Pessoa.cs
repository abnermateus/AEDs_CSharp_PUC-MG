using System;

namespace Lista_Nivelamento_POO_Arquivo
{
    public class Pessoa
    {
        private string dataNascimento;
        private double peso;
        private double altura;

        public Pessoa(string dataNascimento, double peso, double altura)
        {
            this.dataNascimento = dataNascimento;
            this.peso = peso;
            this.altura = altura;
        }

        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public int InformarIdadeAtual()
        {
            string[] data = dataNascimento.Split('/');
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);

            int idade = DateTime.Now.Year - ano;

            if (DateTime.Now.Month < mes || (DateTime.Now.Month == mes && DateTime.Now.Day < dia))
            {
                idade--;
            }

            return idade;
        }

        public double CalcularIMC()
        {
            return peso / (altura * altura);
        }
    }
}