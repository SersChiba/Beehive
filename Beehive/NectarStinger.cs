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

        public int Nectar {get; set; }

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
        public bool SharpenStinger(int length)
        {
            return true;
        }
    }
}
