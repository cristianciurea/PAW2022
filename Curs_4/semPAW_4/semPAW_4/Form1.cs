using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace semPAW_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.xml)|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string str = sr.ReadToEnd();
                sr.Close();
                fs.Close();

                XmlReader reader = XmlReader.Create(new StringReader(str));
                while (reader.Read())
                {
                    if (reader.Name == "PublishingDate" && reader.NodeType == XmlNodeType.Element)
                    {
                        reader.Read();
                        tbData.Text = reader.Value;
                    }
                    else if (reader.Name == "Rate")
                    {
                        string attribute = reader["currency"];
                        if (attribute == "EUR")
                        {
                            reader.Read();
                            tbEUR.Text = reader.Value;
                        }
                        else if (attribute == "USD")
                        {
                            reader.Read();
                            tbUSD.Text = reader.Value;
                        }
                        else if (attribute == "GBP")
                        {
                            reader.Read();
                            tbGBP.Text = reader.Value;
                        }
                        else if (attribute == "XAU")
                        {
                            reader.Read();
                            tbXAU.Text = reader.Value;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            using (writer)
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Curs valutar");

                writer.WriteStartElement("Data curs:");
                writer.WriteValue(tbData.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("EUR:");
                writer.WriteAttributeString("valuta", "EUR");
                writer.WriteValue(tbEUR.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("USD:");
                writer.WriteAttributeString("valuta", "USD");
                writer.WriteValue(tbUSD.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("GBP:");
                writer.WriteAttributeString("valuta", "GBP");
                writer.WriteValue(tbGBP.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("XAU:");
                writer.WriteAttributeString("valuta", "XAU");
                writer.WriteValue(tbXAU.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            writer.Close();

            string xml = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(xml);
            sw.Close();
            MessageBox.Show("Fisier generat!");

            textBox1.Text = xml;
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            //string s = textBox1.Text;
            ArrayList lista = new ArrayList();
            foreach (string linie in textBox1.Lines)
                lista.Add(linie);
            bf.Serialize(fs, lista);
            fs.Close();
            textBox1.Clear();
        }

        private void deserializaewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            //textBox1.Text = (string)bf.Deserialize(fs);
            ArrayList lista = (ArrayList)bf.Deserialize(fs);
            for (int i = 0; i < lista.Count; i++)
                textBox1.Text += lista[i] + Environment.NewLine;
            fs.Close();
        }
    }
}
