using System;
using System.Collections.Generic;
using System.Linq;
using MedicalWorm.Core.Enums;
using MedicalWorm.Core.Interfaces;
using MedicalWorm.Core.Models;

namespace MedicalWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctors = EmployeeFactory.GenerateDoctors();
            var nurses = EmployeeFactory.GenerateNurses();
            var janitors = EmployeeFactory.GenerateJanitors();

            Console.WriteLine("Welcome to Medical Worm Hospital");

            //Nurses
            //.where()
            var rns = nurses.Where(n => n.IsRegisteredNurse).ToList();

            //.AddRange()
            var d1 = doctors.First();
            d1.Nurses.AddRange(rns);

            //.Contains()
            var aNurses = nurses.Where(n => n.Name.ToLower().Contains("a")).ToList();

            //.StartsWith()
            var bNurses = nurses.Where(n => n.Name.ToLower().StartsWith("b")).ToList();

            //.Any()
            var nrns = !nurses.Any(n => n.IsRegisteredNurse);

            //.All()
            var allRNs = nurses.All(n => n.IsRegisteredNurse);

            //Janitors
            //.Count()
            var hardWorkingJanitors = janitors.Count(j => j.HoursWorked > 10);

            //.Max()
            var hardestJan = janitors.Max(j => j.HoursWorked);

            //.Min()
            var slackerJan = janitors.Min(j => j.HoursWorked);

            //.Sum()
            var totalJanHours = janitors.Sum(j => j.HoursWorked);

            //Doctors
            //.OrderBy() / .OrderByDescending()                          `These go together`
            var hardestDoc = doctors.OrderByDescending(d => d.HoursWorked).Skip(1).Take(1).ToList();

            //.ThenBy() / .ThenByDescending()
            var orderedDoc = doctors.OrderBy(d => d.Name).ThenBy(d => d.Speciality).ToList();

            //.First() / .FirstOrDefault() && .Last() / .LastOrDefault()
            var docPat = doctors.Where(n => n.EmployeeId == 111).FirstOrDefault();
            var newDocPat = doctors.Where(n => n.EmployeeId == 111).LastOrDefault();

            //.Single() / .SingleOrDefault()
            var docSinglePat = doctors.Where(n => n.EmployeeId == 111).SingleOrDefault();
            
            Console.ReadLine();
        }
    }
}
    