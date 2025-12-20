using System;
class Employee
{
    public string Name;
    public double Salary;
    public void Display()
    {
        Console.WriteLine(Name + " earns " + Salary);
    }
}

class EmpSal
{
    public static void calculate()
    {
        Employee emp1 = new Employee();
        emp1.Name = "Shivansh";
        emp1.Salary = 90000;
        emp1.Display();

    }
}