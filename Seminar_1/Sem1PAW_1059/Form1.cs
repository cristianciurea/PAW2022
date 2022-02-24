using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem1PAW_1059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tbNume.Text);

            int cod = Convert.ToInt32(tbCod.Text);
            string nume = tbNume.Text;
            int varsta = Convert.ToInt32(tbVarsta.Text);
            float medie = (float)Convert.ToDouble(tbMedie.Text);

            Student s = new Student(cod, nume, varsta, medie);

            MessageBox.Show(s.ToString());
        }
    }
}
