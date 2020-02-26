using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Maimutza: Animal
    {
        private string culoare;
        private int nrPui;

        public Maimutza()
            : base()
        {
            culoare = "maro";
            nrPui = 0;
        }

        public Maimutza(int v, string n, float g, string c, int nr)
            : base(v, n, g)
        {
            culoare = c;
            nrPui = nr;
        }

        public override string ToString()
        {
            return base.ToString() + 
                " culoare "+culoare+" si are "+nrPui+" pui";
        }
    }
}
