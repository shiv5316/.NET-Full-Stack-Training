<<<<<<< HEAD
<<<<<<< HEAD
using System;
using System.Runtime.InteropServices;

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;

    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;
}

class Program1
{
    static PatientBill LastBill = null;
    static bool HasLastBill = false;

    public static void calculate()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateBill();
                    break;

                case 2:
                    ViewBill();
                    break;

                case 3:
                    ClearBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
    public static void CreateBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bill.BillId))

        {
            Console.WriteLine("Bill ID cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();
        if (!bill.PatientName.All(char.IsLetter))
        {
            Console.WriteLine("Patient name Invalid");
            return;
        }

        Console.Write("Is the patient insured? (Y/N): ");
        char ins = Console.ReadLine().ToUpper()[0];
        bill.HasInsurance = (ins == 'Y');

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.ConsultationFee) || bill.ConsultationFee <= 0)
        {
            Console.WriteLine("Invalid consultation fee.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.LabCharges) || bill.LabCharges < 0)
        {
            Console.WriteLine("Invalid lab charges.");
            return;
        }
        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.MedicineCharges) || bill.MedicineCharges < 0)
        {
            Console.WriteLine("Invalid medicine charges.");
            return;
        }
        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance)
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        else
            bill.DiscountAmount = 0;

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
    }
    public static void ViewBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
    }
    public static void ClearBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}
=======
using System;
using System.Runtime.InteropServices;

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;

    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;
}

class Program1
{
    static PatientBill LastBill = null;
    static bool HasLastBill = false;

    public static void calculate()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateBill();
                    break;

                case 2:
                    ViewBill();
                    break;

                case 3:
                    ClearBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
    public static void CreateBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bill.BillId))

        {
            Console.WriteLine("Bill ID cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();
        if (!bill.PatientName.All(char.IsLetter))
        {
            Console.WriteLine("Patient name Invalid");
            return;
        }

        Console.Write("Is the patient insured? (Y/N): ");
        char ins = Console.ReadLine().ToUpper()[0];
        bill.HasInsurance = (ins == 'Y');

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.ConsultationFee) || bill.ConsultationFee <= 0)
        {
            Console.WriteLine("Invalid consultation fee.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.LabCharges) || bill.LabCharges < 0)
        {
            Console.WriteLine("Invalid lab charges.");
            return;
        }
        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.MedicineCharges) || bill.MedicineCharges < 0)
        {
            Console.WriteLine("Invalid medicine charges.");
            return;
        }
        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance)
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        else
            bill.DiscountAmount = 0;

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
    }
    public static void ViewBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
    }
    public static void ClearBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
using System.Runtime.InteropServices;

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;

    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;
}

class Program1
{
    static PatientBill LastBill = null;
    static bool HasLastBill = false;

    public static void calculate()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (!valid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateBill();
                    break;

                case 2:
                    ViewBill();
                    break;

                case 3:
                    ClearBill();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
    public static void CreateBill()
    {
        PatientBill bill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        bill.BillId = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(bill.BillId))

        {
            Console.WriteLine("Bill ID cannot be empty.");
            return;
        }

        Console.Write("Enter Patient Name: ");
        bill.PatientName = Console.ReadLine();
        if (!bill.PatientName.All(char.IsLetter))
        {
            Console.WriteLine("Patient name Invalid");
            return;
        }

        Console.Write("Is the patient insured? (Y/N): ");
        char ins = Console.ReadLine().ToUpper()[0];
        bill.HasInsurance = (ins == 'Y');

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.ConsultationFee) || bill.ConsultationFee <= 0)
        {
            Console.WriteLine("Invalid consultation fee.");
            return;
        }

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.LabCharges) || bill.LabCharges < 0)
        {
            Console.WriteLine("Invalid lab charges.");
            return;
        }
        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.MedicineCharges) || bill.MedicineCharges < 0)
        {
            Console.WriteLine("Invalid medicine charges.");
            return;
        }
        bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

        if (bill.HasInsurance)
            bill.DiscountAmount = bill.GrossAmount * 0.10m;
        else
            bill.DiscountAmount = 0;

        bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

        LastBill = bill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine($"Gross Amount: {bill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {bill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {bill.FinalPayable:F2}");
    }
    public static void ViewBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
    }
    public static void ClearBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }
}
>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
