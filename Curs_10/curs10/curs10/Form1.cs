﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SQLite;

namespace curs10
{
    public partial class Form1 : Form
    {
        string connString;

        public Form1()
        {
            InitializeComponent();
            //connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
            connString = "Data Source=student3.db; Version=3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //OleDbConnection conexiune = new OleDbConnection(connString);
            SQLiteConnection conexiune = new SQLiteConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("Conexiune deschisa!");
                //OleDbCommand comanda = new OleDbCommand("SELECT * FROM studenti");
                SQLiteCommand comanda = new SQLiteCommand("SELECT * FROM studenti");
                comanda.Connection = conexiune;
                //OleDbDataReader reader = comanda.ExecuteReader();
                SQLiteDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["varsta"].ToString());
                    itm.SubItems.Add(reader["nota"].ToString());
                    itm.SubItems.Add(reader["forma"].ToString());
                    listView1.Items.Add(itm);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OleDbConnection conexiune = new OleDbConnection(connString);
            SQLiteConnection conexiune = new SQLiteConnection(connString);
            try
            {
                conexiune.Open();
                //OleDbCommand comanda = new OleDbCommand();
                SQLiteCommand comanda = new SQLiteCommand();
                comanda.Connection = conexiune;
                foreach(ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "UPDATE studenti SET forma='ZI' WHERE cod="+cod;
                        comanda.ExecuteNonQuery();
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
            //OleDbConnection conexiune = new OleDbConnection(connString);
            SQLiteConnection conexiune = new SQLiteConnection(connString);
            try
            {
                conexiune.Open();
                //OleDbCommand comanda = new OleDbCommand();
                SQLiteCommand comanda = new SQLiteCommand();
                comanda.Connection = conexiune;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                    {
                        int cod = Convert.ToInt32(itm.SubItems[0].Text);
                        comanda.CommandText = "DELETE FROM studenti WHERE cod=" + cod;
                        comanda.ExecuteNonQuery();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
    }
}
