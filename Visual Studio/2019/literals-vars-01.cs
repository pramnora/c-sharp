using System;

/* Program: Literals/Vars...
 * 
 * Demonstrates how to create both literals/variables;
 * and, also, how to output their values.
 * 
 * Computer(Home): Desktop PC/Windows 10 Professional
 * Visual Studio 2019 - FREE Community Edition 
 *
 * Created: 190622 04:32 AM GMT
 * Updated: 190622 04:32 AM GMT
*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** variable declarations...
            
            string strGreeting = "Hi";
            Boolean bolMyFlag = true;
            int intNumber1 = 2;
            double dblNumber2 = 2.00;
            char chrALetter = 'c';

            //*** output...

            Console.WriteLine(strGreeting + " " + bolMyFlag + " " + intNumber1 + " " + dblNumber2 + " " + chrALetter); //...concatenation
            Console.WriteLine("{0},{1},{2},{3},{4}", strGreeting, bolMyFlag, intNumber1, dblNumber2, chrALetter);      //...interpolation
            Console.Write("Hello World!");                                                                             // ...string literal/(NOTE: Write supresses new line...whereas, WriteLine does not...)
            Console.WriteLine("1+1=" + (1+1));                                                                         // ...string literal + (numeric literals to be evaluated)
        }
    }
}
