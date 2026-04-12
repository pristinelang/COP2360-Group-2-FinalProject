using System;

namespace FinalProject
{
    /// <summary>
    /// Base class representing a general contractor.
    /// </summary>
    public class Contractor
    {
        // Private Fields
        private string name;
        private string contractorNumber;
        private DateTime startDate;

        // Constructors

        /// <summary>
        /// Default constructor — initializes fields to safe defaults.
        /// </summary>
        public Contractor()
        {
            name             = "Unknown";
            contractorNumber = "N/A";
            startDate        = DateTime.Today;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        public Contractor(string name, string contractorNumber, DateTime startDate)
        {
            this.name             = name;
            this.contractorNumber = contractorNumber;
            this.startDate        = startDate;
        }

        // Accessors

        public string GetName()             => name;
        public string GetContractorNumber() => contractorNumber;
        public DateTime GetStartDate()      => startDate;

        // Mutators

        public void SetName(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }

        public void SetContractorNumber(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                contractorNumber = value;
        }

        public void SetStartDate(DateTime value) => startDate = value;

        // Utility

        public override string ToString()
        {
            return $"Name: {name}\n" +
                   $"Contractor #: {contractorNumber}\n" +
                   $"Start Date: {startDate:MM/dd/yyyy}";
        }
    }
}
