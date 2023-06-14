using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class GuardianCommand : IGuardianMoveCommand
    {
        public Point Destination { get; set; }
        public bool Guard { get; set; }

        public static GuardianCommand ForCounter(int counter)
        {
            return new GuardianCommand
            {
                Destination = new Point { X = counter * 0.5, Y = counter * 0.5 },
                Guard = counter % 2 == 0
            };
        }
    }

}
