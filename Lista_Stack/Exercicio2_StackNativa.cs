using System;
using System.Collections.Generic;

namespace AEDs_CSharp_PUC_MG.Lista_Stack
{
    public class Exercicio2_StackNativa
    {
        /*
        static void Main(String[] args)
        {
            Stack<string> sequencia = new Stack<string>();
            string entrada;

            Console.Write("Informe a sequência de parênteses e colchetes: ");
            entrada = Console.ReadLine();

            if (entrada.Length % 2 != 0)
            {
                Console.WriteLine("Sequência mal formada!");
                return;
            }
            
            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] == '(' || entrada[i] == '[')
                {
                    sequencia.Push(entrada[i].ToString());
                }
                else
                {
                    if (sequencia.Peek() == "(" && entrada[i] == ')')
                    {
                        sequencia.Pop();
                    }
                    else if (sequencia.Peek() == "[" && entrada[i] == ']')
                    {
                        sequencia.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Sequência mal formada!");
                        return;
                    }
                }
            }
            Console.WriteLine("Sequência bem formada!");
        }
        */
    }
}