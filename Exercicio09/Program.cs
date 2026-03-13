// 9. A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um 
// terreno e depois exibir a área do terreno.

Console.Write("Digite a largura do terreno (m): ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o comprimento do terreno (m): ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

decimal areaTerreno = largura * comprimento;

Console.Write($"A dimensão do terreno é: {areaTerreno}m²");

Console.ReadLine();