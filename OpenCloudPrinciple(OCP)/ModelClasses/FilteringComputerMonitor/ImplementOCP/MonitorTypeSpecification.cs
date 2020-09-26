using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor.ImplementOCP
{
    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType monitorType;

        public MonitorTypeSpecification(MonitorType monitorType)
        {
            this.monitorType = monitorType;
        }
        public bool isSatisfied(ComputerMonitor item)
           =>item.Type == monitorType;
    }
}
