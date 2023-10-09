using System;
using System.Collections.Generic;

namespace AEDs_CSharp_PUC_MG.Lista_Stack
{
    public class Exercicio1_StackNativa
    {
        /*
        static void Main(string[] args)
        {
            Stack<double> operacao = new Stack<double>();
            string op;
            double x, y;

            Console.Write("Informe a expressão em notação polonesa reversa: ");
            op = Console.ReadLine();

            for (int i = 0; i < op.Length; i++)
            {
                switch (op[i])
                {
                    case '+':
                        x = operacao.Peek();
                        operacao.Pop();
                        y = operacao.Peek();
                        operacao.Pop();
                        operacao.Push(x + y);
                        break;
                    case '-':
                        x = operacao.Peek();
                        operacao.Pop();
                        y = operacao.Peek();
                        operacao.Pop();

                        if (x < y)
                            operacao.Push(y - x);
                        else
                            operacao.Push(x - y);
                        break;
                    case '/':
                        x = operacao.Peek();
                        operacao.Pop();
                        y = operacao.Peek();
                        operacao.Pop();
                        if (x < y)
                            operacao.Push(y / x);
                        else
                            operacao.Push(x / y);
                        break;
                    case '*':
                        x = operacao.Peek();
                        operacao.Pop();
                        y = operacao.Peek();
                        operacao.Pop();
                        operacao.Push(x * y);
                        break;
                    default:
                        operacao.Push((double.Parse(op[i].ToString())));
                        break;
                }
            }
            Console.WriteLine("Resultado: " + operacao.Peek()); 
        }
        */
    }
}