using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    private static void Main(string[] args)
    {
        using Mutex mutex = new Mutex(false, "MutexDemo");
        //Checking if Other External Thread is Running
        if (!mutex.WaitOne(5000, false))
        {
            System.Console.WriteLine("An Instance of the Application is Already Running");
            System.Console.ReadKey();
            return;
        }
        System.Console.WriteLine("Application Is Running.......");
        System.Console.ReadKey();
    }
}
//class Program
//{
//    static void Main()
//    {
//        // Using the iterator method to generate a sequence of numbers
//        foreach (int number in GenerateNumbers(1, 5))
//        {
//            Console.WriteLine(number);
//        }
//    }

//    // Iterator method using the yield keyword
//    static IEnumerable<int> GenerateNumbers(int start, int end)
//    {
//        for (int i = start; i <= end; i++)
//        {
//            // Using the yield keyword to return each value in the sequence
//            yield return i;
//        }
//    }
//}