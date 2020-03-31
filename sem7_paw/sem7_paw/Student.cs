using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem7_paw
{
    class Student
    {
        public int cod;
        public string nume;
        public int nota;

        public Student(int c, string n, int nt)
        {
            cod = c;
            nume = n;
            nota = nt;
        }

        public override string ToString()
        {
            return "Studentul " + nume + " are codul " + cod + " si nota " + nota;
        }
    }
}
