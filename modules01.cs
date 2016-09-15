using System;

/*
 Created: 150916 17:46 PM GMT
 Updated: 150916 17:46 PM GMT
 Language: C#/Visual Studio 2015/Community Edition (FREE)
 Program: Simple Maths Demo/Illustrating the use of C# code modules
*/

namespace caModules01 //console application
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 3;
            Console.WriteLine(add(a,b));         //6
            Console.WriteLine(multiply(a,b));    //9
            Console.WriteLine(subtract(a,b));    //0
            Console.WriteLine(divide(a,b));      //1
            Console.ReadLine();
        }

        static int add(int n1, int n2)
        {
            return n1 + n2;
        }

        static int multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        static int subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        static int divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
