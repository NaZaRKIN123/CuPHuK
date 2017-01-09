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
            string input = Console.ReadLine();
            UserInput ArgumentsList = new UserInput(UserInput.SplitToArguments(input));
            ArgumentsList.Print();
        }
    }
}