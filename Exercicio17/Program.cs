//17. Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

Console.Write("Digite valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());

if (valorA == valorB)
{
    int valorC = valorA + valorB;
    Console.Write($"O valor de C é: {valorC}");
} 
else 
{
    int valorC = valorA * valorB;
    Console.Write($"O valor de C é: {valorC}");
}

Console.ReadLine();