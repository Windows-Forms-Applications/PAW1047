using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(12, "Grivei", 24.5f);
            a1.Nume = "Azorel";
            Console.WriteLine(a1.Nume);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2);

            Caine c1 = new Caine(2, "Oscar", 5, "golden", true);
            Maimutza m1 = new Maimutza(5, "Kiki", 25, "neagra", 2);
            Animal a3 = (Animal)a2.Clone();

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(c1);
            z1.ListaAnimale.Add(m1);
            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire += " copie";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            z1.ListaAnimale.Sort();
            Console.WriteLine(z1);
            z2.ListaAnimale.Sort();
            Console.WriteLine(z2);
        }
    }
}
