using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Loop = true;
            while (Loop == true)
            {
                Console.WriteLine("Ask me any questions!");
                string question = Console.ReadLine();

                string answer = question switch
                {
                    "Hello" => "Hi!",
                    "How are you?" => "I'm fine thanks!",
                    "Who are you?" => "I'm Mother",
                    "What do you do?" => "I just answer some predefined questions...",
                    "a" => "Dont give me an a, ask me a question!",
                    "1" => "Dont give me a 1, ask me a question!",
                    "EXIT" => "Aye Aye Captain!",
                    _ => "Just so you know, I'm not a real AI...",
                    
                };
                if (question == "EXIT")
                {
                    Loop = false;
                }
                
                Console.WriteLine(answer);
            }
            
        }
    }
}