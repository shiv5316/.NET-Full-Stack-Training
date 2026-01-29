// using System;
// using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         List<int> divby2=new List<int>();
//         List<int> divby3=new List<int>();
//         List<int> notdiv=new List<int>();
//         for(int i = 1;i<=100; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 divby2.Add(i);
//             }else if (i % 3 == 0)
//             {
//                 divby3.Add(i);
//             }
//             else
//             {
//                 notdiv.Add(i);
//             }
//         }
//         Console.WriteLine(string.Join(",",divby2));
//         Console.WriteLine(string.Join(",",divby3));
//         Console.WriteLine(string.Join(",",notdiv));
//     }
// }


/// ############################################################################################
// using System;

// public interface ICar
// {
//     void Gear1();
//     void Gear2();
//     void Gear3();
//     void Gear4();
//     void Gear5();
//     void ReverseGear();
// }

// class ShivMotors : ICar
// {
//     public void Gear1()
//     {
//         Console.WriteLine("1st gear");
//     }

//     public void Gear2()
//     {
//         Console.WriteLine("2nd gear");
//     }

//     public void Gear3()
//     {
//         Console.WriteLine("3rd gear");
//     }

//     public void Gear4()
//     {
//         Console.WriteLine("4th gear");
//     }

//     public void Gear5()
//     {
//         Console.WriteLine("5th gear");
//     }

//     public void ReverseGear()
//     {
//         Console.WriteLine("Reverse gear");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         ICar car = new ShivMotors();
//         car.Gear1();
//         car.Gear2();
//         car.Gear3();
//         car.Gear4();
//         car.Gear5();
//         car.ReverseGear();
//     }
// }

// ############################################################################################
// using System;
// abstract class Nano
// {
//     public abstract void Gear1();
//     public abstract void Gear2();
//     public void MusicSystem()
//     {
//         Console.WriteLine("Music system ");
//     }
//     public void BackCamera()
//     {
//         Console.WriteLine("Back Camera");
//     }
// }
// class TataNano : Nano
// {
//     public override void Gear1()
//     {
//         Console.WriteLine("Gear 1 applied");
//     }

//     public override void Gear2()
//     {
//         Console.WriteLine("Gear 2 applied");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         TataNano car1=new TataNano();
//         car1.Gear1();
//         car1.Gear2();
//         car1.MusicSystem();
//         car1.BackCamera();
//     }
// }

// ############################################################################################
// using System;
// delegate int Operation(int a, int b);
// class Program
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static int Subtract(int a, int b)
//     {
//         return a - b;
//     }
//     static void Main()
//     {
//         Operation op=Add;
//         Console.WriteLine("Addition: " + op(10, 5));
//         op=Subtract;
//         Console.WriteLine("Subtraction: " + op(10, 5));
//     }
// }

using System;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main()
        {
            // Load DLL
            Assembly asm = Assembly.LoadFrom("D:\\CSharp-Training\\Practice\\bin\\Debug\\net10.0\\Practice.dll");

            Console.WriteLine("ASSEMBLY LOADED\n");

            // Get all types (classes + interfaces)
            Type[] types = asm.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"Type: {type.Name}");

                // List interfaces used
                foreach (Type iface in type.GetInterfaces())
                {
                    Console.WriteLine($"  Interface: {iface.Name}");
                }

                // List methods
                foreach (MethodInfo method in type.GetMethods(
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly))
                {
                    Console.WriteLine($"  Method: {method.Name}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
