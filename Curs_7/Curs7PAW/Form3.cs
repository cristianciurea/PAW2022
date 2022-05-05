using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Curs7PAW
{
    public partial class Form3 : Form
    {
        ArrayList lista2;
        public Form3(ArrayList lista)
        {
            InitializeComponent();
            lista2 = lista;
            foreach (Abonat a in lista)
                textBox1.Text += a.ToString() + Environment.NewLine;
        }
    }
}
