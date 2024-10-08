/*
 **********TARGET TESTE***********************

3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
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
            string json_caminho = "faturamento.json";
            string conteudo_json = File.ReadAllText(json_caminho);

            var faturamentoMensal = JArray.Parse(conteudo_json);

            double menorValor = double.MaxValue;
            double maiorValor = double.MinValue;
            double somaFaturamento = 0;
            int diasFat = 0;
            int diasAcimaDaMedia = 0;

            foreach (var dia in faturamentoMensal)
            {
                double valor = (double)dia["valor"];

                if (valor > 0)
                {
                    
                    if (valor < menorValor)
                    {
                        menorValor = valor;
                    }

                    if (valor > maiorValor)
                    {
                        maiorValor = valor;
                    }

                    somaFaturamento += valor;
                    diasFat++;
                }
            }
            double mediaMensal = somaFaturamento / diasFat;

            foreach (var dia in faturamentoMensal)
            {
                double valor = (double)dia["valor"];
                if (valor > mediaMensal)
                {
                    diasAcimaDaMedia++;
                }
            }

            Console.WriteLine("Menor valor de faturamento: " + menorValor);
            Console.WriteLine("Maior valor de faturamento: " + maiorValor);
            Console.WriteLine("Número de dias com faturamento acima da média:"+ diasAcimaDaMedia);
        }
    }
}
