using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1059
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Dodo", 150);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Balloo";
            a3.Greutate = 200;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Pisica p1 = new Pisica(5, "Kitty", 10, "maidaneza", 'F', true);
            Girafa g1 = new Girafa(12, "Sophie", 80, 1.5f, 300);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(p1);
            z1.ListaAnimale.Add(g1);

            z1.ListaAnimale.Sort();

            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";

            Console.WriteLine(z1);
            Console.WriteLine(z2);

            a1 = a1 + 10;
            a2 += 10;
            a3 = 10 + a3;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Console.WriteLine(z2[2]);
            Console.WriteLine("Media greutatilor este: " + (float)z2);

            a3.mananca();
        }
    }
}
