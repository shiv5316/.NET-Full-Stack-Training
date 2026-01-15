//using System.Threading;
// Thread thread=new Thread(new ParameterizedThreadStart(PrintMessage));
// thread.Start("Hello from thread");
// static void PrintMessage(object message)
// {
//     Console.WriteLine(message);
// }

// class Program
// {
//     static void Main()
//     {
//         Thread worker=new Thread(DoWork);
//         worker.Start();
//         Console.WriteLine("Main Thread Continues...");
//     }
//     static void DoWork()
//     {
//         for(int i = 0; i <= 5; i++)
//         {
//             Console.WriteLine("Worker Thread: "+i);
//             Thread.Sleep(1000);
//         }
//     }
// }


// using System;
// using System.Threading.Tasks;
// Parallel.For(0, 5, i =>
// {
//     Console.WriteLine($"processing Item {i}");
// });


// using System;
// using System.Threading.Tasks;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[10];
//         for(int i=0;i<numbers.Length;i++)
//             numbers[i] = i + 1;

//         int sum=0;
        // Parallel.For(0, numbers.Length, i =>
        // {
        //     sum+=numbers[i];
        // });
        // Console.WriteLine("Sum: " + sum);


//         Parallel.For(0,numbers.Length,() => 0,
//             (i, loopState, localSum) =>
//             {
//                 return localSum + numbers[i];
//             },

//             localSum =>
//             {
//                 Interlocked.Add(ref sum, localSum);
//             }
//         );

//         Console.WriteLine("Sum = " + sum);
//     }
// }

using System;
using System.IO;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start reading file...");
        string content=await File.ReadAllTextAsync("C:/Users/HP/Desktop/project cmd.txt");
         Console.WriteLine("File content:");
        Console.WriteLine(content);

        Console.WriteLine("End of program");
    }
}