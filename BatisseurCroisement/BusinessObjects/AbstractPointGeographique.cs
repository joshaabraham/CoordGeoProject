using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatisseurCroisement.BusinessObjects
{
    public abstract class AbstractPointGeographique
    {
        Guid guid { get; set; }
        long longitude { get; set; }
        long latitude { get; set; }
        protected AbstractPointGeographique(long lat, long lon)
        {
            this.guid = new Guid();
            this.longitude = lon;
            this.latitude = lat;
        }
        public abstract void CreerPointGeographique(long lat, long lon);
    }
}
