using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor.ImplementOCP
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
