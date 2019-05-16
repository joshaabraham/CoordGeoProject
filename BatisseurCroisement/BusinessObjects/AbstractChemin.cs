using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatisseurCroisement.BusinessObjects
{
    public abstract class AbstractChemin
    {
        AbstractPointGeographique pt1 { get; set; }
        AbstractPointGeographique pt2 { get; set; }
    }
}
