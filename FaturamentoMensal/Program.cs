// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Title = "Percentual de Faturamento por Estado";

double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

double total = sp + rj + mg + es + outros;

double sp_percentual = (sp / total) * 100;
double rj_percentual = (rj / total) * 100;
double mg_percentual = (mg / total) * 100;
double es_percentual = (es / total) * 100;
double outros_percentual = (outros / total) * 100;

var qtDecimais = 6;

Console.WriteLine($"Percentual de representação por estado:");
Console.WriteLine($"SP: {Double.Round(sp_percentual, qtDecimais)}%");
Console.WriteLine($"RJ: {Double.Round(rj_percentual, qtDecimais)}%");
Console.WriteLine($"MG: {Double.Round(mg_percentual, qtDecimais)}%");
Console.WriteLine($"ES: {Double.Round(es_percentual, qtDecimais)}%");
Console.WriteLine($"Outros: {Double.Round(outros_percentual, qtDecimais)}%");