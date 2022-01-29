using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = allNames
                => Console.WriteLine(string.Join(Environment.NewLine, allNames));

            string[] names = Console.ReadLine().Split();

            printNames(names);
        }
    }
}
