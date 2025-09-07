using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**********************************************************");
        int counter_americano = 0; // 150 руб, 300 воды
        int counter_latte = 0; // 170 руб, 30 воды, 270 молока.
        Console.Write("\tВведите количество воды: ");
        int quantity_of_water = int.Parse(Console.ReadLine() ?? "");
        Console.Write("\tВведите количество молока: ");
        int quantity_of_milk = int.Parse(Console.ReadLine() ?? "");
        char choise = '0';
        while (quantity_of_water >= 30 || quantity_of_milk >= 270)
        {
            Console.Write("\tВыберете напиток (1 - американо, 2 - латте): ");
            choise = char.Parse(Console.ReadLine() ?? "");
            switch (choise)
            {
                case '1':
                    if (quantity_of_water < 300)
                    {
                        Console.WriteLine("\tНе хватает воды!");
                    }
                    else
                    {
                        quantity_of_water -= 300;
                        ++counter_americano;
                        Console.WriteLine("\tВаш напиток готов! ");
                    }
                    break;
                case '2':
                    if (quantity_of_milk < 270)
                        Console.WriteLine("\tНе хватает молока!");
                    else
                    {
                        ++counter_latte;
                        quantity_of_milk -= 270;
                        quantity_of_water -= 30;
                        Console.WriteLine("\tВаш напиток готов!");
                    }
                    break;
            }


        }
        Console.WriteLine("\t*Отчёт*");
        Console.WriteLine($"\tИнгридинтов осталось\n\t\tВода: {quantity_of_water} мл\n\t\tМолоко: {quantity_of_milk} мл");
        Console.WriteLine($"\tКружек американо приготовлено: {counter_americano}");
        Console.WriteLine($"\tКружек латте приготовлено: {counter_latte}");
        Console.WriteLine($"Итого: {counter_latte * 170 + counter_americano * 150} рублей.");
        Console.WriteLine("**********************************************************");
    }
}
