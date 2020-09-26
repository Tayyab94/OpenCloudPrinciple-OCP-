using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses
{
  public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Level { get; set; }

        public int WorkingHours { get; set; }

        public double HourlyRate { get; set; }
    }
}
