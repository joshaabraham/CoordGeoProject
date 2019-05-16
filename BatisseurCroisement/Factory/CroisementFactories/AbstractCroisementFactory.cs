using CreateSubCoords.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatisseurCroisement.Factory.CroisementFactories
{
    abstract class AbstractCroisementFactory
    {
        public abstract AbstractCroisement CreatePointCentral();
        public abstract AbstractChemin CreerChemin();
        public abstract AbstractPointGeographique CreerPointGeo();

        
    }
}
