using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4_paw
{
    public class Student: Persoana, ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private int[] note;

        public Student():base()
        {
            varsta = 0;
            nume = "Anonim";
            note = null;
        }

        public Student(int c, char s, int v, string n, int[] nt):
            base(c, s)
        {
            varsta = v;
            nume = n;
            note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];
        }

        public override string ToString()
        {
            string rezultat = base.ToString()+" si varsta "+varsta+", numele "+nume;
            if (note != null)
            {
                rezultat += " si urmatoarele note: ";
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + ", ";
            }
            else
                rezultat += " si nu are note";
            return rezultat;
        }

        public override void SpuneAnNastere()
        {
            Console.WriteLine("Anul nasterii este: " + 
                (System.DateTime.Now.Year - varsta));
        }

        public object Clone()
        {
            Student s = (Student)this.MemberwiseClone();
            int[] noteNoi = (int[])note.Clone();
            s.note = noteNoi;
            return s;
        }

        public static explicit operator float(Student s)
        {
            if (s.note != null)
            {
                int suma = 0;
                for (int i = 0; i < s.note.Length; i++)
                    suma += s.note[i];
                return (float)suma / s.note.Length;
            }
            else
                return 0;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if ((float)this < (float)s)
                return -1;
            else
                if ((float)this > (float)s)
                    return 1;
                else
                    return string.Compare(this.nume, s.nume);
        }
    }
}
