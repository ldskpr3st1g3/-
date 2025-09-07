using System;

class Program
{
    static void cin(ref int value, string promt = "Число")
    {
        Console.Write($"\tВведите {promt}: ");
        value = int.Parse(Console.ReadLine() ?? "");

    }
    static void Main()
    {
        int n, a, b, w, h;
        n = a = b = w = h = 0;
        Console.WriteLine("******************************************************");
        cin(ref n, "n");
        cin(ref a, "a");
        cin(ref b, "b");
        cin(ref w, "w");
        cin(ref h, "h");
        int left = 0;
        int right = Math.Min(w, h);
        int res = 0;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int temp_A = 2 * mid + a;
            int temp_B = 2 * mid + b;
            int counter_A = w / temp_A;
            int counter_B = h / temp_B;
            if (counter_A * counter_B >= n)
            {
                res = mid;
                left = mid + 1;
            }
            else right = mid - 1;
        }
        Console.WriteLine($"\tОтвет: {res}");
        Console.WriteLine("******************************************************");
    }
}
