using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string simbol = "";
            int size = Convert.ToInt16(args[0]);
            
            for (int i = 0; i < size ; i++)
            {
                simbol += args[1];
                
                Console.WriteLine(simbol);
            }

        }
    }
}