using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor
{
  public  class ComputerMonitor
    {
        public string Name { get; set; }

        public MonitorType Type { get; set; }

        public Screen Screen { get; set; }
    }
}
