using System;


namespace CuPHuK
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput inputLine = new UserInput(Console.ReadLine());
            inputLine.SplitToArguments();
            inputLine.Print();
            inputLine.CalculateAllQueues();
        }
    }
}
