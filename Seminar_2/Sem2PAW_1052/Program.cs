using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1052
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Grivei", 12.5f);
            Animal a3 = (Animal)a2.Clone(); //deep copy
            a3.Nume = "Azorel";
            a3.Greutate = 14.2f;
            Animal a4 = a2; //shallow copy
            Animal a5 = new Animal(a2); //deep copy
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            /*if (a2.CompareTo(a3) == 0)
                Console.WriteLine("sunt egale");*/

            string[] hrana = new string[3] { "zebra", "vita", "bizon" };
            Leu l1 = new Leu(12, "Simba", 50, 'M', hrana, true);
            Console.WriteLine(l1);

            Zebra z1 = new Zebra(10, "Pumba", 60, 300, "Zimbabwe");
            Console.WriteLine(z1);

            Zoo zoo1 = new Zoo();
            zoo1.ListaAnimale.Add(l1);
            zoo1.ListaAnimale.Add(z1);
            zoo1.ListaAnimale.Add(a1);
            zoo1.ListaAnimale.Add(a2);
            zoo1.ListaAnimale.Add(a3);
            zoo1.ListaAnimale.Add(a5);
         
            zoo1.ListaAnimale.Sort();

            Console.WriteLine(zoo1);

            Zoo zoo2 = (Zoo)zoo1.Clone();
            zoo2.Denumire = "Berlin";
            foreach (Animal a in zoo2.ListaAnimale)
                a.Nume += " copie";

            Console.WriteLine(zoo1);
            Console.WriteLine(zoo2);

            a2 = a2 + 7;
            a3 += 5; //a3 = a3+5;
            a5 = 9 + a5;

            Console.WriteLine(zoo2[3]);
            Console.WriteLine("Media greutatilor este: " + (float)zoo2);
        }
    }
}
