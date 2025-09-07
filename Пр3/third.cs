using System;

class Program
{
    static int GCD(int a, int b)
    {
        return b > 0 ? GCD(b, a % b) : a;
    }
    static void Main()
    {
        Console.Write("¬ведите делимое: ");
        int dilimiter = int.Parse(Console.ReadLine() ?? "");
        Console.Write("¬ведите делитель: ");
        int divisor = int.Parse(Console.ReadLine() ?? "");
        int gcd = GCD(Math.Abs(dilimiter), Math.Abs(divisor));
        int part_one = dilimiter / gcd;
        int part_two = divisor / gcd;
        part_one = part_one == 0 ? 1 : part_one;
        part_two = part_two == 0 ? 1 : part_two;
        if (part_one < 0 && part_two < 0)
        {
            part_one *= -1;
            part_two *= -1;
        }
        else if (part_two < 0 && part_one > 0)
        {
            part_one *= -1;
            part_two *= -1;
        }

        Console.WriteLine($"{part_one} / {part_two}");
    }
}
