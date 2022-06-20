using System;

/*
 * Illustrating the use of C# loops...
 *
 * Computer(Home): Desktop PC/Windows 10 Professional
 * Visual Studio FREE Community Edition - Version 2019
 *
 * Created: 200522 01:57 PM GMT
 * Updated: 200522 01:57 PM GMT
 * 
 */

namespace ConsoleAppLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("For loop: ");
            for (int x = 1; x < 10; x++) { Console.Write(x); } //...enumeration loop/for loop...

            Console.WriteLine(); //...a blank vertical line

            Console.Write("For loop/even numbers: ");
            for (int x = 2; x < 10; x = x + 2) { Console.Write(x); } //...enumeration loop/for loop...

            Console.WriteLine(); //...a blank vertical line
            Console.Write("For loop/odd numbers: ");
            for (int x = 1; x < 10; x = x + 2) { Console.Write(x); } //...enumeration loop/for loop...

            Console.WriteLine(); //...a blank vertical line

            Console.Write("While loop: ");
            int i = 1;
            while (i < 10) { Console.Write(i); i++; } //...entry controlled loop/while loop...
 
            Console.WriteLine(); //...a blank vertical line

            Console.Write("Do/While loop: "); 
            int y = 9;
            do //...exit controlled/do-while loop...
            {
                Console.Write(y);
                y--;
            } while (y > 1);

        }
    }
}
