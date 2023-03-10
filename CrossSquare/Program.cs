using System;
using System.Diagnostics;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt16(args[0]);
            
            for (int line = 0; line < size; line++)
            {
                string towrite = "";
                
                for (int digit = 0; digit < size; digit++)
                {
                    if (line == 0 || line == size -1)
                    {
                        towrite += "#";
                    }

                    else if (digit == 0 || digit == size -1)
                    {
                        towrite += "#";
                    }

                    else if (digit == line || digit == size - line -1)
                    {
                        towrite += "X";
                    }
                    else
                    {
                        towrite += " ";
                    }
                }
                
                Console.WriteLine(towrite);

            }

        }
    }
}
