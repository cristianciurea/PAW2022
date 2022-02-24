using System;
using System.Collections.Generic; //List<>
using System.Collections; //ArrayList
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1059
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele dvs.: ");
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();
            Console.WriteLine("Numele dvs. este {0} si prenumele este {1}", nume, prenume);

            int[] v1 = { 1, 2, 3, 4 };
            for (int i = 0; i < v1.Length; i++)
                Console.WriteLine(v1[i]);

            int[] v2 = new int[4] { 1, 2, 3, 4 };
            //shallow copy
            int[] v3 = v2;
            v2[1] = 10;
            for (int i = 0; i < v3.Length; i++)
                Console.WriteLine(v3[i]);
            Console.WriteLine("----------------------");
            //deep copy
            int[] v4 = new int[v2.Length];
            for (int i = 0; i < v2.Length; i++)
                v4[i] = v2[i]; //var 1
            v2[1] = 20;
            for (int i = 0; i < v4.Length; i++)
                Console.WriteLine(v4[i]);

            Console.WriteLine("----------------------");
            int[] v5 = (int[])v2.Clone(); //var 2
            v2[1] = 30;
            for (int i = 0; i < v5.Length; i++)
                Console.WriteLine(v5[i]);

            //matrice var 1
            int[,] mat1 = new int[2, 3] { { 10, 20, 30 }, {40, 50, 60 } };
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write("{0} ", mat1[i, j]);
                Console.WriteLine();
            }

            //matrice var 2 - zig zag (scara)
            int[][] mat2 = new int[2][];
            mat2[0] = new int[3] { 100, 200, 300 };
            mat2[1] = new int[4] { 400, 500, 600, 700 };
            for(int i=0;i<mat2.Length;i++)
            {
                for(int j=0;j<mat2[i].Length;j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(123, "Gigel", 22, 9.5f);
            Student s3 = s2; //shallow copy
            Student s4 = new Student(s2); //deep copy

            s3.Nume = "Dorel";
            Console.WriteLine(s3.Nume);

            s1.afisare();
            s2.afisare();
            s3.afisare();
            s4.afisare();

            Student[] vs = new Student[4] { s1, s2, s3, s4 };
            for (int i = 0; i < vs.Length; i++)
                vs[i].afisare();
            Console.WriteLine("----------------------");
            for (int i = 0; i < vs.Length; i++)
                Console.WriteLine(vs[i]);
            Console.WriteLine("----------------------");
            foreach (Student s in vs)
                Console.WriteLine(s);

            Console.WriteLine("----------------------");
            //List<Student> listaStud = new List<Student>();
            ArrayList listaStud = new ArrayList();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Add(s4);
            listaStud.Remove(s3);
            for (int i = 0; i < listaStud.Count; i++)
                Console.WriteLine(listaStud[i]);
            foreach (Student s in listaStud)
                Console.WriteLine(s);

            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }


}
