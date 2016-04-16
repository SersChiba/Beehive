using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Worker : Bee
    {

        private string[] jobsICanDo;
        private string currentJob = "";
        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDO, double weightMg):base(weightMg)
        {
            this.jobsICanDo = jobsICanDO;
        }

        internal bool DoThisJob(string jobToDo, int shiftsCount)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;
            foreach (string item in jobsICanDo)
                if (item.Contains(jobToDo))
                {
                    this.shiftsToWork = shiftsCount;
                    shiftsWorked = 0;
                    currentJob = jobToDo;
                    return true;
                }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate()+(.65*shiftsWorked);
        }       
    }
}
