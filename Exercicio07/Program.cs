// 7. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.Write("Digite a nota da primeira prova: ");
double notaPrimeiraProva = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da primeira prova: ");
double pesoPrimeiraProva = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
double notaSegundaProva = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da segunda prova: ");
double pesoSegundaProva = Convert.ToDouble(Console.ReadLine());

double mediaPonderada = ((notaPrimeiraProva * pesoPrimeiraProva) + (notaSegundaProva * pesoSegundaProva)) / (pesoPrimeiraProva + pesoSegundaProva);
Console.Write($"A média ponderada do aluno é: {mediaPonderada}");

Console.ReadLine();