// using System;
// using System.Diagnostics;
// class Program1
// {
//     public static void calculate()
//     {
//         Process currentProcess=Process.GetCurrentProcess();
//         Console.WriteLine("Current Process ID: " + currentProcess.Id);
//         Console.WriteLine("Process Name: " + currentProcess.ProcessName);
//     }
// }


// using System;
// using System.Threading;
// class Program1
// {
//     static int counter = 0;
//     public static void calculate()
//     {
//         Thread t1 = new Thread(Increment);
//         Thread t2 = new Thread(Increment);
//         t1.Start();
//         t2.Start();
//         // t1.Join();
//         // t2.Join();
//         Console.WriteLine("Final Counter Value: " + counter);
//     }
//     static void Increment()
//     {
//         for (int i = 0; i < 1000; i++)
//         {
//             counter++;
//         }
//     }
// }

//########################3 Synchronization Using lock ##################endregion

using System;
using System.Threading;
class Program1
{
    static int counter = 0;
    static object lockObj = new object();
    public static void calculate()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);
        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter Value: " + counter);
    }
    static void Increment()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObj)
            {
                counter++;
            }
        }
    }
}

