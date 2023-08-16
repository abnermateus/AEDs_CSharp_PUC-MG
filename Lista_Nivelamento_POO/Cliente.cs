using System;

namespace Lista_Nivelamento_POO
{
    public class Cliente
    {
        public int codigo;
        private string nome;
        private bool eClienteEspecial;
        private double limiteCredito;

        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            eClienteEspecial = false;
            limiteCredito = 0;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public bool GetEClienteEspecial()
        {
            return eClienteEspecial;
        }

        public void SetEClienteEspecial(bool eClienteEspecial)
        {
            this.eClienteEspecial = eClienteEspecial;
        }

        public double GetLimiteCredito()
        {
            return limiteCredito;
        }

        public void SetLimiteCredito(double limiteCredito)
        {
            this.limiteCredito = limiteCredito;
        }

        public bool AtualizarLimiteCredito(double limiteCredito)
        {
            if (eClienteEspecial)
            {
                this.limiteCredito = limiteCredito;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void AtualizarCategoria(bool eClienteEspecial)
        {
            this.eClienteEspecial = eClienteEspecial;

            if(eClienteEspecial == false)
            {
                limiteCredito = 0;
            }
        }
    }
}