using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem1_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numele: ");

            string nume = Console.ReadLine();

            Console.Write("Numele este {0} ", nume);

            int[] v1 = { 1, 2, 3, 4 };
            int[] v2 = new int[4] { 1, 2, 3, 4 };
            int[] v3;
            //shallow copy
            v3 = v2;
            Console.WriteLine();
            v2[1] = 100;
            for (int i = 0; i < v3.Length; i++)
                Console.WriteLine(v3[i]);
            //deep copy
            int[] v4 = new int[v2.Length];
            for (int i = 0; i < v2.Length; i++)
                v4[i] = v2[i];
            v2[1] = 50;
            for (int i = 0; i < v4.Length; i++)
                Console.WriteLine(v4[i]);
            //deep copy v2
            int[] v5 = (int[])v2.Clone();
            v2[1] = 30;
            for (int i = 0; i < v5.Length; i++)
                Console.WriteLine(v5[i]);

            //masiv bidimensional
            int[,] m1 = new int[2, 3]
                { { 10, 20, 30 }, { 40, 50, 60 } };
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                    Console.Write("{0} ", m1[i, j]);
                Console.WriteLine();
            }

            int[][] m2 = new int[2][];
            m2[0] = new int[3] { 10, 20, 30 };
            m2[1] = new int[4] { 40, 50, 60, 70 };
            for (int i = 0; i < m2.Length; i++)
            {
                for (int j = 0; j < m2[i].Length; j++)
                    Console.Write("{0} ", m2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(100, "Gigel", 23, 9.5f);
            Student s3 = new Student(s2);
            s1.afisare();
            s2.afisare();
            s3.afisare();

        }
    }
}
