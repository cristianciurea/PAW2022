using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Sem8PAW_1059
{
    public partial class Form2 : Form
    {
        List<Produs> lista2;
        public Form2(List<Produs> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Produse");
            treeView1.Nodes.Add(parinte);

            foreach(Produs p in lista2)
            {
                TreeNode copil = new TreeNode(p.Cod + "|" + p.Denumire + 
                    "|" + p.Pret + "|" + p.Cantitate);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (p.Pret > 5)
                    nepot.Text = "scump";
                else
                    nepot.Text = "ieftin";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            foreach (TreeNode parinte in treeView1.Nodes)
            {
                writer.WriteStartElement(parinte.Text);
                foreach (TreeNode copil in parinte.Nodes)
                {
                    writer.WriteStartElement(copil.Text);
                    foreach(TreeNode nepot in copil.Nodes)
                    {
                        writer.WriteStartElement(nepot.Text);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndDocument();
            writer.Close();

            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("export.xml");
            sw.WriteLine(str);
            sw.Close();

            MessageBox.Show("Exportat!");
        }
    }
}
