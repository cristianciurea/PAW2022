using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem10PAW_1052
{
    public partial class Form1 : Form
    {
        int y = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("text pus in Clipboard...");
            Student s = new Student(123, "Gigel", 9.5f);
            Clipboard.SetDataObject(s);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*string text = Clipboard.GetText();
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, 10);*/
            Graphics g = Graphics.FromHwnd(panel1.Handle);
            IDataObject o = Clipboard.GetDataObject();
            if(o.GetDataPresent(typeof(string)))
            {
                string text = o.GetData(typeof(string)).ToString();
                g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, 10);
            }
            else
                if(o.GetDataPresent(typeof(Bitmap)))
            {
                Bitmap bmp = (Bitmap)o.GetData(typeof(Bitmap));
                g.DrawImage(bmp, 0, 0);
            }
            else
                if(o.GetDataPresent(typeof(Student)))
            {
                Student s1 = (Student)o.GetData(typeof(Student));
                g.DrawString(s1.ToString(), this.Font, new SolidBrush(Color.Red), 10, 10);
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy |
                DragDropEffects.Move);

        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8 && 
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy))
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            string text = e.Data.GetData(typeof(string)).ToString();
            Graphics g = Graphics.FromHwnd(panel2.Handle);
            g.DrawString(text, this.Font, new SolidBrush(Color.Red), 10, y);
            y += 20;
            if (e.Effect == DragDropEffects.Move)
                textBox1.Clear();
            if(y>panel2.Height)
            {
                panel2.Invalidate();
                y = 10;
            }
        }
    }
}
