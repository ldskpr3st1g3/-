using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму денег которую хотели бы обналичить: ");
        int money = int.Parse(Console.ReadLine() ?? "");
        while (money == 0) { Console.WriteLine("Введите нормальную сумму"); money = int.Parse(Console.ReadLine() ?? ""); }
        while (money % 100 != 0 || money > 150000)
        {
            Console.WriteLine("Банкомат не может разменять эту сумму!!!");
            money = int.Parse(Console.ReadLine() ?? "");
        }
        int[] subtractors = { 5000, 2000, 1000, 500, 200, 100 };

        int temp_sum = 0;
        foreach (var subtractor in subtractors)
        {
            temp_sum = 0;
            while (money - subtractor >= 0) { money -= subtractor; ++temp_sum; }
            Console.WriteLine($"купюр по {subtractor} рублей выдано ровно {temp_sum}");
        }
    }
}

