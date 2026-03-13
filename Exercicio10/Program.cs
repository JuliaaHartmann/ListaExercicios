// 10. A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
// pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
// dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
// contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
// de pães e de broas, e depois calcular os dados solicitados.

Console.Write("Quantos pães franceses foram vendidos hoje? ");
decimal totalPaes = Convert.ToDecimal(Console.ReadLine());

Console.Write("Quantas broas foram vendidos hoje? ");
decimal totalBroas = Convert.ToDecimal(Console.ReadLine());

decimal totalVendaDia = ((totalPaes * 0.12m) + (totalBroas * 1.50m));
Console.WriteLine($"O total arrecadado nas vendas de hoje é:  R$ {totalVendaDia:F2}");

decimal guardarPoupanca = (totalVendaDia * 0.10m);
Console.Write($"10% do valor total arrecadado hoje é: R$ {guardarPoupanca:F2}");

Console.ReadLine();