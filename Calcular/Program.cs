using System;

using System;

class Operacoes
{
    public int Calcular(int a, int b)
    {
        return a + b;
    }

    public int Calcular(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    public double Calcular(double a, double b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Operacoes op = new Operacoes();

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Somar dois inteiros");
        Console.WriteLine("2 - Maior de três inteiros");
        Console.WriteLine("3 - Multiplicar dois decimais");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Write("Digite o primeiro número inteiro: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + op.Calcular(a, b));
                break;

            case 2:
                Console.Write("Digite o primeiro número inteiro: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número inteiro: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número inteiro: ");
                int z = int.Parse(Console.ReadLine());

                Console.WriteLine("Maior: " + op.Calcular(x, y, z));
                break;

            case 3:
                Console.Write("Digite o primeiro número decimal: ");
                double d1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número decimal: ");
                double d2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Resultado: " + op.Calcular(d1, d2));
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}