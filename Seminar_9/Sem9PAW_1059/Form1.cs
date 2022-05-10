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
using System.Drawing.Printing;

namespace Sem9PAW_1059
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Bitmap bmp;
        double[] vect = new double[30];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;

        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
        Color culoare = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            //gr = this.CreateGraphics();//1
            //gr = Graphics.FromHwnd(this.Handle);//3
            bmp = new Bitmap(this.Width, this.Height);
            gr = Graphics.FromImage(bmp); //4
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rectangle = new Rectangle(40, 40, 300, 300);
            //gr.DrawRectangle(pen, rectangle);
            Brush br = new SolidBrush(Color.Aqua);
            gr.FillRectangle(br, rectangle);
            gr.DrawString("Dreptunghi", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold), 
                new SolidBrush(Color.Green),
                40, 40);
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //gr = e.Graphics;//2
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rectangle = new Rectangle(40, 40, 300, 300);
            gr.DrawEllipse(pen, rectangle);
            gr.DrawString("Elipsa", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                new SolidBrush(Color.Green),
                40, 60);
            this.Invalidate();
        }

        private void placintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            Rectangle rectangle = new Rectangle(40, 40, 300, 300);
            gr.DrawPie(pen, rectangle, 150, 300);
            gr.DrawString("Placinta", new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold),
                new SolidBrush(Color.Green),
                40, 80);
            this.Invalidate();
        }

        private void linieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black, 3);
            gr.DrawLine(pen, 40, 40, 100, 100);
            this.Invalidate();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                vect[nrElem] = Convert.ToDouble(linie);
                nrElem++;
                vb = true;
            }
            sr.Close();
            MessageBox.Show("Date incarcate! "+nrElem+" valori");
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(vb==true)
            {
                Graphics gr = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X +marg,
                    panel1.ClientRectangle.Y +2*marg,
                    panel1.ClientRectangle.Width - 2*marg,
                    panel1.ClientRectangle.Height - 3*marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double valMax = vect.Max();

                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for(int i=0;i<nrElem;i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / valMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / valMax * rec.Height));
                    gr.FillRectangle(br, recs[i]);
                    //gr.FillEllipse(br, recs[i]);
                    gr.DrawString(vect[i].ToString(), font,
                        br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime/2), recs[i].Location.Y),
                        new Point((int)(recs[i+1].Location.X+latime/2), recs[i+1].Location.Y));
            }
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics gr = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 2 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double valMax = vect.Max();

                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / valMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / valMax * rec.Height));
                    gr.FillRectangle(br, recs[i]);
                    //gr.FillEllipse(br, recs[i]);
                    gr.DrawString(vect[i].ToString(), font,
                        br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            panel1.Invalidate();
        }

        private void save(Control c, string denumire)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X,
               c.ClientRectangle.Y, c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(denumire);
            img.Dispose();
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(panel1, "poza.bmp");
            MessageBox.Show("Poza salvata!");
        }
    }
}
