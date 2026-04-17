using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Exercício 1 (Sobrecarga)");
            Console.WriteLine("2 - Exercício 2 (Coerção Implícita)");
            Console.WriteLine("3 - Exercício 3 (Casting)");
            Console.WriteLine("4 - Exercício 4 (Polimorfismo)");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    // =========================
    // EXERCÍCIO 1
    // =========================
    static void Exercicio1()
    {
        Operacoes op = new Operacoes();

        Console.Write("Digite dois inteiros: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + op.Calcular(a, b));

        Console.Write("Digite três inteiros: ");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("Maior: " + op.Calcular(x, y, z));

        Console.Write("Digite dois decimais: ");
        double d1 = double.Parse(Console.ReadLine());
        double d2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Multiplicação: " + op.Calcular(d1, d2));
    }

    // =========================
    // EXERCÍCIO 2
    // =========================
    static void Exercicio2()
    {
        ConversorValores conv = new ConversorValores();

        Console.Write("Digite um float: ");
        float f = float.Parse(Console.ReadLine());

        Console.Write("Digite um inteiro: ");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Resultado: " + conv.Somar(f, i));

        Console.Write("Digite um inteiro para exibir: ");
        int valor = int.Parse(Console.ReadLine());

        conv.Exibir(valor);
    }

    // =========================
    // EXERCÍCIO 3
    // =========================
    static void Exercicio3()
    {
        CastingExemplo cast = new CastingExemplo();

        Console.Write("Digite um inteiro: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite um float: ");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Divisão (int): " + cast.Dividir(a, b));

        Console.Write("Digite algo para converter em string: ");
        object obj = Console.ReadLine();

        cast.Transformar(obj);
    }

    // =========================
    // EXERCÍCIO 4
    // =========================
    static void Exercicio4()
    {
        List<Forma> formas = new List<Forma>();

        Console.Write("Quantas formas deseja criar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n1 - Retângulo | 2 - Círculo");
            int tipo = int.Parse(Console.ReadLine());

            if (tipo == 1)
            {
                Console.Write("Altura: ");
                double h = double.Parse(Console.ReadLine());

                Console.Write("Largura: ");
                double w = double.Parse(Console.ReadLine());

                formas.Add(new Retangulo { Altura = h, Largura = w });
            }
            else if (tipo == 2)
            {
                Console.Write("Raio: ");
                double r = double.Parse(Console.ReadLine());

                formas.Add(new Circulo { Raio = r });
            }
        }

        Console.WriteLine("\n=== RESULTADOS ===");
        foreach (Forma f in formas)
        {
            Console.WriteLine("Área: " + f.CalcularArea());

            if (f is Retangulo)
                Console.WriteLine("Tipo: Retângulo");

            else if (f is Circulo)
                Console.WriteLine("Tipo: Círculo");
        }
    }
}