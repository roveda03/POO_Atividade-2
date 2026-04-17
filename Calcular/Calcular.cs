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