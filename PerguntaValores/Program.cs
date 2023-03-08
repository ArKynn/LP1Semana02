using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the cylinder:");
            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of the cylinder:");
            int height = Convert.ToInt32(Console.ReadLine());
            
            float Pi = 3.1415926f; 
            double Volume = Pi * Math.Pow(radius, radius) * height;
            Console.WriteLine($"The volume of the cylinder is {Volume}");

            double SuperficialArea = 2 * Pi * radius * (radius + height);
            Console.WriteLine($"The superficial area of the cylinder is {SuperficialArea}");


        }
    }
}
