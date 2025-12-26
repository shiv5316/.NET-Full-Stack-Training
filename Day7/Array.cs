<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;

// class Program1
// {
//     public static void calculate()
//     {
//         int[] marks = { 70, 80, 90, 60, 85 };
//         int total = 0;

//         foreach (int m in marks)
//         {
//             total += m;
//         }

//         double average = (double)total / marks.Length;
//         Console.WriteLine("Total = " + total);
//         Console.WriteLine("Average = " + average);
//     }
// }

// class Program2
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         Console.WriteLine("Number is: " + matrix[1, 0]);
//     }
// }

// class Program3
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             {1,4,5},
//             {3,2,6}
//         };
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for(int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i,j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// class Program4
// {
//     public static void calculate()
//     {
//         int[][] jagged=new int[2][];
//         jagged[0] = new int[] { 1, 2 };
//         jagged[1] = new int[] { 3, 4, 5 };
//         for (int i = 0; i < jagged.Length; i++)
//         {
//             for (int j = 0; j < jagged[i].Length; j++)
//             {
//                 Console.Write(jagged[i][j] + " ");
//             }
//             Console.WriteLine();
//             //Console.WriteLine(jagged[1][0]);
//         }
//     }
// }

// class Program5
// {
//     public static void calculate()
//     {
//         int[] numbers={10,20,30,40,50};
//         Array.Clear(numbers,0,numbers.Length);
//          foreach (int n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program6
// {
//     public static void calculate()
//     {
//         int[] src={1,2,3};
//         int[] dest=new int[3];
//         Array.Copy(src,dest,1); //we use 1,2,3 to copy elemets
//         foreach(int n in dest){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program7
// {
//     public static void calculate()
//     {
//         int[] data={1,2,3};
//         Array.Resize(ref data, 5);
//         //Array.Resize(ref data, 2);
//         foreach(int n in data){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         int index = Array.IndexOf(numbers, 30);
//         Console.WriteLine(index);
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         bool found = Array.Exists(numbers, n => n > 40);
//         Console.WriteLine(found);
//     }
// }


// class Program8
// {
//     public static void calculate()
//     {
//         List<int> data=new List<int>();
//         data.Add(10);
//         data.Add(20);
//         data.Add(30);
//         foreach(int n in data){
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         Dictionary<int, string> students = new Dictionary<int, string>();
//         students.Add(1, "Shiv");
//         students.Add(2, "Ansh");
//         foreach (KeyValuePair<int, string> item in students)
//         {
//             Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
//         }
//     }
// }

// using System.Collections.Generic;
// class Program9
// {
//     public static void calculate()
//     {
//         HashSet<int> set=new HashSet<int>();
//         set.Add(1);
//         set.Add(2);
//         set.Add(1);
//         foreach(int n in set)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }


// class Program10
// {
//     public static void calculate()
//     {
//         int[] arr = {1, 2, 3, 2, 1, 4, 2};
//         Dictionary<int, int> freq=new Dictionary<int, int>();
//         foreach(int n in arr)
//         {
//             if(freq.ContainsKey(n))
//                 freq[n]++;
//             else
//                 freq[n]=1;
//         }
//             foreach(var items in freq)
//         {
//             Console.WriteLine("Items: "+items.Key+" -> "+"Freq: "+items.Value);
//         }

//     }
=======
using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;

// class Program1
// {
//     public static void calculate()
//     {
//         int[] marks = { 70, 80, 90, 60, 85 };
//         int total = 0;

//         foreach (int m in marks)
//         {
//             total += m;
//         }

//         double average = (double)total / marks.Length;
//         Console.WriteLine("Total = " + total);
//         Console.WriteLine("Average = " + average);
//     }
// }

// class Program2
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         Console.WriteLine("Number is: " + matrix[1, 0]);
//     }
// }

// class Program3
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             {1,4,5},
//             {3,2,6}
//         };
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for(int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i,j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// class Program4
// {
//     public static void calculate()
//     {
//         int[][] jagged=new int[2][];
//         jagged[0] = new int[] { 1, 2 };
//         jagged[1] = new int[] { 3, 4, 5 };
//         for (int i = 0; i < jagged.Length; i++)
//         {
//             for (int j = 0; j < jagged[i].Length; j++)
//             {
//                 Console.Write(jagged[i][j] + " ");
//             }
//             Console.WriteLine();
//             //Console.WriteLine(jagged[1][0]);
//         }
//     }
// }

// class Program5
// {
//     public static void calculate()
//     {
//         int[] numbers={10,20,30,40,50};
//         Array.Clear(numbers,0,numbers.Length);
//          foreach (int n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program6
// {
//     public static void calculate()
//     {
//         int[] src={1,2,3};
//         int[] dest=new int[3];
//         Array.Copy(src,dest,1); //we use 1,2,3 to copy elemets
//         foreach(int n in dest){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program7
// {
//     public static void calculate()
//     {
//         int[] data={1,2,3};
//         Array.Resize(ref data, 5);
//         //Array.Resize(ref data, 2);
//         foreach(int n in data){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         int index = Array.IndexOf(numbers, 30);
//         Console.WriteLine(index);
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         bool found = Array.Exists(numbers, n => n > 40);
//         Console.WriteLine(found);
//     }
// }


// class Program8
// {
//     public static void calculate()
//     {
//         List<int> data=new List<int>();
//         data.Add(10);
//         data.Add(20);
//         data.Add(30);
//         foreach(int n in data){
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         Dictionary<int, string> students = new Dictionary<int, string>();
//         students.Add(1, "Shiv");
//         students.Add(2, "Ansh");
//         foreach (KeyValuePair<int, string> item in students)
//         {
//             Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
//         }
//     }
// }

// using System.Collections.Generic;
// class Program9
// {
//     public static void calculate()
//     {
//         HashSet<int> set=new HashSet<int>();
//         set.Add(1);
//         set.Add(2);
//         set.Add(1);
//         foreach(int n in set)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }


// class Program10
// {
//     public static void calculate()
//     {
//         int[] arr = {1, 2, 3, 2, 1, 4, 2};
//         Dictionary<int, int> freq=new Dictionary<int, int>();
//         foreach(int n in arr)
//         {
//             if(freq.ContainsKey(n))
//                 freq[n]++;
//             else
//                 freq[n]=1;
//         }
//             foreach(var items in freq)
//         {
//             Console.WriteLine("Items: "+items.Key+" -> "+"Freq: "+items.Value);
//         }

//     }
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;

// class Program1
// {
//     public static void calculate()
//     {
//         int[] marks = { 70, 80, 90, 60, 85 };
//         int total = 0;

//         foreach (int m in marks)
//         {
//             total += m;
//         }

//         double average = (double)total / marks.Length;
//         Console.WriteLine("Total = " + total);
//         Console.WriteLine("Average = " + average);
//     }
// }

// class Program2
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         Console.WriteLine("Number is: " + matrix[1, 0]);
//     }
// }

// class Program3
// {
//     public static void calculate()
//     {
//         int[,] matrix =
//         {
//             {1,4,5},
//             {3,2,6}
//         };
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for(int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i,j]+" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// class Program4
// {
//     public static void calculate()
//     {
//         int[][] jagged=new int[2][];
//         jagged[0] = new int[] { 1, 2 };
//         jagged[1] = new int[] { 3, 4, 5 };
//         for (int i = 0; i < jagged.Length; i++)
//         {
//             for (int j = 0; j < jagged[i].Length; j++)
//             {
//                 Console.Write(jagged[i][j] + " ");
//             }
//             Console.WriteLine();
//             //Console.WriteLine(jagged[1][0]);
//         }
//     }
// }

// class Program5
// {
//     public static void calculate()
//     {
//         int[] numbers={10,20,30,40,50};
//         Array.Clear(numbers,0,numbers.Length);
//          foreach (int n in numbers)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program6
// {
//     public static void calculate()
//     {
//         int[] src={1,2,3};
//         int[] dest=new int[3];
//         Array.Copy(src,dest,1); //we use 1,2,3 to copy elemets
//         foreach(int n in dest){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program7
// {
//     public static void calculate()
//     {
//         int[] data={1,2,3};
//         Array.Resize(ref data, 5);
//         //Array.Resize(ref data, 2);
//         foreach(int n in data){
//         Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         int index = Array.IndexOf(numbers, 30);
//         Console.WriteLine(index);
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         int[] numbers = { 10, 20, 30, 40 };
//         bool found = Array.Exists(numbers, n => n > 40);
//         Console.WriteLine(found);
//     }
// }


// class Program8
// {
//     public static void calculate()
//     {
//         List<int> data=new List<int>();
//         data.Add(10);
//         data.Add(20);
//         data.Add(30);
//         foreach(int n in data){
//             Console.WriteLine(n);
//         }
//     }
// }

// class Program8
// {
//     public static void calculate()
//     {
//         Dictionary<int, string> students = new Dictionary<int, string>();
//         students.Add(1, "Shiv");
//         students.Add(2, "Ansh");
//         foreach (KeyValuePair<int, string> item in students)
//         {
//             Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
//         }
//     }
// }

// using System.Collections.Generic;
// class Program9
// {
//     public static void calculate()
//     {
//         HashSet<int> set=new HashSet<int>();
//         set.Add(1);
//         set.Add(2);
//         set.Add(1);
//         foreach(int n in set)
//         {
//             Console.WriteLine(n);
//         }
//     }
// }


// class Program10
// {
//     public static void calculate()
//     {
//         int[] arr = {1, 2, 3, 2, 1, 4, 2};
//         Dictionary<int, int> freq=new Dictionary<int, int>();
//         foreach(int n in arr)
//         {
//             if(freq.ContainsKey(n))
//                 freq[n]++;
//             else
//                 freq[n]=1;
//         }
//             foreach(var items in freq)
//         {
//             Console.WriteLine("Items: "+items.Key+" -> "+"Freq: "+items.Value);
//         }

//     }
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
// }