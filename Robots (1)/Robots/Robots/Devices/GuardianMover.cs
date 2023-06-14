using Robots.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class GuardianMover : IDevice
    {
        public string ExecuteCommand(object order)
        {
            var command = order as IGuardianMoveCommand;
            if (command == null)
                throw new ArgumentException();
            var guard = command.Guard ? "YES" : "NO";
            return $"MOV {command.Destination.X}, {command.Destination.Y}, GUARD {guard}";
        }
    }
}
