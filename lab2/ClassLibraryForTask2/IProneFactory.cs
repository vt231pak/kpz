using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            Thread.Sleep(2000);
            return new Smartphone();
        }
    }
}
