using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case "1": // Add Course
                            Console.Write("Enter course code: ");
                            string ccode = Console.ReadLine();

                            Console.Write("Enter course name: ");
                            string cname = Console.ReadLine();

                            Console.Write("Enter credits: ");
                            int credits = int.Parse(Console.ReadLine());

                            Console.Write("Enter max capacity: ");
                            int capacity = int.Parse(Console.ReadLine());

                            Console.Write("Enter prerequisites (comma separated or blank): ");
                            string pre = Console.ReadLine();
                            List<string> preList = string.IsNullOrWhiteSpace(pre) 
                                ? new List<string>() 
                                : pre.Split(',').Select(x => x.Trim()).ToList();

                            system.AddCourse(ccode, cname, credits, capacity, preList);
                            Console.WriteLine("Course added successfully");
                            break;

                        case "2": 
                            Console.Write("Enter student ID: ");
                            string sid = Console.ReadLine();

                            Console.Write("Enter name: ");
                            string sname = Console.ReadLine();

                            Console.Write("Enter major: ");
                            string major = Console.ReadLine();

                            Console.Write("Enter max credits: ");
                            int maxCredits = int.Parse(Console.ReadLine());

                            Console.Write("Enter completed courses (comma separated or blank): ");
                            string comp = Console.ReadLine();
                            List<string> compList = string.IsNullOrWhiteSpace(comp)
                                ? new List<string>()
                                : comp.Split(',').Select(x => x.Trim()).ToList();

                            system.AddStudent(sid, sname, major, maxCredits, compList);
                            Console.WriteLine("Student added successfully");
                            break;

                        case "3": 
                            Console.Write("Enter student ID: ");
                            string rsid = Console.ReadLine();

                            Console.Write("Enter course code: ");
                            string rccode = Console.ReadLine();

                            system.RegisterStudentForCourse(rsid, rccode);
                            break;

                        case "4": 
                            Console.Write("Enter student ID: ");
                            string dsid = Console.ReadLine();

                            Console.Write("Enter course code: ");
                            string dccode = Console.ReadLine();

                            if (system.DropStudentFromCourse(dsid, dccode))
                                Console.WriteLine("Course dropped successfully");
                            else
                                Console.WriteLine("Drop failed");
                            break;

                        case "5": 
                            system.DisplayAllCourses();
                            break;

                        case "6": 
                            Console.Write("Enter student ID: ");
                            string ssid = Console.ReadLine();
                            system.DisplayStudentSchedule(ssid);
                            break;

                        case "7": 
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}


