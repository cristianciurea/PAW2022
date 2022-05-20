using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sem10PAW_1052
{
    public partial class Form2 : Form
    {
        string connString;

        public Form2()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = baza1052.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("Conexiune cu succes");
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM studenti";
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["varsta"].ToString());
                    itm.SubItems.Add(reader["nota"].ToString());
                    itm.SubItems.Add(reader["forma"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach(ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked == true)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "UPDATE studenti SET forma='IF' WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            button1_Click(sender, e);
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                {
                    if (itm.Selected == true)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM studenti WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }
    }
}
