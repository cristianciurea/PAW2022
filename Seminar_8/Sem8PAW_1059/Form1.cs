using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sem8PAW_1059
{
    public partial class Form1 : Form
    {
        List<Produs> listaProd = new List<Produs>();

        public Form1()
        {
            InitializeComponent();
            incarcareDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string denumire = tbDenumire.Text;
                float pret = (float)Convert.ToDouble(tbPret.Text);
                float cant = (float)Convert.ToDouble(tbCantitate.Text);
                Produs p = new Produs(cod, denumire, pret, cant);
                listaProd.Add(p);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbDenumire.Clear();
                tbPret.Clear();
                tbCantitate.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Produs produs in listaProd)
            {
                ListViewItem itm = new ListViewItem(produs.Cod.ToString());
                itm.SubItems.Add(produs.Denumire);
                itm.SubItems.Add(produs.Pret.ToString());
                itm.SubItems.Add(produs.Cantitate.ToString());
                listView1.Items.Add(itm);
            }
        }

        private void incarcareDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie=sr.ReadLine())!=null)
            {
                int cod = Convert.ToInt32(linie.Split('|')[0]);
                string denumire = linie.Split('|')[1];
                float pret = (float)Convert.ToDouble(linie.Split('|')[2]);
                float cant = (float)Convert.ToDouble(linie.Split('|')[3]);
                Produs p = new Produs(cod, denumire, pret, cant);
                listaProd.Add(p);
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    foreach (Produs p in listaProd)
                        if (p.Cod == cod)
                        {
                            listaProd.Remove(p);
                            break;
                        }
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaProd.Count; i++)
                        if (listaProd[i].Cod == cod)
                            listaProd.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Produs p in listaProd)
            {
                sw.Write(p.Cod);
                sw.Write("|");
                sw.Write(p.Denumire);
                sw.Write("|");
                sw.Write(p.Pret);
                sw.Write("|");
                sw.Write(p.Cantitate);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaProd);
            frm.ShowDialog();
        }
    }
}
