using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1059
{
    class Zoo: ICloneable
    {
        private string denumire;
        private List<Animal> listaAnimale;

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Animal> ListaAnimale { get => listaAnimale; set => listaAnimale = value; }

        public Zoo()
        {
            denumire = "Baneasa";
            listaAnimale = new List<Animal>();
        }

        public Zoo(string den, List<Animal> lista)
        {
            denumire = den;
            listaAnimale = lista;
        }

        public override string ToString()
        {
            string rezultat = "Zoo " + denumire + " are urmatoarele animale " + Environment.NewLine;
            foreach (Animal a in listaAnimale)
                rezultat += a.ToString() + Environment.NewLine;
            return rezultat;
        }

        public object Clone()
        {
            //return this.MemberwiseClone();
            Zoo clona = (Zoo)this.MemberwiseClone();
            List<Animal> listaNoua = new List<Animal>();
            foreach (Animal a in listaAnimale)
                listaNoua.Add((Animal)a.Clone());
            clona.listaAnimale = listaNoua;
            return clona;
        }

        public Animal this[int index]
        {
            get
            {
                if (listaAnimale != null && index >= 0 && index < listaAnimale.Count)
                    return listaAnimale[index];
                else
                    return null;
            }
        }

        public static explicit operator float(Zoo z)
        {
            float medie = 0.0f;
            foreach (Animal a in z.listaAnimale)
                medie += a.Greutate;
            return medie / z.listaAnimale.Count;
        }
    }
}
