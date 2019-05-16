using BatisseurCroisement.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatisseurCroisement.Client.Builder
{
    abstract class Builder
    {
        public abstract void BuildCroisement();
        public abstract void BuildCouplePoint();
        public abstract void BuildPointDeVoie();
        public abstract Croisement GetResult();
    }
}
