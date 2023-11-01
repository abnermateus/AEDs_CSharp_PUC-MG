using System;

namespace AEDs_CSharp_PUC_MG.Lista_List.Ex2
{
    public class Site
    {
        private string nome;
        private string link;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Link
        {
            get => link;
            set => link = value;
        }

        public Site(string nome, string link)
        {
            this.nome = nome;
            this.link = link;
        }
    }
}