using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace RedXMonitoringService
{
    public partial class Service1 : ServiceBase
    {
        Monitoring monitor;
        
        public Service1()
        {
        
            InitializeComponent();
            monitor = new Monitoring();
        }

        protected override void OnStart(string[] args)
        {

            while (true)
            {
                monitor.update();
                System.Threading.Thread.Sleep(30000);

            }

        }

        protected override void OnStop()
        {
        }

     


    }
}
