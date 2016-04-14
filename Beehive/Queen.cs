using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToDo, int shiftsCount)
        {
            foreach (Worker bee in workers)
            {
                //TODO: find one to do the job
                //bee.DoThisJob(jobToDo, shiftsCount);
                if (bee.DoThisJob(jobToDo, shiftsCount))
                    return true;                
            }
            return false;
        }

        private bool WorkTheNextShift()
        {

        }
    }
}
