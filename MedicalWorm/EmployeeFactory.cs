using System;
using System.Collections.Generic;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Models;

namespace MedicalWorm
{
    public static class EmployeeFactory
    {
        public static IEnumerable<Doctor> GenerateDoctors()
        {
            return new[]
            {
                new Doctor
                {
                    EmployeeId = 8082,
                    Name = "Pat Granite",
                    HoursWorked = 64.2M,
                    VacationDays = 18,
                    Speciality = MedicalSpeciality.Anesthesiology,
                    LicenseObtained = MedicalLicense.DoctorofMedicine,
                    PrescriptionAuthorizationId = Guid.NewGuid(),
                    Nurses = new List<Nurse>()
                },
                new Doctor
                {
                    EmployeeId = 9873,
                    Name = "John Slate",
                    HoursWorked = 21,
                    VacationDays = 24,
                    Speciality = MedicalSpeciality.General,
                    LicenseObtained = MedicalLicense.DoctorofOsteopathicMedicine,
                    PrescriptionAuthorizationId = Guid.NewGuid(),
                    Nurses = new List<Nurse>()
                },
                new Doctor
                {
                    EmployeeId = 1038,
                    Name = "Sharon Chalk",
                    HoursWorked = 32.5M,
                    VacationDays = 10,
                    Speciality = MedicalSpeciality.Oncology,
                    LicenseObtained = MedicalLicense.DoctorofMedicine,
                    PrescriptionAuthorizationId = Guid.NewGuid(),
                    Nurses = new List<Nurse>()
                },
                new Doctor
                {
                    EmployeeId = 9390,
                    Name = "Lakshmi Mica",
                    HoursWorked = 28.75M,
                    VacationDays = 12,
                    Speciality = MedicalSpeciality.Neurology,
                    LicenseObtained = MedicalLicense.DoctorofMedicine,
                    PrescriptionAuthorizationId = Guid.NewGuid(),
                    Nurses = new List<Nurse>()
                },
                new Doctor
                {
                    EmployeeId = 8335,
                    Name = "Chris McDonald",
                    HoursWorked = 30.25M,
                    VacationDays = 13,
                    Speciality = MedicalSpeciality.Anesthesiology,
                    LicenseObtained = MedicalLicense.DoctorofMedicine,
                    PrescriptionAuthorizationId = Guid.NewGuid(),
                    Nurses = new List<Nurse>()
                }
            };
        }

        public static IEnumerable<Nurse> GenerateNurses()
        {
            return new[]
            {
                new Nurse
                {
                    EmployeeId = 6278,
                    Name = "Timothy",
                    HoursWorked = 70.1M,
                    VacationDays = 6,
                    IsRegisteredNurse = true,
                    Certifications = new List<NursingCertification>
                    {
                        NursingCertification.ACRN,
                        NursingCertification.COCN
                    },
                    FloorsWorked = new[] { 2, 3, 6 }
                },
                new Nurse
                {
                    EmployeeId = 5014,
                    Name = "Barbara",
                    HoursWorked = 44.2M,
                    VacationDays = 11,
                    IsRegisteredNurse = false,
                    Certifications = new List<NursingCertification>
                    {
                        NursingCertification.WHNP
                    },
                    FloorsWorked = new [] { 4 }
                },
                new Nurse
                {
                    EmployeeId = 8989,
                    Name = "Walter",
                    HoursWorked = 28.2M,
                    VacationDays = 4,
                    IsRegisteredNurse = false,
                    Certifications = new List<NursingCertification>
                    {
                        NursingCertification.HWNC,
                        NursingCertification.PMHCNS
                    },
                    FloorsWorked = new [] { 1, 2, 3, 5, 6 }
                },
                new Nurse
                {
                    EmployeeId = 1178,
                    Name = "Samar",
                    HoursWorked = 8,
                    VacationDays = 2,
                    IsRegisteredNurse = true,
                    Certifications = new List<NursingCertification>
                    {
                        NursingCertification.WHNP,
                        NursingCertification.ACRN,
                        NursingCertification.AGACNP,
                        NursingCertification.PMHCNS,
                        NursingCertification.HWNC
                    },
                    FloorsWorked = new[] { 1, 2, 5}
                },
                new Nurse
                {
                    EmployeeId = 8334,
                    Name = "Chris McDonald",
                    HoursWorked = 8,
                    VacationDays = 4,
                    IsRegisteredNurse = true,
                    Certifications = new List<NursingCertification>
                    {
                        NursingCertification.CHPLN
                    },
                    FloorsWorked = new[] { 1, 2, 5 }
                }
            };
        }

        public static IEnumerable<Janitor> GenerateJanitors()
        {
            return new[]
            {
                new Janitor
                {
                    ExternalAgencyId = "101",
                    ExternalAgencyName = "StaffMark",
                    Name = "Dave",
                    HoursWorked = 32
                },
                new Janitor
                {
                    ExternalAgencyId = "39045-0234-ABC",
                    ExternalAgencyName = "ABC Staffing",
                    Name = "Mark",
                    HoursWorked = 36
                },
                new Janitor
                {
                    ExternalAgencyId = "137",
                    ExternalAgencyName = "StaffMark",
                    Name = "Derek",
                    HoursWorked = 40
                },
                new Janitor
                {
                    ExternalAgencyId = "138",
                    ExternalAgencyName = "StaffMark",
                    Name = "Chris",
                    HoursWorked = 40
                }
            };
        }
    }
}
