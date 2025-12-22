<<<<<<< HEAD
<<<<<<< HEAD
﻿// using System;

// class Program
// {
//     static void Main()
//     {
//         SavingsAccount acc1 = new SavingsAccount();

//         acc1.AccNum = 101;
//         acc1.Balance = 10000;

//         acc1.ShowDetails();   
//         acc1.ShowInterest();  
//     }
// }


// public class Bankacc
// {
//     public int AccNum;
//     public double Balance;

//     public void ShowDetails()
//     {
//         Console.WriteLine("Account Number: " + AccNum);
//         Console.WriteLine("Balance: " + Balance);
//     }
// }


// public class SavingsAccount : Bankacc
// {
//     public double InterestRate = 4.5;

//     public void ShowInterest()
//     {
//         Console.WriteLine("Interest Rate: " + InterestRate + "%");
//     }
// }

// using System;

// class Demo
// {
//     static int x;

//     // Static constructor
//     static Demo()
//     {
//         x = 10;
//         Console.WriteLine("Static constructor called");
//     }

//     static void Main()
//     {
//         Console.WriteLine("Value of x = " + x);
//     }
// }


// using System;

// class Product
// {
//     public string Name;
//     public int Price;

    
//     public Product() { }

    
//     public Product(string name, int price)
//     {
//         Name = name;
//         Price = price;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Product p = new Product
//         {
//             Name = "Laptop",
//             Price = 50000
//         };

//         Console.WriteLine("Product Name: " + p.Name);
//         Console.WriteLine("Product Price: " + p.Price);
//     }
//}





// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 90;

//         // Display data
//         Console.WriteLine("Student Name is : " + s.Name);
//         Console.WriteLine("Student Age is  : " + s.Age);
//         Console.WriteLine("Student Marksare : " + s.Marks);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.StudentID = 101;

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 85;

//         s.Password = "secure123";

//         Console.WriteLine("Student ID    : " + s.StudentID);
//         Console.WriteLine("Student Name  : " + s.Name);
//         Console.WriteLine("Student Age   : " + s.Age);
//         Console.WriteLine("Student Marks : " + s.Marks);
//         Console.WriteLine("Result Status : " + s.ResultStatus);
//     }
// }

// using System;


// class Program
// {
//     static void Main()
//     {
//         Library library = new Library();
//         library[101] = "C# Basics";
//         library[102] = "Java Programming";
//         library[103] = "Python for Beginners";
//         Console.WriteLine(library[101]);
//         Console.WriteLine(library[102]);
//         Console.WriteLine(library["C# Basics"]);
//         Console.WriteLine(library["Data Science"]);
//     }
// }


// using System;

// class Person
// {
//     public string Name;

//     public Person(string name)
//     {
//         Name = name;
//     }
// }

// class Student : Person
// {
//     public int RollNo;

//     public Student(string name, int roll) : base(name)
//     {
//         RollNo = roll;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student("Amit", 101);

//         Console.WriteLine("Name   : " + s.Name);
//         Console.WriteLine("RollNo : " + s.RollNo);
//     }
// }

using System;

class Program
{
    public static void Main()
    {
        InsuranceValue.calculate(); 
    }
}
=======
﻿// using System;

// class Program
// {
//     static void Main()
//     {
//         SavingsAccount acc1 = new SavingsAccount();

//         acc1.AccNum = 101;
//         acc1.Balance = 10000;

//         acc1.ShowDetails();   
//         acc1.ShowInterest();  
//     }
// }


// public class Bankacc
// {
//     public int AccNum;
//     public double Balance;

//     public void ShowDetails()
//     {
//         Console.WriteLine("Account Number: " + AccNum);
//         Console.WriteLine("Balance: " + Balance);
//     }
// }


// public class SavingsAccount : Bankacc
// {
//     public double InterestRate = 4.5;

//     public void ShowInterest()
//     {
//         Console.WriteLine("Interest Rate: " + InterestRate + "%");
//     }
// }

// using System;

// class Demo
// {
//     static int x;

//     // Static constructor
//     static Demo()
//     {
//         x = 10;
//         Console.WriteLine("Static constructor called");
//     }

//     static void Main()
//     {
//         Console.WriteLine("Value of x = " + x);
//     }
// }


// using System;

// class Product
// {
//     public string Name;
//     public int Price;

    
//     public Product() { }

    
//     public Product(string name, int price)
//     {
//         Name = name;
//         Price = price;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Product p = new Product
//         {
//             Name = "Laptop",
//             Price = 50000
//         };

//         Console.WriteLine("Product Name: " + p.Name);
//         Console.WriteLine("Product Price: " + p.Price);
//     }
//}





// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 90;

//         // Display data
//         Console.WriteLine("Student Name is : " + s.Name);
//         Console.WriteLine("Student Age is  : " + s.Age);
//         Console.WriteLine("Student Marksare : " + s.Marks);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.StudentID = 101;

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 85;

//         s.Password = "secure123";

//         Console.WriteLine("Student ID    : " + s.StudentID);
//         Console.WriteLine("Student Name  : " + s.Name);
//         Console.WriteLine("Student Age   : " + s.Age);
//         Console.WriteLine("Student Marks : " + s.Marks);
//         Console.WriteLine("Result Status : " + s.ResultStatus);
//     }
// }

// using System;


// class Program
// {
//     static void Main()
//     {
//         Library library = new Library();
//         library[101] = "C# Basics";
//         library[102] = "Java Programming";
//         library[103] = "Python for Beginners";
//         Console.WriteLine(library[101]);
//         Console.WriteLine(library[102]);
//         Console.WriteLine(library["C# Basics"]);
//         Console.WriteLine(library["Data Science"]);
//     }
// }


// using System;

// class Person
// {
//     public string Name;

//     public Person(string name)
//     {
//         Name = name;
//     }
// }

// class Student : Person
// {
//     public int RollNo;

//     public Student(string name, int roll) : base(name)
//     {
//         RollNo = roll;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student("Amit", 101);

//         Console.WriteLine("Name   : " + s.Name);
//         Console.WriteLine("RollNo : " + s.RollNo);
//     }
// }

using System;

class Program
{
    public static void Main()
    {
        InsuranceValue.calculate(); 
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
﻿// using System;

// class Program
// {
//     static void Main()
//     {
//         SavingsAccount acc1 = new SavingsAccount();

//         acc1.AccNum = 101;
//         acc1.Balance = 10000;

//         acc1.ShowDetails();   
//         acc1.ShowInterest();  
//     }
// }


// public class Bankacc
// {
//     public int AccNum;
//     public double Balance;

//     public void ShowDetails()
//     {
//         Console.WriteLine("Account Number: " + AccNum);
//         Console.WriteLine("Balance: " + Balance);
//     }
// }


// public class SavingsAccount : Bankacc
// {
//     public double InterestRate = 4.5;

//     public void ShowInterest()
//     {
//         Console.WriteLine("Interest Rate: " + InterestRate + "%");
//     }
// }

// using System;

// class Demo
// {
//     static int x;

//     // Static constructor
//     static Demo()
//     {
//         x = 10;
//         Console.WriteLine("Static constructor called");
//     }

//     static void Main()
//     {
//         Console.WriteLine("Value of x = " + x);
//     }
// }


// using System;

// class Product
// {
//     public string Name;
//     public int Price;

    
//     public Product() { }

    
//     public Product(string name, int price)
//     {
//         Name = name;
//         Price = price;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Product p = new Product
//         {
//             Name = "Laptop",
//             Price = 50000
//         };

//         Console.WriteLine("Product Name: " + p.Name);
//         Console.WriteLine("Product Price: " + p.Price);
//     }
//}





// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 90;

//         // Display data
//         Console.WriteLine("Student Name is : " + s.Name);
//         Console.WriteLine("Student Age is  : " + s.Age);
//         Console.WriteLine("Student Marksare : " + s.Marks);
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student();

//         s.StudentID = 101;

//         s.Name = "Shivansh";
//         s.Age = 20;
//         s.Marks = 85;

//         s.Password = "secure123";

//         Console.WriteLine("Student ID    : " + s.StudentID);
//         Console.WriteLine("Student Name  : " + s.Name);
//         Console.WriteLine("Student Age   : " + s.Age);
//         Console.WriteLine("Student Marks : " + s.Marks);
//         Console.WriteLine("Result Status : " + s.ResultStatus);
//     }
// }

// using System;


// class Program
// {
//     static void Main()
//     {
//         Library library = new Library();
//         library[101] = "C# Basics";
//         library[102] = "Java Programming";
//         library[103] = "Python for Beginners";
//         Console.WriteLine(library[101]);
//         Console.WriteLine(library[102]);
//         Console.WriteLine(library["C# Basics"]);
//         Console.WriteLine(library["Data Science"]);
//     }
// }


// using System;

// class Person
// {
//     public string Name;

//     public Person(string name)
//     {
//         Name = name;
//     }
// }

// class Student : Person
// {
//     public int RollNo;

//     public Student(string name, int roll) : base(name)
//     {
//         RollNo = roll;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Student s = new Student("Amit", 101);

//         Console.WriteLine("Name   : " + s.Name);
//         Console.WriteLine("RollNo : " + s.RollNo);
//     }
// }

using System;

class Program
{
    public static void Main()
    {
        InsuranceValue.calculate(); 
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
