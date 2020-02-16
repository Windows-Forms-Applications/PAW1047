using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem1_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Introduceti numele!");
            string nume = Console.ReadLine();

            Console.Write("Numele este {0}", nume);
            Console.WriteLine();

            //definire vector
            int[] v1 = { 1, 2, 3, 4 };
            int[] v2 = new int[3];
            int[] v3 = new int[2] { 10, 20 };
            Console.WriteLine("v1");
            for (int i = 0; i < v1.Length; i++)
                Console.Write("{0} ", v1[i]);

            Console.WriteLine("v2");
            v2 = v1;
            v1[1] = 100;
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]);

            Console.WriteLine("v4");
            int[] v4 = new int[4];
            for (int i = 0; i < v1.Length; i++)
                v4[i] = v1[i];
            v1[1] = 100;
            for (int i = 0; i < v4.Length; i++)
                Console.Write("{0} ", v4[i]);

            Console.WriteLine("v5");
            int[] v5 = (int[])v1.Clone();
            for (int i = 0; i < v5.Length; i++)
                Console.Write("{0} ", v5[i]);

            //definire masiv bidimensional
            Console.WriteLine("m1");
            int[,] m1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                    Console.Write("{0} ", m1[i, j]);
                Console.WriteLine();
            }

            //definire masiv in zig-zag
            Console.WriteLine("m2");
            int[][] m2 = new int[2][];
            m2[0] = new int[3] { 10, 20, 30 };
            m2[1] = new int[4] { 40, 50, 60, 70 };
            for (int i = 0; i < m2.Length; i++)
            {
                for (int j = 0; j < m2[i].Length; j++)
                    Console.Write("{0} ", m2[i][j]);
                Console.WriteLine();
            }

            //colectie de obiecte
            Student s1 = new Student();
            Student s2 = new Student(100, "Gigel", 23, 9.5f);
            Student s3 = new Student(s2);
            s1.afisare();
            Console.WriteLine(s2);

            s3.Medie = 9.8f;
            Console.WriteLine("Varsta lui s2 este {0} ", s2.Varsta);

            ArrayList listaStud = new ArrayList();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);

            foreach (Student s in listaStud)
                Console.WriteLine(s);
            for (int i = 0; i < listaStud.Count; i++)
                Console.WriteLine(listaStud[i]);
        }       
    }
}
