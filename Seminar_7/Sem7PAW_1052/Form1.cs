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

namespace Sem7PAW_1052
{
    public partial class Form1 : Form
    {
        List<Student> lista = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Situatie");
            incarcaDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string nume = tbNume.Text;
                int nota = Convert.ToInt32(tbNota.Text);
                Student s = new Student(cod, nume, nota);
                lista.Add(s);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbNume.Clear();
                tbNota.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Student s in lista)
            {
                ListViewItem itm = new ListViewItem(s.Cod.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Nota.ToString());
                if (s.Nota >= 5)
                    itm.SubItems.Add("promovat");
                else
                    itm.SubItems.Add("nepromovat");
                listView1.Items.Add(itm);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < lista.Count; i++)
                        if (lista[i].Cod == cod)
                            lista.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < lista.Count; i++)
                        if (lista[i].Cod == cod)
                            lista.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(e.Item.Checked)
            {
                e.Item.BackColor = Color.Red;
                tbCod.Text = e.Item.SubItems[0].Text;
                tbNume.Text = e.Item.SubItems[1].Text;
                tbNota.Text = e.Item.SubItems[2].Text;
            }
        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                int cod = Convert.ToInt32(linie.Split(',')[0]);
                string nume = linie.Split(',')[1];
                int nota = Convert.ToInt32(linie.Split(',')[2]);
                Student s = new Student(cod, nume, nota);
                lista.Add(s);
            }
            sr.Close();
            MessageBox.Show("Date incarcate!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Student s in lista)
            {
                sw.Write(s.Cod);
                sw.Write(",");
                sw.Write(s.Nume);
                sw.Write(",");
                sw.Write(s.Nota);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date salvate!");
        }
    }
}
