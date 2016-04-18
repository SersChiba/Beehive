using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Robot
    {
        public void ConsumeGas() { }
    }

    class RoboBee : Robot, IWorker
    {
        private int shiftsToWork;
        private int shiftsWorked;
        public string Job { get; private set; }
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }
        public void DoThisJob(string job, int shiftsToWork)
        { }
        public void WorkOneShift()
        { }
    }

}
