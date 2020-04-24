using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetAString("What is your first name?");
            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetADouble("Enter the first number: ");
            double y = RequestData.GetADouble("Enter the second number: ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The sum of { x } and { y } is { result }");

            Console.ReadLine();
        }

    }
}
