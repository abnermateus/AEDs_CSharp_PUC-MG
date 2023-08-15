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
            */

            /*Ex3
            int numerador = 4, denominador = 1, N, sinal = 1;
            double soma = 0;

            Console.Write("Informe um valor limite para o denominador: ");
            N = int.Parse(Console.ReadLine());

            while (denominador <= N)
            {
                soma += sinal * (double)numerador / denominador;
                Console.WriteLine("{0} / {1} = {2}", numerador, denominador, (double)numerador / denominador);
                Console.WriteLine("Soma = {0}", soma);
                sinal *= -1;
                denominador += 2;
            }
            */

            /*Ex4
            int[] x = new int[5];
            int[] y = new int[5];
            int soma, produto;

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("Informe o valor de x{0}: ", i + 1);
                x[i] = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor de y{0}: ", i + 1);
                y[i] = int.Parse(Console.ReadLine());

                soma = x[i] + y[i];
                produto = x[i] * y[i];

                Console.WriteLine("Soma: {0} + {1} = {2}", x[i], y[i], soma);
                Console.WriteLine("Produto: {0} x {1} = {2}", x[i], y[i], produto);
            }

            Console.Write("Diferença: "); 
            
            for (int i = 0; i < x.Length; i++)
            {
                bool saoIguais = true;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] != y[j])
                    {
                        saoIguais = false;
                    }
                }
                if (!saoIguais)
                {
                    Console.Write("{0} ", x[i]);
                }
            }
        
            Console.Write("\nInterseção: ");

            for (int i = 0; i < x.Length; i++)
            {
                bool saoIguais = false;
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        saoIguais = true;
                    }
                }
                if (saoIguais)
                {
                    Console.Write("{0} ", x[i]);
                }
            }
            */
        }
    }
}