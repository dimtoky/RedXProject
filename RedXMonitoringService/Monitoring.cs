using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using DataProviders;

namespace RedXMonitoringService
{
    class Monitoring
    {
        public PerformanceCounter theMemCounter;
        ProcessLayer process;
        ProcFactory factory;
        public double cpuUsage;
        public float ramUsage;

        public Monitoring()
        {
            theMemCounter = new PerformanceCounter("Memory", "Available MBytes");           
            factory = new ProcFactory();
            process = factory.createProcess("Log");
            update();
        }

        public static double GetCpuCaption()
        {

            ManagementObject searcher = new ManagementObject("Win32_PerfFormattedData_PerfOS_Processor.Name='_Total'");

            searcher.Get();
            double a = double.Parse(searcher.Properties["PercentProcessorTime"].Value.ToString());

            return a;
        }


        public void update()
        {
            ramUsage = theMemCounter.NextValue();
            cpuUsage = GetCpuCaption();

            if (ramUsage <= 50)
            {
                process.updateText(1, "", 0, 10, "");
            }
            else
            {
                process.updateText(1, "", 1, 10, "");
            }

            if (cpuUsage >= 90)
            {
                process.updateText(2, "", 0, 20, "");
            }
            else
            {
                process.updateText(2, "", 1, 20, "");
            }
            

        }
    }
}
