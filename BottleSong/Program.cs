using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =98; i > 0; i--)
            {
                Console.WriteLine($"{i+1} Bottles of beer on the wall, {i+1} Bottles of beer. Take one down and pass it around, {i} Bottles of beer on the wall");
                if(i == 1)
                {
                    Console.WriteLine("1 Bottle of beer on the wall, 1 bottle of beer. Take one down and pass it around, no more bottles of beer on the wall.");
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");
                }

            }

        }
    }
}
