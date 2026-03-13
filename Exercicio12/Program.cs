// 12. Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

Console.Write("Digite o salário: ");
decimal salarioFuncionario = Convert.ToDecimal(Console.ReadLine());

decimal valorAumentoSalario = (salarioFuncionario * 0.15m);

decimal salarioComAumento = salarioFuncionario + valorAumentoSalario;

decimal descontoImposto = ( salarioComAumento * 0.08m);

decimal salarioFinal = salarioComAumento - descontoImposto;

Console.WriteLine($"Salário inicial: R$ {salarioFuncionario:F2}");
Console.WriteLine($"Salário com aumento: R$ {salarioComAumento:F2}");
Console.WriteLine($"Salário final: R$ {salarioFinal:F2}");

Console.ReadLine();
