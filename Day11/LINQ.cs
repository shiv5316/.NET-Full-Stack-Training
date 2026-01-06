<<<<<<< HEAD
/*
using System;
using System.Linq;
class Program1
{
    public static void Calculate()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        // var evenNumbers = numbers.Where(n => n % 2 == 0);
        // evenNumbers.GetType();
        // Console.WriteLine("Even numbers are:");
        // foreach (var n in evenNumbers)
        // {
        //     Console.WriteLine(n);
        // }


        // // LINQ Method Syntax
        // var methodResult = numbers.Where(n => n > 3).Select(n => n * 2);

        // Console.WriteLine("Method Syntax Output:");
        // foreach (var n in methodResult)
        // {
        //     Console.WriteLine(n);
        // }

        // // LINQ Query Syntax
        // var queryResult=from n in numbers where n > 3 select n * 2;

        // Console.WriteLine("\nQuery Syntax Output:");
        // foreach (var n in queryResult)
        // {
        //     Console.WriteLine(n);
        // }


*/


using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
     public string Name { get; set; }
    public int Marks { get; set; }
}

class Program1
{
    public static void Calculate()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Utkarsh", Marks = 75 },
            new Student { Name = "Anand", Marks = 45 },
            new Student { Name = "Shivansh", Marks = 82 }
        };
        var ascending = students.OrderBy(s => s.Marks);

        Console.WriteLine("Marks in Ascending Order:");
        foreach (var s in ascending)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // Descending order by Marks
        var descending = students.OrderByDescending(s => s.Marks);

        Console.WriteLine("\nMarks in Descending Order:");
        foreach (var s in descending)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }



    //     var result = students.Select(s => new
    //     {
    //         s.Name,
    //         Grade = s.Marks > 60 ? "Pass" : "Fail"
    //     }).ToList();
    //     result.GetType();

    //     Console.WriteLine("Student Result:");
    //     foreach (var item in result)
    //     {
    //         Console.WriteLine($"Name: {item.Name}, Grade: {item.Grade}");
    //     }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;

class Program1
{
    public static void Calculate()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
        var ascending = numbers.OrderBy(n => n);
        var descending = numbers.OrderByDescending(n => n);

        Console.WriteLine("Ascending:");
        foreach (var n in ascending)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nDescending:");
        foreach (var n in descending)
        {
            Console.WriteLine(n);
        }
    }
}
*/
=======
/*
using System;
using System.Linq;
class Program1
{
    public static void Calculate()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        // var evenNumbers = numbers.Where(n => n % 2 == 0);
        // evenNumbers.GetType();
        // Console.WriteLine("Even numbers are:");
        // foreach (var n in evenNumbers)
        // {
        //     Console.WriteLine(n);
        // }


        // // LINQ Method Syntax
        // var methodResult = numbers.Where(n => n > 3).Select(n => n * 2);

        // Console.WriteLine("Method Syntax Output:");
        // foreach (var n in methodResult)
        // {
        //     Console.WriteLine(n);
        // }

        // // LINQ Query Syntax
        // var queryResult=from n in numbers where n > 3 select n * 2;

        // Console.WriteLine("\nQuery Syntax Output:");
        // foreach (var n in queryResult)
        // {
        //     Console.WriteLine(n);
        // }


*/


using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
     public string Name { get; set; }
    public int Marks { get; set; }
}

class Program1
{
    public static void Calculate()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Utkarsh", Marks = 75 },
            new Student { Name = "Anand", Marks = 45 },
            new Student { Name = "Shivansh", Marks = 82 }
        };
        var ascending = students.OrderBy(s => s.Marks);

        Console.WriteLine("Marks in Ascending Order:");
        foreach (var s in ascending)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }

        // Descending order by Marks
        var descending = students.OrderByDescending(s => s.Marks);

        Console.WriteLine("\nMarks in Descending Order:");
        foreach (var s in descending)
        {
            Console.WriteLine($"{s.Name} - {s.Marks}");
        }



    //     var result = students.Select(s => new
    //     {
    //         s.Name,
    //         Grade = s.Marks > 60 ? "Pass" : "Fail"
    //     }).ToList();
    //     result.GetType();

    //     Console.WriteLine("Student Result:");
    //     foreach (var item in result)
    //     {
    //         Console.WriteLine($"Name: {item.Name}, Grade: {item.Grade}");
    //     }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;

class Program1
{
    public static void Calculate()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 3 };
        var ascending = numbers.OrderBy(n => n);
        var descending = numbers.OrderByDescending(n => n);

        Console.WriteLine("Ascending:");
        foreach (var n in ascending)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("\nDescending:");
        foreach (var n in descending)
        {
            Console.WriteLine(n);
        }
    }
}
*/
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
