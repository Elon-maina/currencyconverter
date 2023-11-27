using System;

class SewerageBillCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Sewerage Bill Calculator!");

        // User Input
        Console.Write("Enter amout of water used per cubic metre: ");
        if (!double.TryParse(Console.ReadLine(), out double waterConsumption) || waterConsumption < 0)
        {
            Console.WriteLine("Invalid input. water consumption must be a non-negative number.");
            return;
        }

        Console.WriteLine("Select the type of usage:");
        Console.WriteLine("1. Residential (KES per cubic meter of water = 10.00)");
        Console.WriteLine("2. Commercial (KES per cubic meter of water= 12.50)");
        Console.WriteLine("3. Industrial (KES per cubic meter of water = 15.00)");
        Console.Write("Enter the usage type (1, 2, or 3): ");

        if (!int.TryParse(Console.ReadLine(), out int usageType) || usageType < 1 || usageType > 3)
        {
            Console.WriteLine("Invalid input. Please enter a valid usage type (1, 2, or 3).");
            return;
        }

        // Billing Algorithm
        double costPercubicmeterofwaterused = 0.0;

        switch (usageType)
        {
            case 1: // Residential
                costPercubicmeterofwaterused = 10.00;
                break;
            case 2: // Commercial
                costPercubicmeterofwaterused = 12.50;
                break;
            case 3: // Industrial
                costPercubicmeterofwaterused = 15.00;
                break;
        }

        double totalCost = waterConsumption * costPercubicmeterofwaterused;

       
        Console.WriteLine($"\nBilling Summary:");
        Console.WriteLine($"Water Consumption: {waterConsumption} cubicmeterofwaterused");
        Console.WriteLine($"Cost per kWh: KES {costPercubicmeterofwaterused}");
        Console.WriteLine($"Total Power Bill: KES {totalCost}");

        Console.WriteLine("\nFor more information, refer to the README document.");
    }
}