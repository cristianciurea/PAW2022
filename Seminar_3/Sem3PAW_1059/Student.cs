using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1059
{
    class Student : Persoana, IMedia, ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private int[] note;

        public Student(): base()
        {
            Varsta = 0;
            Nume = "Anonim";
            Note = null;
        }

        public Student(int c, char s, int v, string n, int[] nt):base(c, s)
        {
            Varsta = v;
            Nume = n;
            /*note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];*/
            Note =(int[])nt.Clone();
        }

        public int Varsta { get => varsta; set => varsta = value; }
        public string Nume { get => nume; set => nume = value; }
        public int[] Note { get => note; set => note = value; }

        public float calculeazaMedie()
        {
            return (float)this;
        }

        public object Clone()
        {
            Student clona = (Student)this.MemberwiseClone();
            int[] noteNoi = (int[])note.Clone();
            clona.note = noteNoi;
            return clona;
        }

        public override string spuneAnNastere()
        {
            return (System.DateTime.Now.Year - varsta).ToString();
        }

        public override string ToString()
        {
            string rezultat = base.ToString()+" varsta "+varsta+
                " numele "+nume;
            if (note != null)
            {
                rezultat += " si are urmatoarele note: ";
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + " ";
            }
            else
                rezultat += " si nu are note!";
            return rezultat;
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
                //return 0;
                return string.Compare(this.nume, s.nume);
        }

        public static Student operator+(Student s, int notaNoua)
        {
            int[] noteNoi = new int[s.note.Length + 1];
            for (int i = 0; i < s.note.Length; i++)
                noteNoi[i] = s.note[i];
            noteNoi[noteNoi.Length-1] = notaNoua;
            s.note = noteNoi;
            return s;
        }

        public static Student operator+(int notaNoua, Student s)
        {
            return s + notaNoua;
        }

        public static Student operator++(Student s)
        {
            return s + 1;
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

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                else
                    return 0;
            }
            set
            {
                if (note != null && index >= 0 && index < note.Length
                    && value > 0 && value <= 10)
                    note[index] = value;
            }
        }
    }
}
