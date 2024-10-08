/*
 **********TARGET TESTE***********************


2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 
valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, 
informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

 */

using System;

namespace TargetTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = 0;
            int prox_val = 1;
            int val_ant = 0;

            Console.WriteLine("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            while(prox_val < valor)
            {
                val_ant = prox_val;
                prox_val = fibonacci + prox_val;
                fibonacci = val_ant;
            }

            if(prox_val == valor)
            {
                Console.WriteLine("O Numero pertence a sequencia!");
            }
            else
            {
                Console.WriteLine("O Numero não pertence a sequencia!");
            }

        }
    }
}
