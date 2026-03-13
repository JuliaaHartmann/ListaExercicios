// 8. Crie um programa para verificar se um número é primo.

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numero <= 1)
{
    Console.Write($"{numero} não é um número primo!");
    return;
}

for (int i = 2; i < numero; i++)
{
    decimal divisao = numero % i;
    if (divisao == 0)
    {
        Console.Write($"{numero} não é um número primo!");
        return;
    }
}

Console.Write($"{numero} é um número primo!");
Console.ReadLine();