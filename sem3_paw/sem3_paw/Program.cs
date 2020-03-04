using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 23, "Gigel", 
                new int[3] { 8, 9, 10 });
            Student s3 = (Student)s2.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s3);
            s2.SpuneAnNastere();
            Console.WriteLine("Media lui s2 este: " + (float)s2);

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
        }
    }
}
