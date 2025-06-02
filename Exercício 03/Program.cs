using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de pães vendidos:");
        int quantidadePaes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de broas vendidas: ");
        int quantidadeBroas = int.Parse(Console.ReadLine());

        double totalPaes = quantidadePaes * 0.12;
        double totalBroas = quantidadeBroas * 1.50;
        double totalVendas = totalPaes + totalBroas;
        double poupanca = totalVendas * 0.10;

        Console.WriteLine("\nTotal arrecadado no dia: R$ " + totalVendas.ToString("F2"));
        Console.WriteLine("Valor a guardar na poupança (10%): R$ " + poupanca.ToString("F2"));

    }
}
