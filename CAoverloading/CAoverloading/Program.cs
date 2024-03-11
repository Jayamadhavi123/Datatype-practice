using System;

public class InterestCalculator
{
    public static decimal CalculateInterest(decimal principal, decimal rate, int time, string type)
    {
        decimal interest = 0;

        switch (type.ToLower())
        {
            case "simple":
                interest = principal * rate * time / 100;
                break;
            case "compound":
                interest = principal * (decimal)Math.Pow(1 + (double)(rate / 100), time) - principal;
                break;
            case "saving":
                // Your saving interest calculation logic here
                break;
            case "fixed deposits":
                // Your fixed deposits interest calculation logic here
                break;
            default:
                Console.WriteLine("Invalid interest type.");
                break;
        }

        return interest;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        decimal principal = 545;
        decimal rate = 15; 
        int time = 3; 

        decimal simpleInterest = InterestCalculator.CalculateInterest(principal, rate, time, "simple");
        Console.WriteLine($"Simple Interest: {simpleInterest}");

        decimal compoundInterest = InterestCalculator.CalculateInterest(principal, rate, time, "compound");
        Console.WriteLine($"Compound Interest: {compoundInterest}");
    }
}
