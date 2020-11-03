using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words to make an acronym.");
            string input = Console.ReadLine();
            string [] output = input.Split(' ');

            foreach (string first in output){
                Console.Write(first[0]);
            }
            
        }
    }
}
