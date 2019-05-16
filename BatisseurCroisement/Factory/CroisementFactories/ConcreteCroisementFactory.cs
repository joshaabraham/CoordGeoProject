using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatisseurCroisement.Factory.CroisementFactories;
using CreateSubCoords.BusinessObjects;

namespace CreateSubCoords.Factory
{
    class ConcreteCroisementFactory : AbstractCroisementFactory
    {
        public override Croisement CreatePointCentral()
        {
            throw new NotImplementedException();
        }

        public override AbstractChemin CreerChemin()
        {
            throw new NotImplementedException();
        }

        public override AbstractPointGeographique CreerPointGeo()
        {
            throw new NotImplementedException();
        }

        public override int DefinitionNbVoie()
        {
            throw new NotImplementedException();
        }
    }
}
