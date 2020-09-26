using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor.ImplementOCP
{
    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
          return  monitors.Where(s => specification.isSatisfied(s)).ToList();
        }
    }
}
