using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public string Denumire
        {
            get { return denumire; }
            set
            {
                if (value != null)
                    denumire = value;
            }
        }

        public List<Animal> ListaAnimale
        {
            get { return listaAnimale; }
            set
            {
                if (value != null)
                    listaAnimale = value;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            string rezultat = "";
            rezultat += "Zoo " + denumire + " are urmatoarele animale: " + Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }

        public object Clone()
        {
            //return this.MemberwiseClone();
            Zoo z = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
            z.listaAnimale = listaNoua;
            return z;
        }
    }
}
