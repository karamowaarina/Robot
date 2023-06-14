using Robots.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class BuilderAI : IAI
    {
        int counter = 1;

        public object GetCommand()
        {
            return BuilderCommand.ForCounter(counter++);
        }
    }
}
