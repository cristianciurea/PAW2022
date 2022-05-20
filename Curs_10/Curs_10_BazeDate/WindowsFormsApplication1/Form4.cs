using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        string Provider;

        public Form4()
        {
            InitializeComponent();
            //Provider = "Data Source=web.ase.ro,60231;Initial Catalog=WebccDB;Persist Security Info=True;User ID=cristian.ciurea;Password=MKI(*&ujn";
            Provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = student.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(Provider);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM student", conexiune);
            DataSet dataSet = new DataSet();
            adaptor.Fill(dataSet, "student");

            DataTable tabela = dataSet.Tables["student"];
            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += Environment.NewLine;

            foreach (DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "   ";
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(Provider);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM student", conexiune);
            DataSet dataSet = new DataSet();
            adaptor.Fill(dataSet, "student");

            DataTable tabela = dataSet.Tables["student"];

            DataRow[] rows = tabela.Select("forma='ID'", "forma");
            foreach (DataRow linie in rows)
                textBox1.Text += linie["nume"] + " " + linie["forma"] + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            OleDbConnection conexiune = new OleDbConnection(Provider);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM student", conexiune);
            DataSet dataSet = new DataSet();
            adaptor.Fill(dataSet, "student");

            DataTable tabela = dataSet.Tables["student"];

            DataView dv = new DataView(tabela);
            dv.Sort = "nume";
            dv.RowFilter = "forma='ID'";
            foreach (DataRowView linie in dv)
                textBox1.Text += linie["nume"] + " " + linie["forma"] + Environment.NewLine;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            string stringProcedura = "CREATE PROCEDURE StudentiVarsta AS " +
                "SELECT * from student WHERE varsta=@varsta";
            OleDbConnection Conexiune = new OleDbConnection(Provider);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = Conexiune;
            comanda.CommandType = CommandType.Text;

            OleDbDataReader reader;

            //daca exista, se sterge procedura stocata
            comanda.CommandText = "DROP PROCEDURE StudentiVarsta";
            try
            {
                Conexiune.Open();
                reader = comanda.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // se creaza noua procedura
            comanda.CommandText = stringProcedura;
            comanda.CommandType = CommandType.Text;
            try
            {
                reader = comanda.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexiune.Close();
            }
            textBox1.Text = "Procedura creata cu succes!";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            OleDbConnection Conexiune = new OleDbConnection(Provider);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = Conexiune;
            comanda.CommandText = "StudentiVarsta";
            comanda.CommandType = CommandType.StoredProcedure;

            OleDbDataReader reader;

            try
            {
                Conexiune.Open();
                comanda.Parameters.Add("@varsta", OleDbType.Integer);
                comanda.Parameters["@varsta"].Value = 22;
                comanda.Parameters["@varsta"].Direction = ParameterDirection.Input;
                reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    textBox1.Text += "\r\n" + reader["nume"] + " " + reader["varsta"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexiune.Close();
            }
        }
    }
}
