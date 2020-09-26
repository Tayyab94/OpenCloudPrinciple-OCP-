using OpenCloudPrinciple_OCP_.ModelClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ImplementOCP.NewFolder
{
   public class JuniorDevSalaryCalculator:BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport):base(developerReport)
        {

        }

        public override double CalculateSalary() => _DeveloperReport.WorkingHours * _DeveloperReport.HourlyRate;
    }
}
