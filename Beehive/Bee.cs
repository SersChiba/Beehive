using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeigthMg { get; private set; }
        public Bee(double weightMg)
        {
            WeigthMg = weightMg;
        }

        virtual public double HoneyConsumptionRate()
        {
            return WeigthMg * HoneyUnitsConsumedPerMg;
        }
    }
}
