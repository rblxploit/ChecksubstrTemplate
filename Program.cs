using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimesSubstring
{
    class Program
    {
        static int checksubstr(string str, string substr)
        {
            // Your code here
			// Do not share it with anyone
        }
        static void Main(string[] args)
        {
            /*
             * This challenge is level easy.
             * It is inspired of some homework that my dad was explaining to a student.
             * What do do: Make a function that checks if a string is present in a substring
             * Where to work: the checksubstr function
             * It is a function that takes in argument str (the string) and substr (the substring to check how many times in the string)
             * It has to return an integer which is how many times the substring is present in the string
             * Return -2 if the substring is empty
             * 
             * Rules
             * 1. Make it using this template. It has to be in C#. This code should work in .NET Framework, .NET Core or Mono
             * 2. It has to be your own code
             * 3. You should not rely heavily on some method already in C#. For example, do not use the substring method already included in C#
             * 
             * For me to verify, you have to send it. I will show all the codes from everybody when the limit date is finished.
             * It has to be the function only (checksubstr), not the rest of the code that i wrote. 
             * Do not give any executable file. Also, do not use obfuscation.
             * If you use some obfuscator or make your code hard to read by accident, without knowing it or by purpose, i will not even bother reading your code.
             * 
             * What you should try to do
             * 
             * 1. Make it as fast as possible
             * 2. Write it in beautiful code
             * 3. Make it easy to understand
             * 4. Search less things on the internet as possible. It is ok if you search for one thing but try to do it the least possible
             * 5. Lastbut not least, it has to work properly
             */
            Console.Write("Testing mode [test] or time taking mode [time] ");
            string res = Console.ReadLine();
            if(res == "test")
            {
                string str, substr;
                while(true)
                {
                    Console.Write("Enter string (q to quit): ");
                    str = Console.ReadLine();
                    if(str == "q")
                    {
                        Console.Write("Bye. Press enter to quit. ");
                        break;
                    }
                    Console.Write("Enter substring: ");
                    substr = Console.ReadLine();
                    Console.WriteLine($"Response: {checksubstr(str, substr)}");
                }
                Console.ReadLine();
            }
            else if(res == "time")
            {
                Console.WriteLine("Testing for time.... (might take a very long time)");

                DateTime after;
                DateTime now;
                TimeSpan t = new TimeSpan();

                for (int i = 0; i < 1000000; i++)
                {
                    now = DateTime.Now;
                    checksubstr("hitest hi hi hello ihihihi Hi hi hello ihihihih hhi HI iH Hi hI hitest hi hi Hi hi hello ihihihih hi hi HI iH Hi hI hitest hi hi Hi ", "hi");
                    after = DateTime.Now;

                    t += after - now;
                }
                Console.WriteLine("Time it took: " + t);
                Console.Write("Press enter to quit.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong input. Press enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
