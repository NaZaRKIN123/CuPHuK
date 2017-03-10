using System;
using System.Collections.Generic;

namespace CuPHuK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "2*(3+4)+(5*6)/3";

            //parse the input
            List<string> arguments = new List<string>(UserInput.Parse(input));
            UserInput.Print(arguments);

            //do Math
            bool hasBrackets = true;
            string result = "";
            while (hasBrackets)
            {
                if (arguments.Contains("("))
                {
                    hasBrackets = true;
                    //get one line and strip the brackets
                    List<string> queue = BracketsManager.GetQueue(arguments);
                    //save start position where to put result back later
                    int startOfBracketsPosition = BracketsManager.BracketsPosition(arguments)[0];
                    BracketsManager.RemoveQueue(ref arguments);
                    result = MathManager.Calculate(queue);
                    arguments.Insert(startOfBracketsPosition, result);
                }
                else
                {
                    hasBrackets = false;
                    result = MathManager.Calculate(arguments);
                } 
            }
            Console.WriteLine("\nThe result is: {0}\n", result);
        }
    }
}
