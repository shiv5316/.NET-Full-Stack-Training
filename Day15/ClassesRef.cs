// using System;
// using System.Reflection;

// namespace ReflectionDemo
// {
//     class Employee
//     {
//         public string Name { get; set; }
//         private double _salary = 30000;
//         public void Work()
//         {
//             Console.WriteLine("Employee is working");
//         }
//         public void ShowSalary()
//         {
//             Console.WriteLine("Salary: " + _salary);
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Assembly executingAssembly = Assembly.GetExecutingAssembly();
//             Console.WriteLine("Executing Assembly:");
//             Console.WriteLine(executingAssembly.FullName);
//             Console.WriteLine();

//             // Load Assemblies
//             // Load assembly by name (must be in app folder or GAC)
//             //Assembly.Load("MyLibrary");   // Uncomment if library exists
//             // Load assembly from file path
//             // Assembly.LoadFrom("MyPlugin.dll"); // Uncomment if DLL exists            
//             //  Get Type in ALL Possible Ways
            
//             Type type1 = typeof(Employee);
//             Employee emp = new Employee();
//             Type type2 = emp.GetType();
//             Type type3 = Type.GetType("MyApp.Models.Employee");

//             Console.WriteLine("Type Names:");
//             Console.WriteLine(type1.FullName);
//             Console.WriteLine(type2.FullName);
//             Console.WriteLine(type3.FullName);
//             Console.WriteLine();
           

//             MethodInfo method = type1.GetMethod("Work");
//             method.Invoke(emp, null);   // Calls emp.Work()

//             Console.WriteLine();

          
//             // PropertyInfo - Set Property Value
           

//             PropertyInfo prop = type1.GetProperty("Name");
//             prop.SetValue(emp, "John");

//             Console.WriteLine("Employee Name: " + emp.Name);
//             Console.WriteLine();

          
//             // FieldInfo - Access Private Field using BindingFlags
          

//             FieldInfo field = type1.GetField(
//                 "_salary",
//                 BindingFlags.NonPublic | BindingFlags.Instance
//             );

//             Console.WriteLine("Original Salary:");
//             emp.ShowSalary();

//             // Modify private field value
//             field.SetValue(emp, 50000);

//             Console.WriteLine("Updated Salary:");
//             emp.ShowSalary();

//             Console.WriteLine("\nProgram finished successfully");
//         }
//     }
// }