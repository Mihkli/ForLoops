using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World";

            for(int i =0; i < helloworld.Length; i++)
            {
                Console.WriteLine($"Kohal {i} on {helloworld[i]} ");
            }

        }
    }
}
