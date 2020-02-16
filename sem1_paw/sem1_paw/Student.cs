using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem1_paw
{
    class Student
    {
        int cod;
        public string nume;
        private int varsta;
        protected float medie;

        public Student()
        {
            cod = 0;
            nume = "Anonim";
            varsta = 0;
            medie = 0.0f;
        }

        public Student(int c, string n, int v, float m)
        {
            cod = c;
            nume = n;
            varsta = v;
            medie = m;
        }

        public Student(Student s)
        {
            cod = s.cod;
            nume = s.nume;
            varsta = s.varsta;
            medie = s.medie;
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} cu codul {1} are varsta {2} si media {3}", nume, cod, varsta, medie);
        }

        public override string ToString()
        {
            return "Studentul " + nume + " cu codul " + cod + " are varsta " + varsta + " si media " + medie;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value >= 0) varsta = value; }
        }

        public float Medie
        {
            set { if (value >= 0) medie = value; }
        }
    }
}
