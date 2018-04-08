using System.Collections.Generic;
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
            if (IsRegisteredNurse)
            {
                var rNCert = "RN " + Certifications;
                var commaSeparatedFloors = string.Join(", ", FloorsWorked);
                var commaSeperatedCerts = string.Join(", ", rNCert);

                return $"{Name}, {commaSeperatedCerts}, Floors: {commaSeparatedFloors}, ({EmployeeId})";
            }
            else
            {
                var commaSeparatedFloors = string.Join(", ", FloorsWorked);
                var commaSeperatedCerts = string.Join(", ", Certifications);

                return $"{Name}, {commaSeperatedCerts}, Floors: {commaSeparatedFloors}, ({EmployeeId})";
            }
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
