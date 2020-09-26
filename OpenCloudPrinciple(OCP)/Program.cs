using OpenCloudPrinciple_OCP_.ImplementOCP;
using OpenCloudPrinciple_OCP_.ImplementOCP.NewFolder;
using OpenCloudPrinciple_OCP_.ModelClasses;
using OpenCloudPrinciple_OCP_.ModelClasses.DeveloperSalaryHandlers;
using OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor;
using OpenCloudPrinciple_OCP_.ModelClasses.FilteringComputerMonitor.ImplementOCP;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace OpenCloudPrinciple_OCP_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var devReports = new List<DeveloperReport>
            //    {
            //        new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
            //        new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
            //        new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
            //    };


            //var calculator = new SalaryCalculator(devReports);


            //Console.WriteLine($"Sum of All develoer salary {calculator.CalculateTotalSalaries()} Dollers");


            //Console.ReadKey();


            var devReport = new List<BaseSalaryCalculator>
            {
                new JuniorDevSalaryCalculator(new DeveloperReport{Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 }),
                new SeniorDevSalaryCalculator(new DeveloperReport{Id = 2, Name = "Dev1", Level = "Junior developer", HourlyRate  = 23, WorkingHours = 122 })
            };

            var calculator = new SalaryCalculator(devReport);


            Console.WriteLine($"Sum of All develoer salary {calculator.CalculateTotalSalaries()} Dollers");


            Console.ReadKey();


            Console.WriteLine("Computer Section");

            var monitors = new List<ComputerMonitor>
        {
            new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
            new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
            new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
            new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
            new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }
            , new ComputerMonitor{Name="Custom",Screen=Screen.CurvedScreen,Type=MonitorType.NO}
        };
            //var filter = new MonitorFilter();
            //var lcdMonitors = filter.FilterByType(monitors, MonitorType.NO);
            //Console.WriteLine("All LCD monitors");
            //foreach (var monitor in lcdMonitors)
            //{
            //    Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            //}


            var filter = new ModelClasses.FilteringComputerMonitor.ImplementOCP.MonitorFilter();
            var lcdMonitors = filter.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
            Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }



        }
    }
}
