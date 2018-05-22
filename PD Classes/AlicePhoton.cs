using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumGedamkeDistribution {
    public class AlicePhoton {
         internal bool Polarization { get; set;}
         internal bool Rectilinear { get; set; }
                // true  = x  or 1   
                // false = +  or 0
         public AlicePhoton(int aliceSends) {
            switch (aliceSends) {
                case 0: // 1 x
                    Polarization = true;
                    Rectilinear = true;
                    break;
                case 1: // 1 +
                    Polarization = true;
                    Rectilinear = false;
                    break;
                case 2: // 0 x
                    Polarization = false;
                    Rectilinear = true;
                    break;
                case 3: // 0 +
                    Polarization = false;
                    Rectilinear = false;
                    break;           
            }
        }
    }
}