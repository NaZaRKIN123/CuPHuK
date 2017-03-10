using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CuPHuK
{
    public static class BracketsManager
    {
        //returns position of last left and corresponding right bracket
        public static int[] BracketsPosition(List<string> arguments)
        {
            int[] pos = new int[2];
            pos[0] = arguments.LastIndexOf("(");
            pos[1] = arguments.IndexOf(")", pos[0]);
            return pos;
        }
        //returns what is inside the brackets
        public static List<string> GetQueue(List<string> arguments)
        {
            int queueStart = BracketsPosition(arguments)[0] + 1;
            int count = BracketsPosition(arguments)[1] - queueStart;
            return arguments.GetRange(queueStart, count);
        }
        public static int Count(List<string> arguments)
        {
            var query = arguments.Where(t => t.Contains("("));
            return query.Count();
        }
        public static void RemoveQueue(ref List<string> arguments)
        {
            int leftBracket = BracketsPosition(arguments)[0];
            int count = BracketsPosition(arguments)[1] - leftBracket + 1;
            arguments.RemoveRange(leftBracket, count);
        }
    }
}