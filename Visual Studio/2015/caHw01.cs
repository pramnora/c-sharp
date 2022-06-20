/* CREATED: 2nd Sep 2016 01:28 AM GMT
'  UPDATED: 2nd Sep 2016 01:28 AM GMT

   I used Visual Studio 2015 Community Edition which I downloaded for FREE from Microsoft web site.
   I opted to create a Windows Console Project; naming it: hw01.cs 

   NOTE: This is my first 'Hello, world!' C# program...
*/

using System;

//*** I deleted all of the unnecessary 'using' references being shown here... 

namespace hw01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!"); //*** print out the text: 'Hello, world!', onto the console output screen
            Console.Read();                     //*** pauses the console output screen until when user presses any key; 
                                                //    thus, allowing user to see/read console output screen text before it completely vanishes 
        }
    }
}
