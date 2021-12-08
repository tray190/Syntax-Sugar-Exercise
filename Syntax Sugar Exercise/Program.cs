using System;

namespace Syntax_Sugar_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int answer = 4;

            var response = (answer < 9 ? $"{answer} is less than nine greater than or equal to nine" : $"{answer}  is less than nine";

            
            {
               
                Console.WriteLine(response);
            }

        }
    }
}

           
            
            
