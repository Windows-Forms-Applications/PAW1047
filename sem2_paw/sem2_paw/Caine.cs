using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Caine: Animal
    {
        private string rasa;
        private bool areStapan;

        public Caine(): base()
        {
            rasa = "maidanez";
            areStapan = false;
        }

        public Caine(int v, string n, float g, string r, bool are)
            : base(v, n, g)
        {
            rasa = r;
            areStapan = are;
        }

        public override string ToString()
        {
            return base.ToString() + 
                " rasa "+rasa+" si are stapan "+areStapan;
        }
    }
}
