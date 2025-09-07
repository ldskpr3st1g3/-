using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**********************************************************");
        int counter_americano = 0; // 150 ���, 300 ����
        int counter_latte = 0; // 170 ���, 30 ����, 270 ������.
        Console.Write("\t������� ���������� ����: ");
        int quantity_of_water = int.Parse(Console.ReadLine() ?? "");
        Console.Write("\t������� ���������� ������: ");
        int quantity_of_milk = int.Parse(Console.ReadLine() ?? "");
        char choise = '0';
        while (quantity_of_water >= 30 || quantity_of_milk >= 270)
        {
            Console.Write("\t�������� ������� (1 - ���������, 2 - �����): ");
            choise = char.Parse(Console.ReadLine() ?? "");
            switch (choise)
            {
                case '1':
                    if (quantity_of_water < 300)
                    {
                        Console.WriteLine("\t�� ������� ����!");
                    }
                    else
                    {
                        quantity_of_water -= 300;
                        ++counter_americano;
                        Console.WriteLine("\t��� ������� �����! ");
                    }
                    break;
                case '2':
                    if (quantity_of_milk < 270)
                        Console.WriteLine("\t�� ������� ������!");
                    else
                    {
                        ++counter_latte;
                        quantity_of_milk -= 270;
                        quantity_of_water -= 30;
                        Console.WriteLine("\t��� ������� �����!");
                    }
                    break;
            }


        }
        Console.WriteLine("\t*�����*");
        Console.WriteLine($"\t����������� ��������\n\t\t����: {quantity_of_water} ��\n\t\t������: {quantity_of_milk} ��");
        Console.WriteLine($"\t������ ��������� ������������: {counter_americano}");
        Console.WriteLine($"\t������ ����� ������������: {counter_latte}");
        Console.WriteLine($"�����: {counter_latte * 170 + counter_americano * 150} ������.");
        Console.WriteLine("**********************************************************");
    }
}
