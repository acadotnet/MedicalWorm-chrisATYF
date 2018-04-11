using System.Collections.Generic;
using System.Linq;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Nurse : EmployeeBase, IEmployee
    {
        private const decimal _payRate = 150;

        public bool IsRegisteredNurse { get; set; }
        public List<NursingCertification> Certifications { get; set; }
        public IEnumerable<int> FloorsWorked { get; set; }

        public string PrintBadge()
        {
            var certsFormatted = string.Join(", ", Certifications.Select(c => c.NursingCertificationFormatted(IsRegisteredNurse)).ToList());
            var commaSeparatedFloors = string.Join(", ", FloorsWorked);
            
            return $"{Name}, {certsFormatted}, Floors: {commaSeparatedFloors}, ({EmployeeId})";
        }

        public decimal CalculatePay()
        {
            decimal overTimePay = _payRate / 2;
            decimal overtimeHours = HoursWorked - 40;
            if (HoursWorked > 40)
            {
                decimal overPay = overTimePay * overtimeHours;
                decimal regPay = HoursWorked * _payRate;
                return overPay + _payRate;
            }
            return HoursWorked * _payRate;
        }

        public override void TakeVacation(int numberOfDays)
        {
            HoursWorked = HoursWorked - (decimal)numberOfDays / 2;
        }
    }
}
