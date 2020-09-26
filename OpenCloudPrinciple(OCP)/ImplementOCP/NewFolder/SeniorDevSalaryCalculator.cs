using OpenCloudPrinciple_OCP_.ModelClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ImplementOCP.NewFolder
{
    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        public override double CalculateSalary()
        {
            return _DeveloperReport.HourlyRate * _DeveloperReport.WorkingHours * 1.2;
        }
    }
}
