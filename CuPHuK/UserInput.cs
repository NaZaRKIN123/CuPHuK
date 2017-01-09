using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CuPHuK
{
    public class UserInput
    {
        public ArrayList Arguments { get; set; }

        public UserInput(ArrayList argumentsList)
        {
            Arguments = argumentsList;
        }
        public ArrayList SplitToArguments(string stringToSplit)
        {
            ArrayList argumentsHolder = new ArrayList() { };
            bool isPreviousDigit = false;
            for (int i = 0; i < stringToSplit.Length; i++)
            {
                bool IsDigit = Char.IsDigit(stringToSplit[i]);
                if (!IsDigit)
                {
                    argumentsHolder.Add(stringToSplit[i]);
                    isPreviousDigit = false;
                }
                else if (IsDigit && !isPreviousDigit)
                {
                    argumentsHolder.Add(stringToSplit[i]);
                    isPreviousDigit = true;
                }
                else
                {
                    //take number from last item in List
                    int prevNumHolder = Convert.ToInt32(Convert.ToString(argumentsHolder[argumentsHolder.Count - 1]));
                    //append current digit
                    prevNumHolder *= 10 + Convert.ToInt32(Convert.ToString(stringToSplit[i]));
                    //exchange last item in list with prevNumHolder
                    argumentsHolder.RemoveAt(argumentsHolder.Count - 1);
                    argumentsHolder.Add(prevNumHolder);
                    isPreviousDigit = true;
                }
                stringToSplit.Remove(0, 1);
            }
            return argumentsHolder;
        }
        public short getNamberOfQueues(List<string> argumentsHolder)
        {
            var result = argumentsHolder.Where(a => a.Count('('));
            return result;
        }
        public decimal CalculateArguments(ArrayList argumentsHolder)
        {
            decimal result = 0;
            return result;
        }
        public void Print()
        {
            foreach (object i in Arguments)
            {
                Console.WriteLine(Convert.ToString(i));
            }
        }
    }
}