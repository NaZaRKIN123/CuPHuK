using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CuPHuK
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput inputLine = new UserInput(Console.ReadLine());
            inputLine.SplitToArguments();
            inputLine.Print();
        }
    }
}
