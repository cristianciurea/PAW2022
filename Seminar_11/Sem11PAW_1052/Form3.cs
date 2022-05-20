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

namespace Sem10PAW_1052
{
    public partial class Form3 : Form
    {
        string connString;

        public Form3()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = baza1052.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();
                comanda.CommandText = "SELECT MAX(cod) FROM studenti";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO studenti VALUES(?,?,?,?,?)";
                comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod + 1;
                comanda.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                comanda.Parameters.Add("varsta", OleDbType.Integer).Value = Convert.ToInt32(tbVarsta.Text);
                comanda.Parameters.Add("nota", OleDbType.Integer).Value = Convert.ToInt32(tbNota.Text);
                comanda.Parameters.Add("forma", OleDbType.Char, 2).Value = cbForma.Text;
                comanda.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbVarsta.Clear();
                tbNota.Clear();
                cbForma.Text = "";
            }
        }
    }
}
