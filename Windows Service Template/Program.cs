using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Windows_Service_Template
{
  class Program
  {
    static void Main(string[] args)
    {
      var exitCode = HostFactory.Run(x =>
      {
        x.Service<ServiceCode>(s =>
        {
          s.ConstructUsing(service => new ServiceCode());
          s.WhenStarted(service => service.Start());
          s.WhenStopped(service => service.Stop());
        });

        x.RunAsLocalSystem();

        x.SetServiceName("ServiceName");
        x.SetDisplayName("Service Name");
        x.SetDescription("Service Description");
      });

      int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
      Environment.ExitCode = exitCodeValue;

      // Install Service:
        // Copy files in bin/debug to a permanent folder
        // Open terminal, as administrator, on that folder
        // Run FileName.exe intall start
      // Uninstall Service:
        // Open folder where files are
        // Open terminal, as administrator, on that folder
        // Run FileName.exe uninstall
    }
  }
}
