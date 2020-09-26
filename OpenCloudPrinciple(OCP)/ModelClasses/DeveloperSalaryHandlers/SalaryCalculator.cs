using OpenCloudPrinciple_OCP_.ImplementOCP;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.DeveloperSalaryHandlers
{
    //public class SalaryCalculator
    // {
    //     private readonly List<DeveloperReport> developerReports;

    //     public SalaryCalculator(List<DeveloperReport> developerReports)
    //     {
    //         this.developerReports = developerReports;
    //     }

    //     public double CalculateTotalSalaries()
    //     {
    //         double totalSalary = 0D;

    //         foreach (var item in developerReports)
    //         {
    //             if(item.Level.Equals("Senior developer"))
    //                 totalSalary += item.HourlyRate * item.WorkingHours *1.2;
    //             else
    //                 totalSalary += item.HourlyRate * item.WorkingHours;
    //         }

    //         return totalSalary;
    //     }
    // }




    // Implementation of OCP

    public class SalaryCalculator
    {
        private readonly List<BaseSalaryCalculator> baseSalaryCalculators;

        public SalaryCalculator(List<BaseSalaryCalculator> baseSalaryCalculators)
        {
            this.baseSalaryCalculators = baseSalaryCalculators;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalary = 0D;

            foreach (var item in baseSalaryCalculators)
            {
                totalSalary += item.CalculateSalary();
            }

            return totalSalary;
        }
    }
}
