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
using System.Xml;

namespace Sem3PAW_1052
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("nbrfxrates.xml");
            string str = sr.ReadToEnd();
            sr.Close();

            XmlReader reader = XmlReader.Create(new StringReader(str));
            while(reader.Read())
            {
                if(reader.Name== "PublishingDate" && reader.NodeType==XmlNodeType.Element)
                {
                    reader.Read();
                    tbData.Text = reader.Value;
                }
                if(reader.Name=="Rate" && reader.NodeType == XmlNodeType.Element)
                {
                    string atribut = reader["currency"];
                    if(atribut=="EUR")
                    {
                        reader.Read();
                        tbEur.Text = reader.Value;
                    }
                    else
                         if (atribut == "USD")
                        {
                            reader.Read();
                            tbUsd.Text = reader.Value;
                        }
                    else
                         if (atribut == "GBP")
                        {
                            reader.Read();
                            tbGbp.Text = reader.Value;
                        }
                    else
                         if (atribut == "XAU")
                        {
                            reader.Read();
                            tbXau.Text = reader.Value;
                        }
                }
            }
        }
    }
}
