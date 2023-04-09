// See https://aka.ms/new-console-template for more information
Console.Title = "Inversor de String";

Console.Write("Digite um texto curto: ");
string input = Console.ReadLine();

char[] chars = input.ToCharArray();
int length = chars.Length;

for (int i = 0; i < length / 2; i++)
{
    char temp = chars[i];
    chars[i] = chars[length - i - 1];
    chars[length - i - 1] = temp;
}

Console.WriteLine("Texto invertida: {0}", new string(chars));
