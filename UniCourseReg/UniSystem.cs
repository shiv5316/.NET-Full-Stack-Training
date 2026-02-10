using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if(AvailableCourses.ContainsKey(code))
            throw new ArgumentException("Course code already exixts");
            Course course=new Course(code,name,credits,maxCapacity,prerequisites);
            AvailableCourses.Add(code,course);
            
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if(Students.ContainsKey(id))
            throw new ArgumentException("Student Id already exists");
            Student student=new Student(id,name,major,maxCredits,completedCourses);
            Students.Add(id,student);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found");
                return false;
            }
            if (!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course not found");
                return false;
            }
            Student student=Students[studentId];
            Course course=AvailableCourses[courseCode];
            if (student.AddCourse(course))
            {
                Console.WriteLine("Course registered successfully");
                return true;
            }
            else
            {
                Console.WriteLine("Course registration failed");
                return false;
            }
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found");
                return false;
            }
            return Students[studentId].DropCourse(courseCode);
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach (var course in AvailableCourses.Values)
            {
                Console.WriteLine(course.Code+" - "+course.Name+" - "+course.Credits+" credits - "+course.GetEnrollmentInfo());
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found");
                return;
            }
            Students[studentId].DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            int totalStudents=Students.Count;
            int totalCourses=AvailableCourses.Count;
            int totalEnrollment=0;
            foreach(var course in AvailableCourses.Values)
            {
                totalEnrollment+=course.CurrentEnrollment;
            }
            double averageEnrollment=totalCourses>0 ?(double)totalEnrollment/totalCourses:0;
            Console.WriteLine("Total Students: "+totalStudents);
            Console.WriteLine("Total Courses: "+totalCourses);
            Console.WriteLine("Average Enrollment: "+averageEnrollment);
        }
    }
}
