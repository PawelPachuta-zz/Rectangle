using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a width: ");
            string w = Console.ReadLine();
            Console.Write("Give a height: ");
            string h = Console.ReadLine();

            int x = int.Parse(w);
            int y = int.Parse(h);

            Console.WriteLine(x + " " + y);

            for (int i = 0; i < y; i++)
            {
                
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
