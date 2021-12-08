using System;

namespace Syntax_Sugar_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string personName = "Tracy";
             string petName = "Binky";
             string snackName = "life savers";
             Console.WriteLine($"My name is {personName} I have a dog name {petName} and I like {snackName} snacks");

            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
                Console.WriteLine(response);
            }

        }
    }
}
