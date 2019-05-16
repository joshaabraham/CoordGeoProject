using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatisseurCroisement.BusinessObjects
{
    public class Point : AbstractPointGeographique
    {
        public Point(long lat ,long lon) : base(lat, lon) {}

        public override void CreerPointGeographique(long lat, long lon)
        {
            
        }
    }
}
