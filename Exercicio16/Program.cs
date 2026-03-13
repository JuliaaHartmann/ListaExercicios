// 16. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Write("Digite um número para saber se é par ou ímpar: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado % 2 == 0)
{
    Console.Write($"O número {numeroDigitado} é um número PAR!");
    Console.ReadLine();
    return;
}

Console.Write($"O número {numeroDigitado} é um número ÍMPAR!");

Console.ReadLine();