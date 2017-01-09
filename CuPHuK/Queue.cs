using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuPHuK
{
    public static class Queue
    {
        public static decimal CalculateArguments(List<string> argumentsHolder, short numOfQueues)
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
