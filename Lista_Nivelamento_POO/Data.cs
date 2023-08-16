using System;

namespace Lista_Nivelamento_POO
{
    public class Data
    {
        private int dia;
        private int mes;

        public Data(int dia, int mes)
        {
            this.dia = dia;
            this.mes = mes;
        }

        public int GetDia()
        {
            return dia;
        }

        public void SetDia(int dia)
        {
            this.dia = dia;
        }

        public void SetMes(int mes)
        {
            this.mes = mes;
        }

        public int GetMes()
        {
            return mes;
        }

    }
}