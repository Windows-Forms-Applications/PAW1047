using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem6_paw
{
    class Credit
    {
        private int suma;
        private int perioada;
        private float dobanda;
        private float rata;

        public Credit(int s, int p, float d, float r)
        {
            suma = s;
            perioada = p;
            dobanda = d;
            rata = r;
        }

        public override string ToString()
        {
            return "Creditul cu suma " + suma + " pe perioada " + perioada +
            " si dobanda " + dobanda + " are rata " + rata;
        }
    }
}
