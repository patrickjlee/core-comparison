using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Divide by zero (and other maths errors) are hard to detect in .net 4.72 and earlier!");
                Console.WriteLine("------------------------------------------------------------------------------------");
                var x = 1.1d;
                var zero = 0.0d;
                var y = x / zero;
                Console.WriteLine("We shouldn't get here because we should have a divide by zero (y = 1.1/0), but we do, and y is infinity: " + y);
                var a = y + 3;
                Console.WriteLine("Calculations have continued under .net when they shouldn't have, because they have now become meaningless, a (= y + 3) is also infinity: " + a);
                Console.WriteLine("And we won't know when the problem first occurred!");
                Console.WriteLine("Worse, we may not even be aware that a problem has occurred (e.g. if this is an unattended process)!");
                Console.WriteLine();
                Console.WriteLine("These and other math problems can be solved in .net 4.72 by using custom functions (e.g. SafeDivide, SafeLog, SafeExp)");
                Console.WriteLine("But this is a nuisance!");

                Console.WriteLine();
                Console.WriteLine("Asking for a dictionary item for a non existent key gives uninformative error message in .net 4.72 and earlier!");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                var dictionary = new Dictionary<int, int>();
                var z = dictionary[2];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception was thrown, the message under .net is: {ex.Message}");
                Console.WriteLine("That message is nowhere near as informative as it should be, it should say: The given key (2) was not present in the dictionary.");
                Console.WriteLine();
                Console.WriteLine("This (and similar problems) can be solved in .net 4.82 by writing an Extension to .net's standard Dictionary to give more informative error messages");
                Console.WriteLine("But this is a nuisance!");
                Console.WriteLine();
                Console.WriteLine("Press Enter to close the program");
                Console.ReadLine();
            }
        }
    }
}
