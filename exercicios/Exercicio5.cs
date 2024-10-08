/*
 **********TARGET TESTE***********************

5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;

 */

using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TargetTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "texto de teste";
            string invertido = "";

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                invertido += texto[i];
            }
            Console.WriteLine(invertido);

        }
    }
}
