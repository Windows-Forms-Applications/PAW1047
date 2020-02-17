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
        private string nume;
        public int varsta;
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
            this.cod = s.cod;
            this.nume = s.nume;
            this.varsta = s.varsta;
            this.medie = s.medie;

        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are codul {1}, varsta {2} si media {3}",
                nume, cod, varsta, medie);
        }
    }
}
