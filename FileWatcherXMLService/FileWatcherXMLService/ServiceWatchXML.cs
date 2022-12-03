using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileWatcherXMLService
{
    
    public partial class ServiceWatchXML : ServiceBase
    {
        FilesWatcher filesWatcher;
        public ServiceWatchXML()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            filesWatcher = new FilesWatcher();
            Thread filesWatcherThread = new Thread(new ThreadStart(filesWatcher.Start));
            filesWatcherThread.Start();
        }

        protected override void OnStop()
        {
            filesWatcher.Stop();
            Thread.Sleep(1000);
        }

    }
}
