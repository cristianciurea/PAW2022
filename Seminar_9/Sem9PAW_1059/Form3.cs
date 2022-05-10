using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem9PAW_1059
{
    public partial class Form3 : Form
    {
        int y = 10;

        Student[] vectStud = { new Student(123,"Gigel",9.5f),
            new Student(456, "Dorel", 8.9f),
            new Student(789, "Maricica", 9.7f)};

        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < vectStud.Length; i++)
                listBox1.Items.Add(vectStud[i].ToString());
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text,
                DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if(((e.KeyState & 8)==8) && (e.AllowedEffect & DragDropEffects.Copy)==
                    DragDropEffects.Copy)
                   e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move)==
                    DragDropEffects.Move)
                   e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics gr = Graphics.FromHwnd(panel1.Handle);
            gr.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (e.Effect == DragDropEffects.Move)
            {
                textBox1.Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            if (y > panel1.Height)
            {
                MessageBox.Show("Cosul e plin!");
                panel1.Invalidate();
                y = 10;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listBox1.Items.Count>0)
                 listBox1.DoDragDrop(listBox1.SelectedItem,
                    DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) ==
                    DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) ==
                    DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            foreach (Student s in vectStud)
                if (text == s.Nume)
                    listBox1.Items.Add(s.ToString());
        }
    }
}
