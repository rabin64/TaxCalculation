// See https://aka.ms/new-console-template for more information

using TaxCalculation;
using System;

public class Program
{   
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CalculateTax calculateTax = new CalculateTax();
       // double totalTax = calculateTax.CalculateAdditionalTotalTax(400, 1500);
        double totalTax = calculateTax.CalculateAdditionalTotalTax(1100, 7000);
        //double totalTax = calculateTax.CalculateAdditionalTotalTax(5000, 3000);

        Console.WriteLine($"Total Tax: {totalTax:F2}");
    }
}