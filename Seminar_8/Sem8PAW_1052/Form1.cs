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

namespace Sem8PAW_1052
{
    public partial class Form1 : Form
    {
        Graphics g;
        double[] vect = new double[30];
        int nrElem = 0;
        bool vb = false;
        const int marg = 10;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics(); //var 1
            /*g = Graphics.FromHwnd(this.Handle); // var 2
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp); //var 3*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //g = e.Graphics; //var 4
            if(vb == true)
            {
                g = e.Graphics;
                Rectangle rec = new Rectangle(this.ClientRectangle.X + marg,
                    this.ClientRectangle.Y + 4 * marg,
                    this.ClientRectangle.Width - 2 * marg,
                    this.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for(int i=0;i<nrElem;i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    //g.FillRectangle(br, recs[i]);
                    //g.FillEllipse(br, recs[i]);
                    g.DrawString(vect[i].ToString(), font,
                        br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime/2), recs[i].Location.Y),
                            new Point((int)(recs[i + 1].Location.X + latime/2), recs[i + 1].Location.Y));
            }
        }

        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 300);
            g.DrawRectangle(pen, rec);
            g.DrawString("Dreptunghi", this.Font, new SolidBrush(Color.Black), 40, 40);
        }

        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 3);
            Rectangle rec = new Rectangle(40, 40, 300, 300);
            g.DrawEllipse(pen, rec);
            g.DrawString("Elipsa", this.Font, new SolidBrush(Color.Black), 40, 60);
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
            //this.Invalidate();
            panel1.Invalidate();
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            this.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            this.Invalidate();
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
            //save(this, "poza.bmp");
            save(panel1, "poza.bmp");
            MessageBox.Show("Desen salvat!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                g = e.Graphics;
                Rectangle rec = new Rectangle(panel1.ClientRectangle.X + marg,
                    panel1.ClientRectangle.Y + 4 * marg,
                    panel1.ClientRectangle.Width - 2 * marg,
                    panel1.ClientRectangle.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    //g.FillRectangle(br, recs[i]);
                    //g.FillEllipse(br, recs[i]);
                    g.DrawString(vect[i].ToString(), font,
                        br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                            new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
            }
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                g = e.Graphics;
                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 4 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 5 * marg);
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 3;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);
                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - vect[i] / vMax * rec.Height),
                        (int)latime,
                        (int)(vect[i] / vMax * rec.Height));
                    //g.FillRectangle(br, recs[i]);
                    //g.FillEllipse(br, recs[i]);
                    g.DrawString(vect[i].ToString(), font,
                        br, new Point(recs[i].Location.X, recs[i].Location.Y - font.Height));
                }
                g.FillRectangles(br, recs);

                for (int i = 0; i < nrElem - 1; i++)
                    g.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                            new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));
            }
        }

        private void previzualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
