using System.Collections.Generic;
using System.Linq;

namespace CuPHuK
{
    public class Queue
    {
        public short PositionBegin { get; internal set; }
        public short PositionEnd { get; internal set; }
        public void Position(List<string> argumentsHolder)
        {
            for (short i = 0; i < argumentsHolder.Count - 1; i++)
            {
                if (argumentsHolder[i] == ")")
                {
                    PositionEnd = i;
                    break;
                }
            }
            for (short i = PositionEnd; i > 0; i--)
            {
                if (argumentsHolder[i] == "(")
                {
                    PositionBegin = i;
                    break;
                }
            }
        }
        public static decimal Calculate(List<string> argumentsHolder)
        {
            decimal result = 0;
            return result;
        }
        public static short Count(List<string> argumentsHolder)
        {
            var query = argumentsHolder.Where(t => t.Contains("("));
            return (short)(query.Count() + 1);
        }
    }
}
