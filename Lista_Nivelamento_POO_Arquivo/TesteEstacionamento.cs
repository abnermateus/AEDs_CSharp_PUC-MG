using System;

namespace Lista_Nivelamento_POO_Arquivo
{
    public class TesteEstacionamento
    {
        public static void Main(String[] args)
        {
            int vagaOcupada;
            Estacionamento objEstacionamento = new Estacionamento("Estacionamento de AEDs", 10);
            vagaOcupada = objEstacionamento.estacionar("HKT0098");
            vagaOcupada = objEstacionamento.estacionar("OLP4290");
            vagaOcupada = objEstacionamento.estacionar("HJB0495");
            vagaOcupada = objEstacionamento.estacionar("OWB3904");

            Console.WriteLine("Ocupação do estacionamento após as chegadas de quatro clientes: ");
            objEstacionamento.exibirOcupacaoEstacionamento();

            vagaOcupada = objEstacionamento.obterVagaOcupada("HKT0098");
            Console.WriteLine("Veículo de placa HKT0098 estacionado na vaga " + vagaOcupada);

            objEstacionamento.retirarVeiculo("HKT0098");
            Console.WriteLine("Ocupação do estacionamento após a retirada do veículo de placa HKT0098: ");

            objEstacionamento.exibirOcupacaoEstacionamento();

            vagaOcupada = objEstacionamento.estacionar("HTP5619");
            vagaOcupada = objEstacionamento.estacionar("BOL4861");
            vagaOcupada = objEstacionamento.estacionar("HGT9436");

            Console.WriteLine("Ocupação do estacionamento após as chegadas de mais três clientes: ");
            objEstacionamento.exibirOcupacaoEstacionamento();

            Console.WriteLine("Este estacionamento apresenta {0} vagas livres.", objEstacionamento.obterNumVagasLivres());
            Console.ReadLine();
        }
    }
}

