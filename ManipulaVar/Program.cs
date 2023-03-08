using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            Console.WriteLine($"x++ + 1 = {x++ + 1}");
        }
    }
}
