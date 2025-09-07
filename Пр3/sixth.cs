using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**********************************************************************");
        Console.Write("\tÂâåäèòå êîëè÷åñòâî áàêòåğèé: ");
        int N = int.Parse(Console.ReadLine() ?? "");
        Console.Write("\tÂâåäèòå êîëè÷åñòâî êàïåëü àíòèáèîòèêà: ");
        int X = int.Parse(Console.ReadLine() ?? "");
        for (int iter = 10; iter > 0; iter--)
        {
            N <<= 1;
            N -= X * iter;
            if (N <= 0)
            {
                Console.WriteLine("\tÂñå áåäíûå áàêòåğèè ïîãèáëè!!!");
                Console.WriteLine("**********************************************************************");
                return;
            }
            else
            {
                Console.WriteLine($"\tÏîñëå {10 - iter + 1} ÷àñà áàêòåğèé îñòàëîñü {N}");
            }
        }
        Console.WriteLine("\tÓğà áàêòåğèè ïîáåäèëè!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("**********************************************************************");
    }
}
