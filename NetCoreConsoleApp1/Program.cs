using System;
using System.Collections.Generic;

namespace NetCoreConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("BAD: divide by zero (and other maths errors) are also hard to detect in .net Core 2.2 and earlier!");
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
                var x = 1.1d;
                var zero = 0.0d;
                var y = x / zero;
                Console.WriteLine("We shouldn't get here because we have just divided by zero (y = 1.1/0), but we have got here and y is infinity: " + y);
                Console.WriteLine("Our code HAS FAILED SILENTY (i.e. with no indication that there is a problem) which is bad!");
                var a = y + 3;
                Console.WriteLine("Calculations have continued under .net when they shouldn't have, because they have now become meaningless, a (= y + 3) is also infinity: " + a);
                Console.WriteLine("And we won't know when the problem first occurred!");
                Console.WriteLine("Worse, we may not even be aware that a problem has occurred (e.g. if this is an unattended process)!");
                Console.WriteLine();
                Console.WriteLine("As in .net 4.72 and earlier, these and other math problems can be solved in .net core 2.2 by using custom functions (e.g. SafeDivide, SafeLog, SafeExp)");
                Console.WriteLine("But this is a nuisance, and worse, if we do nothing, our code could fail silently!");

                Console.WriteLine();
                Console.WriteLine("GOOD: asking for a dictionary item for a non existent key DOES give an informative error message in .net core 2.2");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                var dictionary = new Dictionary<int, int>();
                var z = dictionary[2];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception was thrown, the message under .net is: {ex.Message}");
                Console.WriteLine("That message is what is needed, as compared to the uninformative message given in .net 4.72 and earlier.");
                Console.WriteLine();
                Console.WriteLine("GOOD: unlike in .net 4.72 and earlier, .net core 2.2 doesn't automatically close the console window when your code has finished running");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Closing down the window automatically in .net 4.72 and earlier is a nuisance if it means that the window closes before you've been able to look at it.");
                Console.WriteLine("Instead, .net core 2.2 saves you the trouble of having to add e.g. a Console.ReadLine('Press Enter to close the program') line");
                Console.WriteLine("by automatically adding 'Press any key to close this window'. Good!");
            }
        }
    }
}
