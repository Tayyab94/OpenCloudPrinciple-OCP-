using OpenCloudPrinciple_OCP_.ModelClasses;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ImplementOCP
{
  public abstract  class BaseSalaryCalculator
    {

        public BaseSalaryCalculator(DeveloperReport developerReport)
        {
            _DeveloperReport = developerReport;
        }

        protected DeveloperReport _DeveloperReport { get; private set; }

        public abstract double CalculateSalary();



    }
}
