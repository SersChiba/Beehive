﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobToDo, int shiftsCount)
        {
            foreach (Worker bee in workers)
                if (bee.DoThisJob(jobToDo, shiftsCount))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber;
            double honeyConsumedMg = HoneyConsumptionRate();
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "\r\nWorker #" + (i + 1) + " finished the job.";
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "\r\nWorker #" + (i + 1) + " is not working.";
                else if (workers[i].ShiftsLeft > 0)
                    report += "\r\nWorker #" + (i + 1) + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftsLeft + " more shifts.";
                else
                    report += "\r\nWorker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift.";
                honeyConsumedMg += workers[i].HoneyConsumptionRate();
            }
            report += "\r\nTotal honey consumed for the shift: " + honeyConsumedMg + " units.";
            return report;
        }
        private void DefendTheHive(IStingPatrol patroller)
        {

        }
    }
}
