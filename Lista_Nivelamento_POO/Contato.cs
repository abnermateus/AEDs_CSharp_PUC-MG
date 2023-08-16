using System;

namespace Lista_Nivelamento_POO
{
    public class Contato
    {
        private string nome;
        private string celular;
        private string email;
        private Data aniversario;

        public Contato(string nome, string celular, string email, Data aniversario)
        {
            this.nome = nome;
            this.celular = celular;
            this.email = email;
            this.aniversario = aniversario;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Data Aniversario
        {
            get { return aniversario; }
            set { aniversario = value; }
        }
    }
}