using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Worker
    {

        private string[] jobsICanDo;
        public readonly string CurrentJob;
        private int shiftsToWork { get; set; }
        private int shiftsWorked { get; set; }

        public Worker(string[] jobICanDO)
        {
            this.jobsICanDo = jobICanDO;
        }

        internal bool DoThisJob(string jobToDo, int shiftsCount)
        {
            //TODO: check if able to do job
            if (!string.IsNullOrEmpty(CurrentJob))
                return false;
            else
            {
                foreach (string item in jobsICanDo)
                {
                    if (item.Contains(jobToDo))
                    {
                        this.CurrentJob = jobToDo;
                        return true;
                    }

                }
                return false;
            }
        }

        public bool DidYouFinish()
        {
            this.shiftsWorked++;
            this.shiftsToWork--;
            if (shiftsToWork<=0)
            {
                CurrentJob = ""; //Hooow???
                return true;
            }
            return false;
        }
    }
}
