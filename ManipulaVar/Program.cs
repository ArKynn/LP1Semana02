using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int x1 = x;
            int x2 = x;

            Console.WriteLine($"x++ + 2 = {x1++ + 2}");
            Console.WriteLine($"--x + 2 = {--x2 + 2}");
        }
    }
}
