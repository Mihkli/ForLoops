using System;

namespace CalculatingSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                sum = sum + num1;       
            }
            Console.WriteLine($"Your result is {sum}.");
        }
    }
}
