using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**********************************************************************");
        Console.Write("\t������� ���������� ��������: ");
        int N = int.Parse(Console.ReadLine() ?? "");
        Console.Write("\t������� ���������� ������ �����������: ");
        int X = int.Parse(Console.ReadLine() ?? "");
        for (int iter = 10; iter > 0; iter--)
        {
            N <<= 1;
            N -= X * iter;
            if (N <= 0)
            {
                Console.WriteLine("\t��� ������ �������� �������!!!");
                Console.WriteLine("**********************************************************************");
                return;
            }
            else
            {
                Console.WriteLine($"\t����� {10 - iter + 1} ���� �������� �������� {N}");
            }
        }
        Console.WriteLine("\t��� �������� ��������!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("**********************************************************************");
    }
}
