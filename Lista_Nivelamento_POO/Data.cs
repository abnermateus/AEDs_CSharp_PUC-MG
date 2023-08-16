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

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }
    }
}