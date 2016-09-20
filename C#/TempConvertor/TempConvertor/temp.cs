using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvertor
{
    public class temp
    {
        public double CTF(double temp) {
            return (temp * 1.8) + 32;
        }

        public double FTC(double temp) {
            return (temp / 1.8) - 32;

        }
    }
}
