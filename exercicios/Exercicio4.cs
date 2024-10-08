/*
 **********TARGET TESTE***********************

4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
• SP – R$67.836,43
• RJ – R$36.678,66
• MG – R$29.229,88
• ES – R$27.165,48
• Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  

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
            string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
            double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

            double totalFaturamento = 0;
            for (int i = 0; i < faturamento.Length; i++)
            {
                totalFaturamento += faturamento[i];
            }

            Console.WriteLine("Percentual de representação por estado:");
            for (int i = 0; i < estados.Length; i++)
            {
                double percentual = (faturamento[i] / totalFaturamento) * 100;
                percentual = Math.Round(percentual, 2);
                Console.WriteLine(estados[i] + ": " + percentual+"%");
            }


        }
    }
}
