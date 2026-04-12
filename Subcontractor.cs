using System;

namespace FinalProject
{
    /// <summary>
    /// Represents a subcontractor. Inherits from Contractor.
    /// Person 3 owns this file — implement ComputePay() to finish.
    /// </summary>
    public class Subcontractor : Contractor
    {
        // Private Fields
        private int    shift;         // 1 = day, 2 = night
        private double hourlyPayRate;

        // Night-shift differential (3%)
        private const double NightShiftDifferential = 0.03;

        // Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Subcontractor() : base()
        {
            shift         = 1;
            hourlyPayRate = 0.0;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        public Subcontractor(string name, string contractorNumber, DateTime startDate,
                             int shift, double hourlyPayRate)
            : base(name, contractorNumber, startDate)
        {
            this.shift         = shift;
            this.hourlyPayRate = hourlyPayRate;
        }

        // Accessors

        public int    GetShift()         => shift;
        public double GetHourlyPayRate() => hourlyPayRate;
        public string GetShiftName()     => shift == 1 ? "Day" : "Night";

        // Mutators

        public void SetShift(int value)
        {
            if (value == 1 || value == 2)
                shift = value;
            else
                Console.WriteLine("Invalid shift. Use 1 (day) or 2 (night).");
        }

        public void SetHourlyPayRate(double value)
        {
            if (value >= 0)
                hourlyPayRate = value;
        }

        // Core Method

        /// <summary>
        /// Computes gross pay for the given number of hours worked.
        /// Night shift employees receive a 3% differential on top of their hourly rate.
        /// </summary>
        /// <param name="hoursWorked">Number of hours worked in the pay period.</param>
        /// <returns>Gross pay as a float.</returns>
        public float ComputePay(double hoursWorked)
        {
            // TODO (Person 3): implement this
            // Hint: effective rate = hourlyPayRate * (1 + NightShiftDifferential) for night shift
            throw new NotImplementedException("Person 3: implement ComputePay()");
        }

        // Utility

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Shift: {GetShiftName()} ({shift})\n" +
                   $"Pay Rate: ${hourlyPayRate:F2}/hr";
        }
    }
}
