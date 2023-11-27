using System;

class PowerBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Power Bill Calculator!");

       
        Console.Write("Enter the power consumption in kWh: ");
        if (!double.TryParse(Console.ReadLine(), out double powerConsumption) || powerConsumption < 0)
        {
            Console.WriteLine("Invalid input. Power consumption must be a non-negative number.");
            return;
        }

        Console.WriteLine("Select the type of usage:");
        Console.WriteLine("1. Residential (KES per kWh = 12.50)");
        Console.WriteLine("2. Commercial (KES per kWh = 15.75)");
        Console.WriteLine("3. Industrial (KES per kWh = 18.90)");
        Console.Write("Enter the usage type (1, 2, or 3): ");

        if (!int.TryParse(Console.ReadLine(), out int usageType) || usageType < 1 || usageType > 3)
        {
            Console.WriteLine("Invalid input. Please enter a valid usage type (1, 2, or 3).");
            return;
        }

       
        double costPerKWh = 0.0;

        switch (usageType)
        {
            case 1:
                costPerKWh = 12.50;
                break;
            case 2: // Commercial
                costPerKWh = 15.75;
                break;
            case 3: // Industrial
                costPerKWh = 18.90;
                break;
        }

        double totalCost = powerConsumption * costPerKWh;

        Console.WriteLine($"\nBilling Summary:");
        Console.WriteLine($"Power Consumption: {powerConsumption} kWh");
        Console.WriteLine($"Cost per kWh: KES {costPerKWh}");
        Console.WriteLine($"Total Power Bill: KES {totalCost}");

        Console.WriteLine("\nFor more information, refer to the README document.");

        
    }
}