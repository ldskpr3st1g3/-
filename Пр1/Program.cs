using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели, с которого начинается месяц (1-пн,...7-вс)");
        int? number = null;
        string temp_number = Console.ReadLine() ?? "";
        number = int.Parse(temp_number);
        while (number == 0 || number > 7)
        {
            Console.WriteLine("Что это за день недели? Никогдатверг?");
            Console.WriteLine("Введите номер дня недели, с которого начинается месяц (1-пн,...7-вс)");
            number = int.Parse(Console.ReadLine() ?? "");
        }

        Console.WriteLine("Введите день месяца: ");
        int? data = null;
        string temp_data = Console.ReadLine() ?? "";
        data = int.Parse(temp_data);
        while (data == 0 || data > 31)
        {
            Console.WriteLine("А это что за число?");
            Console.WriteLine("Введите день месяца: ");
            data = int.Parse(Console.ReadLine() ?? "");
        }
        Console.WriteLine("-----Проверяем выходной ли это день-----");
        if (data == 1 || data == 2 || data == 3 || data == 4 || data == 5 || data == 8 || data == 9 || data == 10)
            Console.WriteLine("Выходной день!!!");
        else
        {
            int dif = ((int)data - 1 + (int)number) % 7;
            if (dif == 6 || dif == 0) Console.WriteLine("Выходной день!!!");
            else Console.WriteLine("Солнце еще высоко!!!");
        }

    }
}
