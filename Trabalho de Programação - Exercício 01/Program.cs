
using System;
    class Programa
{
    private static double largura;

    static void Main()
    {
        Console.WriteLine("Digite a largura do terreno (em metros):");
        Console.WriteLine("Dgite o comprimento do terreno (em metros):");
        double comprimento = Convert.ToDouble(Console.ReadLine());

        double area = largura * comprimento;

        Console.WriteLine("A área dp terreno é: " + area + "metros quadrados.");
    }
}