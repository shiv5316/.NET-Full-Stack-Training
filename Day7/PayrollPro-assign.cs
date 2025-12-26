<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class EmployeeRecord
{
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }
    
    public abstract double GetMonthlyPay();
}

public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return (totalHours * HourlyRate) + MonthlyBonus;
    }
}

public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return totalHours * HourlyRate;
    }
}

public class PayRollPro
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();
    
    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }
    
    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> overtimeCount = new Dictionary<string, int>();
        
        foreach (EmployeeRecord emp in records)
        {
            int count = 0;
            foreach (double hours in emp.WeeklyHours)
            {
                if (hours >= hoursThreshold)
                    count++;
            }
            if (count > 0)
                overtimeCount[emp.EmployeeName] = count;
        }
        return overtimeCount;
    }
    
    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;
            
        double totalPay = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
        {
            totalPay += emp.GetMonthlyPay(); // Polymorphism!
        }
        return totalPay / PayrollBoard.Count;
    }
    
    public static void calculate()
    {
        PayRollPro payroll = new PayRollPro();
        
        while (true)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
                string type = Console.ReadLine();
                
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Enter Hourly Rate: ");
                double rate = double.Parse(Console.ReadLine());
                
                double[] hours = new double[4];
                Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    hours[i] = double.Parse(Console.ReadLine());
                }
                
                EmployeeRecord emp;
                if (type == "1")
                {
                    Console.Write("Enter Monthly Bonus: ");
                    double bonus = double.Parse(Console.ReadLine());
                    
                    emp = new FullTimeEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate, 
                        MonthlyBonus = bonus 
                    };
                }
                else
                {
                    emp = new ContractEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate 
                    };
                }
                
                payroll.RegisterEmployee(emp);
                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == "2")
            {
                Console.Write("Enter hours threshold: ");
                double threshold = double.Parse(Console.ReadLine());
                
                var overtime = payroll.GetOvertimeWeekCounts(PayrollBoard, threshold);
                if (overtime.Count == 0)
                {
                    Console.WriteLine("No overtime recorded this month");
                }
                else
                {
                    foreach (var item in overtime)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
            }
            else if (choice == "3")
            {
                double avg = payroll.CalculateAverageMonthlyPay();
                Console.WriteLine("Overall average monthly pay: " + avg);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Logging off --- Payroll processed successfully!");
                break;
            }
        }
    }
}
=======
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class EmployeeRecord
{
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }
    
    public abstract double GetMonthlyPay();
}

public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return (totalHours * HourlyRate) + MonthlyBonus;
    }
}

public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return totalHours * HourlyRate;
    }
}

public class PayRollPro
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();
    
    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }
    
    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> overtimeCount = new Dictionary<string, int>();
        
        foreach (EmployeeRecord emp in records)
        {
            int count = 0;
            foreach (double hours in emp.WeeklyHours)
            {
                if (hours >= hoursThreshold)
                    count++;
            }
            if (count > 0)
                overtimeCount[emp.EmployeeName] = count;
        }
        return overtimeCount;
    }
    
    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;
            
        double totalPay = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
        {
            totalPay += emp.GetMonthlyPay(); // Polymorphism!
        }
        return totalPay / PayrollBoard.Count;
    }
    
    public static void calculate()
    {
        PayRollPro payroll = new PayRollPro();
        
        while (true)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
                string type = Console.ReadLine();
                
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Enter Hourly Rate: ");
                double rate = double.Parse(Console.ReadLine());
                
                double[] hours = new double[4];
                Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    hours[i] = double.Parse(Console.ReadLine());
                }
                
                EmployeeRecord emp;
                if (type == "1")
                {
                    Console.Write("Enter Monthly Bonus: ");
                    double bonus = double.Parse(Console.ReadLine());
                    
                    emp = new FullTimeEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate, 
                        MonthlyBonus = bonus 
                    };
                }
                else
                {
                    emp = new ContractEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate 
                    };
                }
                
                payroll.RegisterEmployee(emp);
                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == "2")
            {
                Console.Write("Enter hours threshold: ");
                double threshold = double.Parse(Console.ReadLine());
                
                var overtime = payroll.GetOvertimeWeekCounts(PayrollBoard, threshold);
                if (overtime.Count == 0)
                {
                    Console.WriteLine("No overtime recorded this month");
                }
                else
                {
                    foreach (var item in overtime)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
            }
            else if (choice == "3")
            {
                double avg = payroll.CalculateAverageMonthlyPay();
                Console.WriteLine("Overall average monthly pay: " + avg);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Logging off --- Payroll processed successfully!");
                break;
            }
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class EmployeeRecord
{
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }
    
    public abstract double GetMonthlyPay();
}

public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return (totalHours * HourlyRate) + MonthlyBonus;
    }
}

public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    
    public override double GetMonthlyPay()
    {
        double totalHours = WeeklyHours.Sum();
        return totalHours * HourlyRate;
    }
}

public class PayRollPro
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();
    
    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }
    
    public Dictionary<string, int> GetOvertimeWeekCounts(List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> overtimeCount = new Dictionary<string, int>();
        
        foreach (EmployeeRecord emp in records)
        {
            int count = 0;
            foreach (double hours in emp.WeeklyHours)
            {
                if (hours >= hoursThreshold)
                    count++;
            }
            if (count > 0)
                overtimeCount[emp.EmployeeName] = count;
        }
        return overtimeCount;
    }
    
    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;
            
        double totalPay = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
        {
            totalPay += emp.GetMonthlyPay(); // Polymorphism!
        }
        return totalPay / PayrollBoard.Count;
    }
    
    public static void calculate()
    {
        PayRollPro payroll = new PayRollPro();
        
        while (true)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Select Employee Type (1-Full Time, 2-Contract): ");
                string type = Console.ReadLine();
                
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Enter Hourly Rate: ");
                double rate = double.Parse(Console.ReadLine());
                
                double[] hours = new double[4];
                Console.WriteLine("Enter weekly hours (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    hours[i] = double.Parse(Console.ReadLine());
                }
                
                EmployeeRecord emp;
                if (type == "1")
                {
                    Console.Write("Enter Monthly Bonus: ");
                    double bonus = double.Parse(Console.ReadLine());
                    
                    emp = new FullTimeEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate, 
                        MonthlyBonus = bonus 
                    };
                }
                else
                {
                    emp = new ContractEmployee 
                    { 
                        EmployeeName = name, 
                        WeeklyHours = hours, 
                        HourlyRate = rate 
                    };
                }
                
                payroll.RegisterEmployee(emp);
                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == "2")
            {
                Console.Write("Enter hours threshold: ");
                double threshold = double.Parse(Console.ReadLine());
                
                var overtime = payroll.GetOvertimeWeekCounts(PayrollBoard, threshold);
                if (overtime.Count == 0)
                {
                    Console.WriteLine("No overtime recorded this month");
                }
                else
                {
                    foreach (var item in overtime)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value);
                    }
                }
            }
            else if (choice == "3")
            {
                double avg = payroll.CalculateAverageMonthlyPay();
                Console.WriteLine("Overall average monthly pay: " + avg);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Logging off --- Payroll processed successfully!");
                break;
            }
        }
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
