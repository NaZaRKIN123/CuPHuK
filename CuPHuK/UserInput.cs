using System;
using System.Collections;
using System.Collections.Generic;

namespace CuPHuK
{
    public static class UserInput
    {
        public static List<string> Parse(string stringToParse)
        {
            bool isPreviousDigit = false;
            bool isNegativeNum = false;
            List<string> arguments = new List<string>() { };
            for (int i = 0; i < stringToParse.Length; i++)
            {
                bool isDigit = Char.IsDigit(stringToParse[i]);
                bool isDecimalDot = Char.Equals('.', stringToParse[i]);
                bool isMinusSign = Char.Equals('-', stringToParse[i]);
                if (isMinusSign && !isPreviousDigit)
                {
                    isNegativeNum = true;
                }
                //new arg if some single Math sign
                if (!isDigit && !isDecimalDot)
                {
                    arguments.Add(stringToParse[i].ToString());
                    isPreviousDigit = false;
                }
                //new arg if first digit or digit right after Math sign
                else if (isDigit && !isPreviousDigit && !isNegativeNum)
                {
                    arguments.Add(stringToParse[i].ToString());
                    isPreviousDigit = true;
                }
                //append digit or dot to previous digit
                //append digit if negative num to minus sign
                else
                {
                    arguments[arguments.Count - 1] = arguments[arguments.Count - 1] + stringToParse[i];
                    isPreviousDigit = true;
                    isNegativeNum = false;
                }
                stringToParse.Remove(0, 1);
            }
            return arguments;
        }
        public static void Print(List<string> arguments)
        {
            foreach (object o in arguments)
            {
                Console.WriteLine(Convert.ToString(o));
            }
            Console.WriteLine("There are: {0} pair(s) of brackets", BracketsManager.Count(arguments));
        }
    }
}
