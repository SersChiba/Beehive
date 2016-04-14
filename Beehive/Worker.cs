using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Worker
    {
       
        private string[] JobsICanDo;
        private bool busy { get; set; }

        public Worker(string[] jobICanDO)
        {
            this.JobsICanDo = jobICanDO;
        }

        internal bool DoThisJob(string jobToDo, int shiftsCount)
        {
            //TODO: check if able to do job
            if (busy)
                return false;            
            else
            {
                foreach (string item in JobsICanDo)
                {
                    if (item.Contains(jobToDo))
                        return true;
                }
                return false;
            }            
        }
    }
}
