using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string Provider;

        public Form1()
        {
            InitializeComponent();
            Provider = "Data Source=web.ase.ro,60231;Initial Catalog=WebccDB;Persist Security Info=True;User ID=*****;Password=*****";
            //Provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = student.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //OleDbConnection conexiune = new OleDbConnection(Provider);
            SqlConnection conexiune = new SqlConnection(Provider);
            string sql = "SELECT * FROM student";
            //OleDbCommand comanda = new OleDbCommand(sql, conexiune);
            SqlCommand comanda = new SqlCommand(sql, conexiune);
            try
            {
                conexiune.Open();
                //OleDbDataReader reader = comanda.ExecuteReader();
                SqlDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["varsta"].ToString());
                    itm.SubItems.Add(reader["inaltime"].ToString());
                    itm.SubItems.Add(reader["CNP"].ToString());
                    itm.SubItems.Add(reader["sex"].ToString());
                    itm.SubItems.Add(reader["forma"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
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
            //OleDbConnection conexiune = new OleDbConnection(Provider);
            SqlConnection conexiune = new SqlConnection(Provider);

            foreach(ListViewItem itm in listView1.Items)
                if (itm.Checked==true)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    string sql = "DELETE FROM student WHERE cod=" + cod +"" ;
                    //OleDbCommand comanda = new OleDbCommand(sql, conexiune);
                    SqlCommand comanda = new SqlCommand(sql, conexiune);
                    try
                    {
                        conexiune.Open();
                        comanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            listView1.Items.Clear();
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OleDbConnection conexiune = new OleDbConnection(Provider);
            SqlConnection conexiune = new SqlConnection(Provider);

            foreach(ListViewItem itm in listView1.Items)
                if (itm.Selected==true)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    string sql = "UPDATE student SET forma='ZI' WHERE cod=" + cod;// +"";
                    //OleDbCommand comanda = new OleDbCommand(sql, conexiune);
                    SqlCommand comanda = new SqlCommand(sql, conexiune);
                    try
                    {
                        conexiune.Open();
                        comanda.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            listView1.Items.Clear();
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }
    }
}
