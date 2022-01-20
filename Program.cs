using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay13
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("The Maximum Number");

            //int output = UC1.MaximumInteger(45, 65, 35);
            //Console.WriteLine(output);

            //Console.WriteLine("The Maximum Floating Number");

            //double doubleoutput = UC2.MaximumFloatNumber(71.55, 95.88, 98.33);
            //Console.WriteLine(doubleoutput);

            //Console.WriteLine("The Maximum String");

            //string stringoutput = UC3.MaximumString("38", "88", "33");
            //Console.WriteLine(stringoutput);

            //int[] intArray = { 110, 150, 750, 557, 445 };
            //Refactor<int> generic = new Refactor<int>(intArray);
            //generic.PrintMaxValue();

            //double[] doubleArray = { 15.5, 25.4, 45.6, 58.6, 45.6 };
            //Refactor<double> genericDouble = new Refactor<double>(doubleArray);
            //genericDouble.PrintMaxValue();

            //string[] stringArray = { "555", "222", "333", "999" };
            //Refactor<string> genericString = new Refactor<string>(stringArray);
            //genericString.PrintMaxValue();

            //Console.WriteLine("Parameter More than Three");

            //int output = UC4.MaximumParameter(45, 54, 65, 49, 47, 65, 78, 78);
            //Console.WriteLine(output);

            int[] arr = { 445, 445, 556, 489, 756, 786 };
            UC5<int> generic = new UC5<int>(arr);
            generic.PrintMaxValue();


        }
    }
}
