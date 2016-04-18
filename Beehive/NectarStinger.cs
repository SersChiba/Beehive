using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class NectarStinger : Worker, INectarCollector, IStingPatrol
    {
        public NectarStinger(string[] jobsICanDO, double weightMg) : base(jobsICanDO, weightMg)
        {
        }

        public int AlertLevel { get; private set; }

        public string Job { get; }

        public int Nectar { get; set; }

        public int StingerLength { get; set; }

        public void FindFlowers()
        {

        }
        public void GatherNectar()
        {

        }
        public bool LookForEnemies()
        {
            return false;
        }
        public void ReturnToHive()
        {

        }
        public int SharpenStinger(int length)
        {
            return 11;
        }

        public void WorkOneShift()
        { }

        void IWorker.DoThisJob(string job, int shifts)
        { }
    }
}
