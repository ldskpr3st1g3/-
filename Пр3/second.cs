using System;

class Program2
{
    static int sum_of_numbers(ref int number)
    {
        int counter = 0;
        while (number != 0)
        {
            counter += number % 10;
            number /= 10;
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("¬ведите номер билета: ");
        int part_one = int.Parse(Console.ReadLine() ?? "");
        int part_two = part_one % 1000;
        part_one /= 1000;
        Console.WriteLine(sum_of_numbers(ref part_one) == sum_of_numbers(ref part_two) ? "True" : "False");
    }
}
