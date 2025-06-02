using System;

class Program
{
    private static readonly int quantidadesCavalos;

    static void MAin()
    {
        Console.WriteLine("Digite a quantidade de cavalos no haras: ");
        int quantidadeCavalos = int.Parse(Console.ReadLine());

        int quantidadeFerraduras = quantidadesCavalos * 4;

        Console.WriteLine("São necessárias " + quantidadeFerraduras + " ferraduras para equipar todos os cavalos.");
    }
}