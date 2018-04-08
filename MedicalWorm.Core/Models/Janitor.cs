using System;
using System.Configuration;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Janitor : IEmployee
    {
        public string ExternalAgencyId { get; set; }

        public string ExternalAgencyName { get; set; }

        public string Name { get; set; }

        public decimal HoursWorked { get; set; }

        public string PrintBadge()
        {
            return $"{Name}, {ExternalAgencyName}, {ExternalAgencyId}";
        }

        public decimal CalculatePay()
        {
            var minWage = ConfigurationSettings.AppSettings["MinimumWage"];
            
            return HoursWorked * Convert.ToDecimal(minWage);
        }
    }
}
