using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robots.AI;
using Robots.Devices;

namespace Robots
{
    public abstract class Robot
    {
        protected readonly IAI ai;
        protected readonly IDevice device;

        public Robot(IAI ai, IDevice device)
        {
            this.ai = ai;
            this.device = device;
        }

        public IEnumerable<string> Start(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                var command = ai.GetCommand();
                if (command == null)
                    break;
                yield return device.ExecuteCommand(command);
            }
        }

        public static Robot Create<TAI, TDevice>(TAI ai, TDevice device) where TAI : IAI where TDevice : IDevice
        {
            return new Robot<TAI, TDevice>(ai, device);
        }
    }

    public class Robot<TAI, TDevice> : Robot where TAI : IAI where TDevice : IDevice
    {
        public Robot(TAI ai, TDevice device) : base(ai, device)
        {
        }
    }

}
