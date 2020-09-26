using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor.ImplementOCP
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T item);
    }
}
