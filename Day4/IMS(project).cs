<<<<<<< HEAD
<<<<<<< HEAD
using System;
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticate successfully");
    }
}
abstract class InsurancePolicy
{
    public int PolicyNumber{get; init;}
    private double premium;
    public double Premium
    {
        get => premium;
        set
        {
            if(value>0)
            premium=value;
        }
    }
    public string HolderName{get; set;}
    public virtual double CalculatePremium()
    {
        return Premium;
    }
    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}
class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500;
    }
    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}
class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}
class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();
    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }
    public InsurancePolicy this[int index]
    {
        get => policies[index];
    }
    public InsurancePolicy this[string name]
    {
        get => policies.Find(p => p.HolderName == name);
    }
}

class InsuranceValue
{
    public static void calculate()
    {
        Security security = new Security();
        security.Authenticate();
        LifeInsurance life = new LifeInsurance
        {
            PolicyNumber = 101,
            HolderName = "Amit",
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyNumber = 102,
            HolderName = "Neha",
            Premium = 7000
        };
        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);
        Console.WriteLine(directory[0].HolderName);   // Amit
        Console.WriteLine(directory["Neha"].PolicyNumber); // 102
        Console.WriteLine("Life Premium: " + life.CalculatePremium());
        Console.WriteLine("Health Premium: " + health.CalculatePremium());
        life.ShowPolicy();
        InsurancePolicy p = life;
        p.ShowPolicy();
    }
}


=======
using System;
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticate successfully");
    }
}
abstract class InsurancePolicy
{
    public int PolicyNumber{get; init;}
    private double premium;
    public double Premium
    {
        get => premium;
        set
        {
            if(value>0)
            premium=value;
        }
    }
    public string HolderName{get; set;}
    public virtual double CalculatePremium()
    {
        return Premium;
    }
    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}
class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500;
    }
    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}
class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}
class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();
    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }
    public InsurancePolicy this[int index]
    {
        get => policies[index];
    }
    public InsurancePolicy this[string name]
    {
        get => policies.Find(p => p.HolderName == name);
    }
}

class InsuranceValue
{
    public static void calculate()
    {
        Security security = new Security();
        security.Authenticate();
        LifeInsurance life = new LifeInsurance
        {
            PolicyNumber = 101,
            HolderName = "Amit",
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyNumber = 102,
            HolderName = "Neha",
            Premium = 7000
        };
        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);
        Console.WriteLine(directory[0].HolderName);   // Amit
        Console.WriteLine(directory["Neha"].PolicyNumber); // 102
        Console.WriteLine("Life Premium: " + life.CalculatePremium());
        Console.WriteLine("Health Premium: " + health.CalculatePremium());
        life.ShowPolicy();
        InsurancePolicy p = life;
        p.ShowPolicy();
    }
}


>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
=======
using System;
sealed class Security
{
    public void Authenticate()
    {
        Console.WriteLine("User authenticate successfully");
    }
}
abstract class InsurancePolicy
{
    public int PolicyNumber{get; init;}
    private double premium;
    public double Premium
    {
        get => premium;
        set
        {
            if(value>0)
            premium=value;
        }
    }
    public string HolderName{get; set;}
    public virtual double CalculatePremium()
    {
        return Premium;
    }
    public void ShowPolicy()
    {
        Console.WriteLine("Insurance Policy");
    }
}
class LifeInsurance : InsurancePolicy
{
    public override double CalculatePremium()
    {
        return Premium + 500;
    }
    public new void ShowPolicy()
    {
        Console.WriteLine("Life Insurance Policy");
    }
}
class HealthInsurance : InsurancePolicy
{
    public sealed override double CalculatePremium()
    {
        return Premium + 1000;
    }
}
class PolicyDirectory
{
    private List<InsurancePolicy> policies = new List<InsurancePolicy>();
    public void AddPolicy(InsurancePolicy policy)
    {
        policies.Add(policy);
    }
    public InsurancePolicy this[int index]
    {
        get => policies[index];
    }
    public InsurancePolicy this[string name]
    {
        get => policies.Find(p => p.HolderName == name);
    }
}

class InsuranceValue
{
    public static void calculate()
    {
        Security security = new Security();
        security.Authenticate();
        LifeInsurance life = new LifeInsurance
        {
            PolicyNumber = 101,
            HolderName = "Amit",
            Premium = 5000
        };

        HealthInsurance health = new HealthInsurance
        {
            PolicyNumber = 102,
            HolderName = "Neha",
            Premium = 7000
        };
        PolicyDirectory directory = new PolicyDirectory();
        directory.AddPolicy(life);
        directory.AddPolicy(health);
        Console.WriteLine(directory[0].HolderName);   // Amit
        Console.WriteLine(directory["Neha"].PolicyNumber); // 102
        Console.WriteLine("Life Premium: " + life.CalculatePremium());
        Console.WriteLine("Health Premium: " + health.CalculatePremium());
        life.ShowPolicy();
        InsurancePolicy p = life;
        p.ShowPolicy();
    }
}


>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
