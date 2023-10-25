using System;

namespace For_3_Ron
{
    class Program
    {
        const int LIMIT = 300;
        static void Main(string[] args)
        {
            int i = 0, amount = 0;
            for (i=0; i< LIMIT; i++)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    amount++;
                }
            }
            Console.WriteLine($"Amount of integer squares is: {amount}");
            Console.ReadLine();
        }
    }
}
