using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor
{
   public class MonitorFilter
    {

        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type) =>
            monitors.Where(m => m.Type == type).ToList();

        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors,Screen screen)
        {
            return monitors.Where(s => s.Screen.Equals(screen)).ToList();
        }
    }
}
