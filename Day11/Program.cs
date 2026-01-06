<<<<<<< HEAD
﻿// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Creating Objects......");
//         for(int i = 0; i < 10; i++)
//         {
//             MyClass obj=new MyClass();
//         }
//         Console.WriteLine("Forcing Garbage Collection....");
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//         Console.WriteLine("Garbage Collection Completed.");
//     }
// }

// class MyClass
// {
//     ~MyClass()
//     {
//         Console.WriteLine("Finalizer called,Object Collected.");
//     }
// }

/*
using System;
class Program
{
    static void Main()
    {
        (int, string) student1=(101,"Shivansh");
        Console.WriteLine(student1.Item1);
        Console.WriteLine(student1.Item2);
        //var student2=(ID:101,Name:"Shivansh");
        // Console.WriteLine(student1.ID);
        // Console.WriteLine(student1.Name);
    }
}
*/

//#####################################################################################################
// using System;
// class Program
// {
//     static void Main()
//     {
//         var result = Calculate(10, 5);

//         Console.WriteLine("Sum = " + result.sum);
//         Console.WriteLine("Average = " + result.average);
//         Console.WriteLine("Difference = " + result.difference);
//     }    
//         static(int sum ,int average,int difference) Calculate(int a,int b)
//         {
//             return(a+b,(a+b)/2,a-b);
//         }
    
// }


//##############################################################################################################
// using System;
// using System.Net;
// class Program
// {
//     static void Main()
//     {
//         var response = ValidateUser("Shivansh");

//         Console.WriteLine(response.Message);
//     }    
//         static(bool IsValid,string Message) ValidateUser(string username)
//         {
//             if(string.IsNullOrEmpty(username))
//             return(false,"Username is required");
//             return(true,"Valid User");
//         }
    
// }

//#####################################################################################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         var person=(Id:101, Name:"Shivansh");
//         Console.WriteLine(person.Id);
//         var(ID,Name2)=person;
//         Console.WriteLine(ID);
//         ID.GetType();
//     }
// }


// using System;
// class Program
// {
//     static void Main()
//     {
//         Program1.Calculate();
//     }    
//}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (int i = 0; i < 10000; i++)
        {
            object obj = new object();
        }

        Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
    }
=======
﻿// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Creating Objects......");
//         for(int i = 0; i < 10; i++)
//         {
//             MyClass obj=new MyClass();
//         }
//         Console.WriteLine("Forcing Garbage Collection....");
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//         Console.WriteLine("Garbage Collection Completed.");
//     }
// }

// class MyClass
// {
//     ~MyClass()
//     {
//         Console.WriteLine("Finalizer called,Object Collected.");
//     }
// }

/*
using System;
class Program
{
    static void Main()
    {
        (int, string) student1=(101,"Shivansh");
        Console.WriteLine(student1.Item1);
        Console.WriteLine(student1.Item2);
        //var student2=(ID:101,Name:"Shivansh");
        // Console.WriteLine(student1.ID);
        // Console.WriteLine(student1.Name);
    }
}
*/

//#####################################################################################################
// using System;
// class Program
// {
//     static void Main()
//     {
//         var result = Calculate(10, 5);

//         Console.WriteLine("Sum = " + result.sum);
//         Console.WriteLine("Average = " + result.average);
//         Console.WriteLine("Difference = " + result.difference);
//     }    
//         static(int sum ,int average,int difference) Calculate(int a,int b)
//         {
//             return(a+b,(a+b)/2,a-b);
//         }
    
// }


//##############################################################################################################
// using System;
// using System.Net;
// class Program
// {
//     static void Main()
//     {
//         var response = ValidateUser("Shivansh");

//         Console.WriteLine(response.Message);
//     }    
//         static(bool IsValid,string Message) ValidateUser(string username)
//         {
//             if(string.IsNullOrEmpty(username))
//             return(false,"Username is required");
//             return(true,"Valid User");
//         }
    
// }

//#####################################################################################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         var person=(Id:101, Name:"Shivansh");
//         Console.WriteLine(person.Id);
//         var(ID,Name2)=person;
//         Console.WriteLine(ID);
//         ID.GetType();
//     }
// }


// using System;
// class Program
// {
//     static void Main()
//     {
//         Program1.Calculate();
//     }    
//}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (int i = 0; i < 10000; i++)
        {
            object obj = new object();
        }

        Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
    }
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
}