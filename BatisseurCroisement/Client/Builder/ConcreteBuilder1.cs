using BatisseurCroisement.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatisseurCroisement.Client.Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Croisement _croisement = new Croisement();

        public override void BuildCroisement()
        {
            //creer List de Couple point 
            // this._croisement.
            throw new System.NotImplementedException();
        }

        public override void BuildCouplePoint()
        {
            //creer croisement
            // this._croisement.
            throw new System.NotImplementedException();
        }

        public override void BuildPointDeVoie()
        {
            //creer les points intermediaires
            // this._croisement.
            throw new System.NotImplementedException();
        }

        public override Croisement GetResult()
        {
            return this._croisement;
        }
    }
}
