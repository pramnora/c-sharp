/* CREATED: 2nd Sep 2016 01:33 AM GMT
   UPDATED: 2nd Sep 2016 01:33 AM GMT

   NOTE: This is my 2nd 'Hello, world!' C# program...

         The program uses 2 command line arguments each called: args[0],args[1]; 
         both arguments will need to be entered from the user keyboard;
         the program is first run inside of a MS DOS prompt box by typing:
         hw02 one two
         ...the output displays as...
         Hello, world! one two

         (NOTE: In order to run the program within DOS you do not need to type the full filename + . + filenameExtension: hw02.exe.)
*/

using System;

namespace hw02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world! "  
                + args[0] + " " + args[1]);
            Console.Read();
        }
    }
}
