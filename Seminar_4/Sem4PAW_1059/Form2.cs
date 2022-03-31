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
using System.Runtime.Serialization.Formatters.Binary;

namespace Sem3PAW_1059
{
    public partial class Form2 : Form
    {
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
            /*foreach (Student s in lista)
                textBox1.Text += s.ToString() + Environment.NewLine;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Student s in lista2)
                textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            //bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs, lista2);
            fs.Close();
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            //textBox1.Text = (string)bf.Deserialize(fs);
            List<Student> lista3 = (List<Student>)bf.Deserialize(fs);

            foreach (Student s in lista3)
                textBox1.Text += s.ToString() + Environment.NewLine;

            fs.Close();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }
    }
}
