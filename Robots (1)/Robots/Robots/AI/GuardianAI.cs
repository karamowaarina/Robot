using Robots.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class GuardianAI : IAI
    {
        int counter = 1;

        public object GetCommand()
        {
            return GuardianCommand.ForCounter(counter++);
        }

    }
}
