using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CuPHuK
{
    public class UserInput
    {
        public ArrayList Arguments { get; set; }
        public short NumberOfQueues { get; set; }
        public string InputString { get; set; }

        public UserInput(string inputString)
        {
            InputString = inputString;
            NumberOfQueues = GetQueuesCount(Arguments);
        }
        public void SplitToArguments()
        {
            string stringToSplit = InputString;
            bool isPreviousDigit = false;
            for (int i = 0; i < stringToSplit.Length; i++)
            {
                bool IsDigit = Char.IsDigit(stringToSplit[i]);
                if (!IsDigit)
                {
                    Arguments.Add(stringToSplit[i]);
                    isPreviousDigit = false;
                }
                else if (IsDigit && !isPreviousDigit)
                {
                    Arguments.Add(stringToSplit[i]);
                    isPreviousDigit = true;
                }
                else
                {
                    //take number from last item in List
                    int prevNumHolder = Convert.ToInt32(Convert.ToString(Arguments[Arguments.Count - 1]));
                    //append current digit
                    prevNumHolder = prevNumHolder * 10 + Convert.ToInt32(Convert.ToString(stringToSplit[i]));
                    //exchange last item in list with prevNumHolder
                    Arguments.RemoveAt(Arguments.Count - 1);
                    Arguments.Add(prevNumHolder);
                    isPreviousDigit = true;
                }
                stringToSplit.Remove(0, 1);
            }
        }
        public short GetQueuesCount(ArrayList argumentsHolder)
        {
            var query = from a in argumentsHolder
                        where a.Contains('(')
                        select a;

            short numOfQueues = (short)(query.Count() + 1);
            return numOfQueues;
        }
        public void Print()
        {
            foreach (object o in Arguments)
            {
                Console.WriteLine(Convert.ToString(o));
            }
            //Console.WriteLine(NumberOfQueues());
        }
    }
}
