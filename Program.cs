using System;
using System.Collections.Generic;

namespace FinalProject
{
    /// <summary>
    /// Adds in subcontractor management 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subcontractor Management System\n");

            List<Subcontractor> subcontractors = new List<Subcontractor>();
            bool addingMore = true;

            while (addingMore)
            {
                Console.WriteLine("Add a New Subcontractor");

                // Name
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                // Contractor number
                Console.Write("Enter contractor number: ");
                string contractorNumber = Console.ReadLine();

                // Start date
                DateTime startDate;
                while (true)
                {
                    Console.Write("Enter start date (MM/DD/YYYY): ");
                    if (DateTime.TryParse(Console.ReadLine(), out startDate))
                        break;
                    Console.WriteLine("Invalid date, please try again.");
                }

                // Shift
                int shift;
                while (true)
                {
                    Console.Write("Enter shift (1 = Day, 2 = Night): ");
                    if (int.TryParse(Console.ReadLine(), out shift) && (shift == 1 || shift == 2))
                        break;
                    Console.WriteLine("Invalid shift. Please enter 1 or 2.");
                }

                // Hourly pay rate
                double hourlyPayRate;
                while (true)
                {
                    Console.Write("Enter hourly pay rate: $");
                    if (double.TryParse(Console.ReadLine(), out hourlyPayRate) && hourlyPayRate >= 0)
                        break;
                    Console.WriteLine("Invalid pay rate. Please enter a positive number.");
                }

                // Certificate number
                Console.Write("Enter certificate number (or press Enter to leave as Pending): ");
                string certificateNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(certificateNumber))
                    certificateNumber = "Pending";
                
                // Create the subcontractor and add to the list
                Subcontractor sub = new Subcontractor(name, contractorNumber, startDate,
                shift, hourlyPayRate, certificateNumber);
                subcontractors.Add(sub);

                Console.WriteLine("\nSubcontractor added successfully!");

                Console.Write("\nAdd another subcontractor? (y/n): ");
                string answer = Console.ReadLine()?.Trim().ToLower();
                addingMore = answer == "y";
            }

            // Display all subcontractors and their computed pay
            Console.WriteLine("\nSubcontractor Summary\n");

            Console.Write("Enter hours worked this pay period: ");
            if (double.TryParse(Console.ReadLine(), out double hours))
            {
                foreach (Subcontractor sub in subcontractors)
                {
                    Console.WriteLine(sub.ToString());
                    Console.WriteLine($"Gross Pay ({hours} hrs): ${sub.ComputePay(hours):F2}");
                    Console.WriteLine(new string('-', 40));
                }
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
