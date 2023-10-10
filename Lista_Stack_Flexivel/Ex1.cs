using System;

namespace AEDs_CSharp_PUC_MG.Lista_Stack_Flexivel
{
    public class Ex1
    {
        /*
        public static void Main(String[] args)
        {
            Stack operacao = new Stack();
            string op;
            double x, y;

            Console.Write("Informe a expressão em notação polonesa reversa: ");
            op = Console.ReadLine();

            for (int i = 0; i < op.Length; i++)
            {
                switch (op[i])
                {
                    case '+':
                        x = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        y = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        operacao.empilhar(new Item(x + y));
                        break;
                    case '-':
                        x = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        y = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();

                        if (x < y)
                            operacao.empilhar(new Item(y - x));
                        else
                            operacao.empilhar(new Item(x - y));
                        break;
                    case '/':
                        x = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        y = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        if (x < y)
                            operacao.empilhar(new Item(y / x));
                        else
                            operacao.empilhar(new Item(x / y));
                        break;
                    case '*':
                        x = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        y = operacao.consultarTopo().Entrada;
                        operacao.desempilhar();
                        operacao.empilhar(new Item(x * y));
                        break;
                    default:
                        operacao.empilhar(new Item((double.Parse(op[i].ToString()))));
                        break;
                }
            }
            Console.WriteLine("Resultado: " + operacao.consultarTopo().Entrada);
        }
        */
    }
}