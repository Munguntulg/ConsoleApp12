using System;
using System.Collections.Generic;
using TooniiMachine.Undsen;
using TooniiMachie.MemoryApp;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();
            Memory memory = new Memory();

            Console.WriteLine("Welcome to the interactive calculator!");
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1: Add");
                Console.WriteLine("2: Subtract");
                Console.WriteLine("3: Multiply");
                Console.WriteLine("4: Divide");
                Console.WriteLine("5: Store result in memory");
                Console.WriteLine("6: View memory contents");
                Console.WriteLine("7: Exit");
                Console.WriteLine("8: Reset memory"); 

                string input = Console.ReadLine();
                double value;

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a number to add: ");
                        if (double.TryParse(Console.ReadLine(), out value))
                        {
                            calculator.Add(value);
                            Console.WriteLine($"Result: {calculator.Result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter a number to subtract: ");
                        if (double.TryParse(Console.ReadLine(), out value))
                        {
                            calculator.Subtract(value);
                            Console.WriteLine($"Result: {calculator.Result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter a number to multiply: ");
                        if (double.TryParse(Console.ReadLine(), out value))
                        {
                            calculator.Multiply(value);
                            Console.WriteLine($"Result: {calculator.Result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter a number to divide: ");
                        if (double.TryParse(Console.ReadLine(), out value))
                        {
                            calculator.Divide(value);
                            Console.WriteLine($"Result: {calculator.Result}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "5":
                        memory.Store(calculator.Result);
                        Console.WriteLine("Result stored in memory.");
                        break;

                    case "6":
                        Console.WriteLine("Memory Contents:");
                        foreach (var item in memory.GetMemoryItems())
                        {
                            Console.WriteLine(item.Value);
                        }
                        break;

                    case "7":
                        running = false;
                        Console.WriteLine("Exiting program.");
                        break;

                    case "8":  
                        memory.Clear();  
                        Console.WriteLine("Memory has been cleared.");
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please choose a valid option.");
                        break;
                }
            }

        }
    }
}
