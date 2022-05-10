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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("ceva text pus aici...");
            Clipboard.SetImage(pictureBox1.BackgroundImage);
           /* Student s = new Student(123, "Gigel", 9.5f);
            Clipboard.SetDataObject(s);*/
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();

            //gr.DrawString(Clipboard.GetText(),
            //    this.Font, new SolidBrush(Color.Black), 10, 10);
            gr.DrawImage(Clipboard.GetImage(), 0, 0);
            /*IDataObject o = Clipboard.GetDataObject();
            if(o.GetDataPresent(typeof(string)))
            {
                string text = o.GetData(typeof(string)).ToString();
                gr.DrawString(text, this.Font, new SolidBrush(Color.Black), 10, 10);
            }
            else
                if(o.GetDataPresent(typeof(Bitmap)))
            {
                Bitmap bmp = (Bitmap)o.GetData(typeof(Bitmap));
                gr.DrawImage(bmp, 0, 0);
            }
            else
                if(o.GetDataPresent(typeof(Student)))
            {
                Student s1 = (Student)o.GetData(typeof(Student));
                gr.DrawString(s1.ToString(), this.Font,
                    new SolidBrush(Color.Black), 10, 10);
            }*/
        }
    }
}
