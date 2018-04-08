using System;
using System.Linq;
using System.Collections.Generic;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;

namespace MedicalWorm.Core.Models
{
    public class Doctor : EmployeeBase, IEmployee
    {
        private const int _payRate = 180; 

        public MedicalSpeciality Speciality { get; set; }
        public MedicalLicense LicenseObtained { get; set; }

        public List<Nurse> Nurses { get; set; }

        public Nurse PrimaryNurse { get; set; }
        
        public Guid PrescriptionAuthorizationId { get; set; }

        public Nurse ReturnPrimaryNurse(IEnumerable<Nurse> nurses)
        {
            var topNurse = nurses.Where(n => n.IsRegisteredNurse).FirstOrDefault();

            return topNurse;
        }

        public string PrintBadge()
        {
            return $"{Name}, {LicenseObtained.MedicalLicenseFormatted2()} ({EmployeeId})";
        }

        public decimal CalculatePay()
        {
            return HoursWorked * _payRate;
        }

        public override void TakeVacation(int numberOfDays)
        {
            VacationDays = VacationDays - (decimal)numberOfDays / 2;
        }

        public override decimal CalculateRemainingVacationDays()
        {
            if (VacationDays < 8)
            {
                VacationDays = 8;
            }

            return base.CalculateRemainingVacationDays();
        }
    }
}
