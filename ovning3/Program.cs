using System;

namespace ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            string text = "och sen då?";
            Console.WriteLine(text);
            string txt = Console.ReadLine();

            while (Console.ReadKey().Key != ConsoleKey.Q){
                
                for (int i = 0; i < x; i++){
                    Console.Write(text + " - ");
                }
                Console.Write("\n");
                x = x + 2;
            }
        }
    }
}
