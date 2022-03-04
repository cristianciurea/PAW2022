using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1059
{
    class Girafa: Animal
    {
        private float lungimeGat;
        private int nrPete;

        public Girafa():base()
        {
            lungimeGat = 0.0f;
            nrPete = 0;
        }

        public Girafa(int v, string n, float g, float lg, int nr):
            base(v, n, g)
        {
            lungimeGat = lg;
            nrPete = nr;
        }

        public float LungimeGat { get => lungimeGat; set => lungimeGat = value; }
        public int NrPete { get => nrPete; set => nrPete = value; }

        public override string ToString()
        {
            return base.ToString() + " si are lungime gat "+lungimeGat+
                " si numar pete "+nrPete;
        }
    }
}
