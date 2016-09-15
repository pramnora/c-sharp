using System;

//*** Example code: C# programming for loop...

namespace caLoop01 //...ca = console application
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int intNum = 1; intNum <= 10; intNum ++ ) //...for loop counts from 1 up to 10
            {
                Console.WriteLine(intNum); 
            };
            Console.ReadLine(); //...await user keypress so users can see/read ouput before ending program
        }
    }
}
