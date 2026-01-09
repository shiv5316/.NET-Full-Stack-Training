<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;

public delegate bool IsEligibleforScholarship(Student std);
public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public char SportsGrade { get; set; }
    public static string GetEligibleStudents(List<Student> studentsList,IsEligibleforScholarship isEligible)
    {
        List<string> names = new List<string>();
        foreach (Student s in studentsList)
        {
            if (isEligible(s))
            {
                names.Add(s.Name);
            }
        }
        return string.Join(", ", names);
    }
}
public class Program1
{
        public static bool ScholarshipEligibility(Student std)
    {
        return std.Marks > 80 && std.SportsGrade == 'A';
    }
    public static void calculate()
    {
        List<Student> lstStudents = new List<Student>();

        lstStudents.Add(new Student { RollNo = 1, Name = "Raj", Marks = 75, SportsGrade = 'A' });
        lstStudents.Add(new Student { RollNo = 2, Name = "Rahul", Marks = 82, SportsGrade = 'A' });
        lstStudents.Add(new Student { RollNo = 3, Name = "Kiran", Marks = 89, SportsGrade = 'B' });
        lstStudents.Add(new Student { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' });

        IsEligibleforScholarship del = ScholarshipEligibility;
        string result = Student.GetEligibleStudents(lstStudents, del);
        Console.WriteLine(result);
    }
}
=======
using System;
using System.Collections.Generic;
using System.Linq;

public delegate bool IsEligibleforScholarship(Student std);
public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public char SportsGrade { get; set; }
    public static string GetEligibleStudents(List<Student> studentsList,IsEligibleforScholarship isEligible)
    {
        List<string> names = new List<string>();
        foreach (Student s in studentsList)
        {
            if (isEligible(s))
            {
                names.Add(s.Name);
            }
        }
        return string.Join(", ", names);
    }
}
public class Program1
{
        public static bool ScholarshipEligibility(Student std)
    {
        return std.Marks > 80 && std.SportsGrade == 'A';
    }
    public static void calculate()
    {
        List<Student> lstStudents = new List<Student>();

        lstStudents.Add(new Student { RollNo = 1, Name = "Raj", Marks = 75, SportsGrade = 'A' });
        lstStudents.Add(new Student { RollNo = 2, Name = "Rahul", Marks = 82, SportsGrade = 'A' });
        lstStudents.Add(new Student { RollNo = 3, Name = "Kiran", Marks = 89, SportsGrade = 'B' });
        lstStudents.Add(new Student { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' });

        IsEligibleforScholarship del = ScholarshipEligibility;
        string result = Student.GetEligibleStudents(lstStudents, del);
        Console.WriteLine(result);
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
