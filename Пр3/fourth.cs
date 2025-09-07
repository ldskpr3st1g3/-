class Fourth
{
    static int bin_search(ref int left, ref int right)
    {
        return left + (right - left) / 2;
    }
    static void Main()
    {
        int left = -1;
        int right = 64;
        char ans = '0';
        int temp_bin = 0;
        while (left < right - 1)
        {
            temp_bin = bin_search(ref left, ref right);
            Console.Write($"Ваше число больше чем {temp_bin}? ");
            ans = char.Parse(Console.ReadLine() ?? "");
            switch (ans)
            {
                case '1':
                    left = temp_bin;
                    break;
                case '0':
                    right = temp_bin;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"Ваше число: {right}");
    }
}
