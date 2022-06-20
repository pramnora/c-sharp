/*
  CREATED: 4th Sep 2016 04:32 AM GMT
  UPDATED: 11th Sep 2016 17:26 PM GMT
  12 x Tables program using C# programming language
  Console Application
*/

using System;

namespace timesTables01
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int intTablesNo = 1; intTablesNo <= 12; intTablesNo++)
            {
                Console.Clear();
                Console.WriteLine(intTablesNo + " X Tables:-");
                Console.WriteLine();

                for (int intTimesNo = 1; intTimesNo <= 12; intTimesNo++)
                {
                    Console.WriteLine(intTimesNo + " X " + intTablesNo + " = " + intTimesNo * intTablesNo);
                }

                Console.ReadLine(); // wait for user key press before showing the next times tables
            }

        }
    }
}
