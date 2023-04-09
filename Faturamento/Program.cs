using Faturamento.Model;
using System.Text.Json;

Console.Title = "Verificador de Faturamento";

byte[] jsonBytes = File.ReadAllBytes(@"Resource\dados.json");
var FaturamentoDiarios = JsonSerializer.Deserialize<List<FaturamentoDiario>>(jsonBytes);

var menorFaturamento = new FaturamentoDiario();
var maiorFaturamento = new FaturamentoDiario();
decimal somaFaturamento = 0.00m;
int numeroDiasComFaturamento = 0;
int numeroDiasComFaturamentoAcimaDaMedia = 0;
decimal mediaFaturamentoDia = 0.00m;

maiorFaturamento.Valor = 0.00m;
bool primeiro = true;

foreach (var item in FaturamentoDiarios)
{
    if (item.Valor > 0.00m && item.Valor > maiorFaturamento.Valor)
    {
        maiorFaturamento = item;

        if (primeiro)
        {
            menorFaturamento = maiorFaturamento;
            primeiro = false;
        }
    }

    if (item.Valor > 0.00m && item.Valor < menorFaturamento.Valor)
        menorFaturamento = item;

    if (item.Valor > 0.00m)
    {
        somaFaturamento += item.Valor;
        numeroDiasComFaturamento++;
    }
}

mediaFaturamentoDia = somaFaturamento / numeroDiasComFaturamento;

//for (int i = 0; i < faturamentoDiario.Length; i++)
//    if (faturamentoDiario[i] > mediaFaturamentoDia)
//        numeroDiasComFaturamentoAcimaDaMedia++;

foreach (var item in FaturamentoDiarios)
{
    if (item.Valor > mediaFaturamentoDia)
        numeroDiasComFaturamentoAcimaDaMedia++;
}

Console.WriteLine($"O menor valor de faturamento diário: {menorFaturamento.Valor}, ocorreu no dia: {menorFaturamento.Dia}");
Console.WriteLine($"O maior valor de faturamento diário:  {maiorFaturamento.Valor}, ocorreu no dia: {maiorFaturamento.Dia}");
Console.WriteLine($"Dias com faturamento acima da média diária:  {numeroDiasComFaturamentoAcimaDaMedia}");

