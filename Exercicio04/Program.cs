// 04. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
// Fórmula: F = C x 1,8 + 32

Console.Write("Digite a temperatura em °C: ");
decimal temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

decimal temperaturaFahrenheit = temperaturaCelsius *  1.8m + 32;

Console.WriteLine($"A temperatura de {temperaturaCelsius} °C corresponde a {temperaturaFahrenheit} °F.");

Console.ReadLine();