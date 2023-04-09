// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] fib = { 0, 1 };

Console.Title = "Verificador Fibonacci";
var message = "Digite um número para verificar se pertence à sequência de Fibonacci: ";

var valueInt = 0;

Console.Write(message);

while (!int.TryParse(Console.ReadLine(), out valueInt))
{
    Console.WriteLine("Insira apenas números inteiros");
    Console.WriteLine(message);
}

while (fib[fib.Length - 1] < valueInt)
{
    int next = fib[fib.Length - 1] + fib[fib.Length - 2];
    Array.Resize(ref fib, fib.Length + 1);
    fib[fib.Length - 1] = next;
}

if (Array.IndexOf(fib, valueInt) != -1)
{
    Console.WriteLine($"O número {valueInt} pertence à sequência de Fibonacci.");
}

else
{
    Console.WriteLine($"O número {valueInt} não pertence à sequência de Fibonacci.");
}

Console.ReadKey();
Environment.Exit(0);
