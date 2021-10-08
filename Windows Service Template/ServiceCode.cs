using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Windows_Service_Template
{
  class ServiceCode
  {
    private readonly Timer _timer;

    public ServiceCode()
    {
      _timer = new Timer(1000) { AutoReset = true };
      _timer.Elapsed += TimerElapsed;
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
      // Add code here
      throw new NotImplementedException();
    }

    public void Start()
    {
      _timer.Start();
    }

    public void Stop()
    {
      _timer.Stop();
    }
  }
}
