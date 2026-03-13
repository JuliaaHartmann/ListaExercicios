// 5. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
// vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.

Console.Write("Digite o salário base: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o total de vendas: ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o percentual da comissão(%): ");
decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

decimal comissao = totalVendas * (percentualComissao / 100);
decimal salarioTotal = salarioBase + comissao;

Console.WriteLine($"O salário total do vendedor é: R$ {salarioTotal:F2}");

Console.ReadLine();