using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o preço do litro de gasolina: ");
        double precoLitro = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor que deseja abastecer (em reais): ");
        double valorPagamento = double.Parse(Console.ReadLine());

        double quantidadeLitros = valorPagamento / precoLitro;

        object qunatidadeLitros;
        Console.WriteLine(value: $@"
Você conseguiu colocar {qunatidadeLitros:F2} litros no tanque.");
    }
}
