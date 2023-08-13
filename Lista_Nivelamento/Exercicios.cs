using System;

namespace Lista_Nivelamento
{
    public class Exercicios
    {
        public static void Main(string[] args)
        {
            /*Ex1
            double[,] matriz = new double[12, 4];
            double[] total_mensais = new double[12];
            double[] total_semanais = new double[4];
            double valor_total = 0, melhor_semana = 0;
            int semana = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Mês {0}", i + 1);

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Semana {0}: ", j + 1);
                    matriz[i, j] = double.Parse(Console.ReadLine());
                    total_semanais[j] += matriz[i, j];
                    total_mensais[i] += matriz[i, j];
                }
                Console.WriteLine("Vendas do mês {0} = R$ {1}", i + 1, total_mensais[i]);
                valor_total += total_mensais[i];
                Console.WriteLine();
            }

            melhor_semana = total_semanais[0];

            for (int j = 0; j < 4; j++)
            {
                if (total_semanais[j] > melhor_semana)
                {
                    melhor_semana = total_semanais[j];
                    semana = j;
                }
            }
            Console.WriteLine("Vendas totais = R$ {0}", valor_total);
            Console.WriteLine("A melhor semana de vendas foi a {0}ª semana", semana + 1);
            */

            /*Ex2
             int numeroAtual, numeroAnterior = 0, sequencia = 0, maiorSequencia = 0;
            Console.WriteLine("Informe uma sequência de números inteiros positivos (para finalizar, digite -1): ");
           
            do
            {
                numeroAtual = int.Parse(Console.ReadLine());

                if (numeroAtual > numeroAnterior)
                {
                    sequencia++;
                }
                else
                {
                    if (sequencia > maiorSequencia)
                    {
                        maiorSequencia = sequencia;
                    }
                    sequencia = 1;
                }

                numeroAnterior = numeroAtual;
            } while (numeroAtual != -1);

            Console.WriteLine("A maior sequência crescente possui {0} números", maiorSequencia);
        }
        */

        int numerador = 4, denominador = 1, N;
        double soma = 0;

        Console.Write("Informe um valor ímpar limite para o denominador: ");
        N = int.Parse(Console.ReadLine());


        for (int i = 0; i < 20; i++)
        {
            soma += (double)numerador / denominador;
            denominador += 2;
        }


    }
}