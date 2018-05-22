using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumGedamkeDistribution {
    class Filter {
        internal bool FilterOrientation { get; set; }
                // true  = x  or 1   
                // false = +  or 0
        public Filter(int orientation) {
            if (orientation == 0)
                FilterOrientation = false;
            else
                FilterOrientation = true;
        }
    }
}