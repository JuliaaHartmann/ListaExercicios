// 6. Crie um programa para calcular a média harmônica das notas de um Aluno

Console.Write("1. Digite a nota: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("2. Digite a nota: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("3. Digite a nota: ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

if (nota1 != 0 && nota2 != 0 && nota3 != 0)
{
    decimal somaInversoNotas = 1 / nota1 + 1 / nota2 + 1 / nota3;
    decimal mediaHarmonica = 3 / somaInversoNotas;
    Console.Write($"Média Harmônica: {mediaHarmonica:F2}");
}

Console.Write("As notas não podem ser zero.");

Console.ReadLine();
