using System;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Console.WriteLine(EvaluateExpression(expression));
    }

    public static string EvaluateExpression(string expression)
    {
        // Step 1: Check format
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        string[] parts = expression.Split(' ');

        // Must be exactly: a op b
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        string aStr = parts[0];
        string op = parts[1];
        string bStr = parts[2];

        // Step 2: Validate numbers
        if (!int.TryParse(aStr, out int a) || !int.TryParse(bStr, out int b))
            return "Error:InvalidNumber";

        // Step 3: Perform operation
        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }
}
