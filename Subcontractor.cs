using System;

namespace FinalProject
{
    public class Subcontractor : Contractor
    {
        private int shift; // 1 = day, 2 = night
        private double hourlyPayRate;
        private string certificateNumber; // Added new field

        private const double NightShiftDifferential = 0.03;

        public Subcontractor() : base()
        {
            shift = 1;
            hourlyPayRate = 0.0;
            certificateNumber = "Pending";
        }

        public Subcontractor(string name, string contractorNumber, DateTime startDate,
                             int shift, double hourlyPayRate, string certificateNumber)
            : base(name, contractorNumber, startDate)
        {
            this.shift = shift;
            this.hourlyPayRate = hourlyPayRate;
            this.certificateNumber = certificateNumber;
        }

        // Accessors
        public int GetShift() => shift;
        public double GetHourlyPayRate() => hourlyPayRate;
        public string GetShiftName() => shift == 1 ? "Day" : "Night";
        public string GetCertificateNumber() => certificateNumber;

        // Mutators
        public void SetShift(int value)
        {
            if (value == 1 || value == 2) shift = value;
        }

        public void SetCertificateNumber(string value) => certificateNumber = value;

        /// <summary>
        /// Computes gross pay with a 3% shift differential for night shift.
        /// </summary>
        public float ComputePay(double hoursWorked)
        {
            double basePay = hoursWorked * hourlyPayRate;

            if (shift == 2)
            {
                // Apply 3% differential: (Rate * 1.03) * hours
                basePay += (basePay * NightShiftDifferential);
            }

            return (float)basePay;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                   $"Shift: {GetShiftName()} ({shift})\n" +
                   $"Pay Rate: ${hourlyPayRate:F2}/hr\n" +
                   $"Cert #: {certificateNumber}";
        }
    }
}