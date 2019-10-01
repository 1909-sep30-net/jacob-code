using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make bool, string, and int variables (with values)
            bool yes = false;
            string name = "Jacob";
            int i = 0;

            // change their values to something else
            yes = true;
            name = "Davis";
            i = 1;

            // print their values with Console
            Console.WriteLine(yes.ToString() + ", " + name + ", " + i.ToString());

            // do something in a for loop
            for (int j = 0; j < 10; ++j)
            {
                i += 2;
            }

            // do something in a while loop
            while (yes)
            {
                yes = !yes;
            }

            // do something with a switch statement
            switch (i % 2)
            {
                case 0:
                    Console.WriteLine("Even!");
                    break;

                case 1:
                    Console.WriteLine("Odd!");
                    break;
            }

            // do something with if, else if, else
            if (yes && i % 2 == 0) Console.WriteLine("Even and yes!");
            else if (!yes) Console.WriteLine("No!");
            else Console.WriteLine("Uh oh!");

            // figure out how to make multi-line comments in C#

            /* Like
            this? */

            // figure out how to format your document in VS Code

            // Ctrl + Alt + F!


            // extra: make a new static method to do something and call it
            static void printNonsense()
            {
                Console.WriteLine("UBVUYKVKUHSF!");
            }

            printNonsense();

            // extra: learn what "var" means in C# and try it out.
            var a = "a";
            var two = 2;
            var no = false;
        }
    }
}
