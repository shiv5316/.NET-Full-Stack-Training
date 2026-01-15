// using System.Reflection;
// using System;
// class Program
// {
//     static void Main()
//     {
//         Assembly assembly = Assembly.GetExecutingAssembly();
//         //Assembly.Load(assembly);
//         Assembly.LoadFrom("Day15.dll");
//         Console.WriteLine("Assembly Full Name: " + assembly.FullName);
//     }
// }


// using System;
// using System.Reflection;

// class Employee
// {
//     public string Name { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         // 1. Create object normally
//         Employee emp = new Employee();

//         // 2. Get Type information of Employee class
//         Type type = typeof(Employee);

//         // 3. Get PropertyInfo for "Name" property
//         PropertyInfo prop = type.GetProperty("Name");

//         // 4. Set value of Name property using Reflection
//         prop.SetValue(emp, "Shivansh");

//         // 5. Get value of Name property using Reflection
//         object value = prop.GetValue(emp);

//         // 6. Print result
//         Console.WriteLine("Property Name: " + prop.Name);
//         Console.WriteLine("Property Type: " + prop.PropertyType);
//         Console.WriteLine("Value inside property: " + value);
//     }
// }




// using System;
// using System.Reflection;

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public void Work()
//     {
//         Console.WriteLine("Employee working");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Type type = typeof(Employee);

//         Console.WriteLine("Class Name: " + type.Name);
//         Console.WriteLine("Namespace: " + type.Namespace);

//         Console.WriteLine("\nProperties:");
//         foreach (PropertyInfo prop in type.GetProperties())
//         {
//             Console.WriteLine($"{prop.Name} - {prop.PropertyType}");
//         }

//         Console.WriteLine("\nMethods:");
//         foreach (MethodInfo method in type.GetMethods())
//         {
//             Console.WriteLine(method.Name);
//         }
//     }
// }


