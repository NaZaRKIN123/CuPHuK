using System;
using System.Collections;
using System.Collections.Generic;

namespace CuPHuK
{
    public class UserInput
    {
        public List<string> Arguments { get; internal set; }
        public short NumberOfQueues { get; internal set; }
        public string InputString { get; set; }
        public UserInput(string inputString)
        {
            InputString = inputString;
            NumberOfQueues = 0;
            Arguments = new List<string>() { };
        }
        public void CalculateAllQueues()
        {
            NumberOfQueues = Queue.Count(Arguments);
            ArrayList preliminaryResults = new ArrayList(Arguments);
            for (int i = 0; i < NumberOfQueues; i++)
            {
                Queue positionOfQueue = new Queue(Arguments);
                positionOfQueue.Position(Arguments);
                preliminaryResults = positionOfQueue.Calculate(preliminaryResults);
            }
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
                    Arguments.Add(Convert.ToString(stringToSplit[i]));
                    isPreviousDigit = false;
                }
                else if (IsDigit && !isPreviousDigit)
                {
                    Arguments.Add(Convert.ToString(stringToSplit[i]));
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
                    Arguments.Add(Convert.ToString(prevNumHolder));
                    isPreviousDigit = true;
                }
                stringToSplit.Remove(0, 1);
            }
        }
        public void Print()
        {
            foreach (object o in Arguments)
            {
                Console.WriteLine(Convert.ToString(o));
            }
            Console.WriteLine("There are: {0} queues.", Queue.Count(Arguments));
        }
    }
}
