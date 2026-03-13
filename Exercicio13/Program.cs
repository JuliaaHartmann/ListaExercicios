// 13. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

//valor de A
Console.Write("Digite o valor de A: ");
int valorA = Convert.ToInt32(Console.ReadLine());

// valor de B
Console.Write("Digite o valor de B: ");
int valorB = Convert.ToInt32(Console.ReadLine());

//valor de C
Console.Write("Digite o valor de C: ");
int valorC = Convert.ToInt32(Console.ReadLine());

//soma de A+B 
int somaAB = valorA + valorB;

//dizer se é menor que C
if(valorC < somaAB)
{
    Console.Write("Valor de C é menor que a soma de A + B");
}
else
{
    Console.Write("Valor de C NÃO é menor que a soma de A + B");
}