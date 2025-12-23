<<<<<<< HEAD
<<<<<<< HEAD
using System;

namespace HospitalSystem
{
    // TASK 10
    class HospitalInit
    {
        public const string HospitalName = "City Care Hospital";

        static HospitalInit()
        {
            Console.WriteLine("Hospital System Booting...");
        }
    }

    // TASK 2
    class Patient
    {
        public int PatientId { get; }
        public string Name { get; set; } = "";
        public int Age { get; set; }

        private string medicalHistory = "";

        public Patient(int id)
        {
            PatientId = id;
        }

        public void SetMedicalHistory(string history)
        {
            medicalHistory = history;
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }
    }

    // TASK 3
    class Doctor
    {
        public static int TotalDoctors;
        public readonly string LicenseNumber;
        public string Name { get; set; } = "";

        static Doctor()
        {
            TotalDoctors = 0;
        }

        public Doctor(string license)
        {
            LicenseNumber = license;
            TotalDoctors++;
        }
    }

    // TASK 4
    class Appointment
    {
        public void Schedule(Patient p, Doctor d)
        {
            Console.WriteLine($"Appointment Scheduled: {p.Name} with Dr. {d.Name}");
        }

        public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
        {
            Console.WriteLine($"Appointment: {p.Name} with Dr. {d.Name}");
            Console.WriteLine($"Date: {date:dd MMM yyyy} | Mode: {mode}");
        }
    }

    // TASK 5
    class DiagnosisService
    {
        public static void Evaluate(
            in int age,
            ref string condition,
            out string riskLevel,
            params int[] testScores)
        {
            int sum = 0;
            foreach (int score in testScores)
                sum += score;

            static bool IsCritical(int total) => total > 250;

            if (IsCritical(sum) || age > 60)
            {
                condition = "Serious";
                riskLevel = "High";
            }
            else
            {
                riskLevel = "Moderate";
            }
        }
    }

    // TASK 6
    class Billing
    {
        public double ConsultationFee { get; set; }
        public double TestCharges { get; set; }
        public double RoomCharges { get; set; }

        public double Total()
        {
            return ConsultationFee + TestCharges + RoomCharges;
        }
    }

    // TASK 7
    class InsuranceService
    {
        public static double ApplyCoverage(double billAmount, int coveragePercent)
        {
            double discount = billAmount * coveragePercent / 100;
            return billAmount - discount;
        }
    }

    // TASK 8
    class StayCalculator
    {
        public static int CalculateStayDays(int days)
        {
            if (days <= 0)
                return 0;
            return 1 + CalculateStayDays(days - 1);
        }
    }

    // TASK 9
    class InputHelper
    {
        public static int ReadAge(string input)
        {
            if (!int.TryParse(input, out int age))
                throw new Exception("Invalid Input");
            return age;
        }
    }

    // TASK 11
    class Program
    {
        static void Main()
        {
            try
            {
                HospitalInit init = new HospitalInit();

                Console.Write("Enter Patient ID: ");
                int pid = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Patient Name: ");
                string pname = Console.ReadLine()!;

                Console.Write("Enter Patient Age: ");
                int age = InputHelper.ReadAge(Console.ReadLine()!);

                Patient patient = new Patient(pid)
                {
                    Name = pname,
                    Age = age
                };

                Console.Write("Enter Medical History: ");
                patient.SetMedicalHistory(Console.ReadLine()!);

                Console.Write("Enter Doctor Name: ");
                string dname = Console.ReadLine()!;

                Console.Write("Enter License Number: ");
                string lic = Console.ReadLine()!;

                Doctor doctor = new Doctor(lic) { Name = dname };

                Appointment app = new Appointment();
                app.Schedule(patient, doctor, DateTime.Now);

                string condition = "Normal";
                string risk;

                int patientAge = patient.Age;   // ✅ FIXED HERE

                DiagnosisService.Evaluate(
                    in patientAge,
                    ref condition,
                    out risk,
                    90, 85, 95
                );

                Console.WriteLine($"Condition: {condition}");
                Console.WriteLine($"Risk Level: {risk}");

                Billing bill = new Billing
                {
                    ConsultationFee = 500,
                    TestCharges = 1200,
                    RoomCharges = 2000
                };

                double totalBill = bill.Total();

                Console.Write("Enter Insurance Coverage %: ");
                int coverage = int.Parse(Console.ReadLine()!);

                double payable = InsuranceService.ApplyCoverage(totalBill, coverage);

                Console.WriteLine($"Final Payable Amount: ₹{payable}");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
    
}
=======
//### Hospital management System 

using System;

namespace HospitalSystem
{
    // TASK 10
    class HospitalInit
    {
        public const string HospitalName = "City Care Hospital";

        static HospitalInit()
        {
            Console.WriteLine("Hospital System Booting...");
        }
    }

    // TASK 2
    class Patient
    {
        public int PatientId { get; }
        public string Name { get; set; } = "";
        public int Age { get; set; }

        private string medicalHistory = "";

        public Patient(int id)
        {
            PatientId = id;
        }

        public void SetMedicalHistory(string history)
        {
            medicalHistory = history;
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }
    }

    // TASK 3
    class Doctor
    {
        public static int TotalDoctors;
        public readonly string LicenseNumber;
        public string Name { get; set; } = "";

        static Doctor()
        {
            TotalDoctors = 0;
        }

        public Doctor(string license)
        {
            LicenseNumber = license;
            TotalDoctors++;
        }
    }

    // TASK 4
    class Appointment
    {
        public void Schedule(Patient p, Doctor d)
        {
            Console.WriteLine($"Appointment Scheduled: {p.Name} with Dr. {d.Name}");
        }

        public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
        {
            Console.WriteLine($"Appointment: {p.Name} with Dr. {d.Name}");
            Console.WriteLine($"Date: {date:dd MMM yyyy} | Mode: {mode}");
        }
    }

    // TASK 5
    class DiagnosisService
    {
        public static void Evaluate(
            in int age,
            ref string condition,
            out string riskLevel,
            params int[] testScores)
        {
            int sum = 0;
            foreach (int score in testScores)
                sum += score;

            static bool IsCritical(int total) => total > 250;

            if (IsCritical(sum) || age > 60)
            {
                condition = "Serious";
                riskLevel = "High";
            }
            else
            {
                riskLevel = "Moderate";
            }
        }
    }

    // TASK 6
    class Billing
    {
        public double ConsultationFee { get; set; }
        public double TestCharges { get; set; }
        public double RoomCharges { get; set; }

        public double Total()
        {
            return ConsultationFee + TestCharges + RoomCharges;
        }
    }

    // TASK 7
    class InsuranceService
    {
        public static double ApplyCoverage(double billAmount, int coveragePercent)
        {
            double discount = billAmount * coveragePercent / 100;
            return billAmount - discount;
        }
    }

    // TASK 8
    class StayCalculator
    {
        public static int CalculateStayDays(int days)
        {
            if (days <= 0)
                return 0;
            return 1 + CalculateStayDays(days - 1);
        }
    }

    // TASK 9
    class InputHelper
    {
        public static int ReadAge(string input)
        {
            if (!int.TryParse(input, out int age))
                throw new Exception("Invalid Input");
            return age;
        }
    }

    // TASK 11
    class Program
    {
        static void Main()
        {
            try
            {
                HospitalInit init = new HospitalInit();

                Console.Write("Enter Patient ID: ");
                int pid = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Patient Name: ");
                string pname = Console.ReadLine()!;

                Console.Write("Enter Patient Age: ");
                int age = InputHelper.ReadAge(Console.ReadLine()!);

                Patient patient = new Patient(pid)
                {
                    Name = pname,
                    Age = age
                };

                Console.Write("Enter Medical History: ");
                patient.SetMedicalHistory(Console.ReadLine()!);

                Console.Write("Enter Doctor Name: ");
                string dname = Console.ReadLine()!;

                Console.Write("Enter License Number: ");
                string lic = Console.ReadLine()!;

                Doctor doctor = new Doctor(lic) { Name = dname };

                Appointment app = new Appointment();
                app.Schedule(patient, doctor, DateTime.Now);

                string condition = "Normal";
                string risk;

                int patientAge = patient.Age;   // ✅ FIXED HERE

                DiagnosisService.Evaluate(
                    in patientAge,
                    ref condition,
                    out risk,
                    90, 85, 95
                );

                Console.WriteLine($"Condition: {condition}");
                Console.WriteLine($"Risk Level: {risk}");

                Billing bill = new Billing
                {
                    ConsultationFee = 500,
                    TestCharges = 1200,
                    RoomCharges = 2000
                };

                double totalBill = bill.Total();

                Console.Write("Enter Insurance Coverage %: ");
                int coverage = int.Parse(Console.ReadLine()!);

                double payable = InsuranceService.ApplyCoverage(totalBill, coverage);

                Console.WriteLine($"Final Payable Amount: ₹{payable}");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
//### Hospital management System 

using System;

namespace HospitalSystem
{
    // TASK 10
    class HospitalInit
    {
        public const string HospitalName = "City Care Hospital";

        static HospitalInit()
        {
            Console.WriteLine("Hospital System Booting...");
        }
    }

    // TASK 2
    class Patient
    {
        public int PatientId { get; }
        public string Name { get; set; } = "";
        public int Age { get; set; }

        private string medicalHistory = "";

        public Patient(int id)
        {
            PatientId = id;
        }

        public void SetMedicalHistory(string history)
        {
            medicalHistory = history;
        }

        public string GetMedicalHistory()
        {
            return medicalHistory;
        }
    }

    // TASK 3
    class Doctor
    {
        public static int TotalDoctors;
        public readonly string LicenseNumber;
        public string Name { get; set; } = "";

        static Doctor()
        {
            TotalDoctors = 0;
        }

        public Doctor(string license)
        {
            LicenseNumber = license;
            TotalDoctors++;
        }
    }

    // TASK 4
    class Appointment
    {
        public void Schedule(Patient p, Doctor d)
        {
            Console.WriteLine($"Appointment Scheduled: {p.Name} with Dr. {d.Name}");
        }

        public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
        {
            Console.WriteLine($"Appointment: {p.Name} with Dr. {d.Name}");
            Console.WriteLine($"Date: {date:dd MMM yyyy} | Mode: {mode}");
        }
    }

    // TASK 5
    class DiagnosisService
    {
        public static void Evaluate(
            in int age,
            ref string condition,
            out string riskLevel,
            params int[] testScores)
        {
            int sum = 0;
            foreach (int score in testScores)
                sum += score;

            static bool IsCritical(int total) => total > 250;

            if (IsCritical(sum) || age > 60)
            {
                condition = "Serious";
                riskLevel = "High";
            }
            else
            {
                riskLevel = "Moderate";
            }
        }
    }

    // TASK 6
    class Billing
    {
        public double ConsultationFee { get; set; }
        public double TestCharges { get; set; }
        public double RoomCharges { get; set; }

        public double Total()
        {
            return ConsultationFee + TestCharges + RoomCharges;
        }
    }

    // TASK 7
    class InsuranceService
    {
        public static double ApplyCoverage(double billAmount, int coveragePercent)
        {
            double discount = billAmount * coveragePercent / 100;
            return billAmount - discount;
        }
    }

    // TASK 8
    class StayCalculator
    {
        public static int CalculateStayDays(int days)
        {
            if (days <= 0)
                return 0;
            return 1 + CalculateStayDays(days - 1);
        }
    }

    // TASK 9
    class InputHelper
    {
        public static int ReadAge(string input)
        {
            if (!int.TryParse(input, out int age))
                throw new Exception("Invalid Input");
            return age;
        }
    }

    // TASK 11
    class Program
    {
        static void Main()
        {
            try
            {
                HospitalInit init = new HospitalInit();

                Console.Write("Enter Patient ID: ");
                int pid = int.Parse(Console.ReadLine()!);

                Console.Write("Enter Patient Name: ");
                string pname = Console.ReadLine()!;

                Console.Write("Enter Patient Age: ");
                int age = InputHelper.ReadAge(Console.ReadLine()!);

                Patient patient = new Patient(pid)
                {
                    Name = pname,
                    Age = age
                };

                Console.Write("Enter Medical History: ");
                patient.SetMedicalHistory(Console.ReadLine()!);

                Console.Write("Enter Doctor Name: ");
                string dname = Console.ReadLine()!;

                Console.Write("Enter License Number: ");
                string lic = Console.ReadLine()!;

                Doctor doctor = new Doctor(lic) { Name = dname };

                Appointment app = new Appointment();
                app.Schedule(patient, doctor, DateTime.Now);

                string condition = "Normal";
                string risk;

                int patientAge = patient.Age;   // ✅ FIXED HERE

                DiagnosisService.Evaluate(
                    in patientAge,
                    ref condition,
                    out risk,
                    90, 85, 95
                );

                Console.WriteLine($"Condition: {condition}");
                Console.WriteLine($"Risk Level: {risk}");

                Billing bill = new Billing
                {
                    ConsultationFee = 500,
                    TestCharges = 1200,
                    RoomCharges = 2000
                };

                double totalBill = bill.Total();

                Console.Write("Enter Insurance Coverage %: ");
                int coverage = int.Parse(Console.ReadLine()!);

                double payable = InsuranceService.ApplyCoverage(totalBill, coverage);

                Console.WriteLine($"Final Payable Amount: ₹{payable}");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
