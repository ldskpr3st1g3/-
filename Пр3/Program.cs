using System;

class Program
{
    static double i_dont_know_how_to_call_you(ref double x, ref int n)
    {
        double temp = 1;
        for (int i = 1; i <= 2 * n + 1; ++i)
        {
            temp *= x / i;
        }
        return temp;
    }
    static double Sihn(ref double x, ref double eps)
    {
        double sum = 0, temp = x;
        int iter = 0;
        while (Math.Abs(temp) > eps)
        {
            sum += temp;
            ++iter;
            temp *= x * x / ((2 * iter) * (2 * iter + 1));
        }
        return sum;
    }
    static void Main()
    {
        Console.WriteLine("Введите x");
        double x = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите eps (eps < 0.01)");
        double eps = double.Parse(Console.ReadLine() ?? "");
        double sin = Sihn(ref x, ref eps);
        Console.WriteLine($"sinh({x}) = {sin}");

        Console.WriteLine("Введите N: ");
        int n = int.Parse(Console.ReadLine() ?? "") -1 ;
        double temp_n = i_dont_know_how_to_call_you(ref x, ref n);
        Console.WriteLine($"{n+1}-й член ряда = {temp_n}");
    }
}


