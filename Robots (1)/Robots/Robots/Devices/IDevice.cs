using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.Devices
{
    public interface IDevice
    {
        string ExecuteCommand(object command);
    }
}
