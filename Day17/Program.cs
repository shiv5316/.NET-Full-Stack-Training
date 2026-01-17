// using System;
// using System.Diagnostics;
// using System.Threading;
// using System.Threading.Tasks;
// class Program
// {
//     static async Task Main()
//     {

//         Task t1 = Task.Run(()=>Console.WriteLine("Task 1"));
//         Task t2 = Task.Run(()=>Console.WriteLine("Task 2"));

//         Task.WhenAll(t1,t2).ContinueWith(t => Console.WriteLine("All tasks completed"));
//     }


//     static void PrintMessage(object message)
//     {
//         Console.WriteLine(message);
//     }

//     static void DoWork()
//     {
//         Console.WriteLine("Befor");
//         for(int i=1;i<=5; i++)
//         {
//             Console.WriteLine("Worker thread : " + i);
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine("After");
//     }
// }


using System;
class Program
{
static void Main()
{
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);

Dictionary<int, String> dict=new Dictionary<int, String>();
dict.Add(1,"One");
Console.WriteLine(dict[1]);
}
}