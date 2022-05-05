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
using System.IO;

namespace Curs7PAW
{
    public partial class Form4 : Form
    {
        ArrayList lista = new ArrayList();

        public Form4()
        {
            InitializeComponent();
            listView1.Columns.Add("Categorie");
            incarcaDateFisier();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Abonat a in lista)
            {
                ListViewItem itm = new ListViewItem(a.Cod.ToString());
                itm.SubItems.Add(a.Nume);
                itm.SubItems.Add("gold");
                listView1.Items.Add(itm);
            }
        }

        private void incarcaDateFisier()
        {
            StreamReader sr = new StreamReader("abonati.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                int cod = Convert.ToInt32(linie.Split(',')[0]);
                string nume = linie.Split(',')[1];
                Abonat abonat = new Abonat(cod, nume);
                lista.Add(abonat);
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                    itm.Remove();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                    itm.Remove();
        }
    }
}
