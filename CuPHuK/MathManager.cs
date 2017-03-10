using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuPHuK
{
    public static class MathManager
    {
        public static bool isAsterisk(string arg)
        {
            return arg.Equals("*");
        }
        public static bool isDivision(string arg)
        {
            return arg.Equals("/");
        }
        public static bool isPlus(string arg)
        {
            return arg.Equals("+");
        }
        public static bool isMinus(string arg)
        {
            return arg.Equals("-");
        }
        public static string Calculate(List<string> arguments)
        {
            int index;
            bool exit = false;
            decimal numHolder;
            while (!exit)
            {
                if (arguments.Contains("*"))
                {
                    index = arguments.FindIndex(isAsterisk);
                    numHolder = Decimal.Multiply(Convert.ToDecimal(arguments[index - 1]), Convert.ToDecimal(arguments[index + 1]));
                }
                else if (arguments.Contains("/"))
                {
                    index = arguments.FindIndex(isDivision);
                    numHolder = Decimal.Divide(Convert.ToDecimal(arguments[index - 1]), Convert.ToDecimal(arguments[index + 1]));
                }
                else if (arguments.Contains("+"))
                {
                    index = arguments.FindIndex(isPlus);
                    numHolder = Decimal.Add(Convert.ToDecimal(arguments[index - 1]), Convert.ToDecimal(arguments[index + 1]));
                }
                else if (arguments.Contains("-"))
                {
                    index = arguments.FindIndex(isMinus);
                    numHolder = Decimal.Subtract(Convert.ToDecimal(arguments[index - 1]), Convert.ToDecimal(arguments[index + 1]));
                    //add verification if numHolder becomes negative
                }
                else
                {
                    break;
                }
                arguments[index - 1] = numHolder.ToString();
                arguments.RemoveAt(index + 1);
                arguments.RemoveAt(index);
            }
            return arguments[0];
        }
    }
}
