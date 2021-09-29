using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisestada number.");
            int num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
                               
            }

        }
    }
}
