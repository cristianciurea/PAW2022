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
    public partial class Form4 : Form
    {
        string connString;

        public Form4()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = baza1052.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", 
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");
            DataTable tabela = ds.Tables["studenti"];

            dataGridView1.DataSource = tabela;

            /*foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "    ";
            textBox1.Text += Environment.NewLine;
            foreach(DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "     ";
                textBox1.Text += Environment.NewLine;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti",
                conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");
            DataTable tabela = ds.Tables["studenti"];

            DataView dv = new DataView(tabela);
            dv.RowFilter = "forma='IF'";
            dv.Sort = "nume";
            foreach (DataRowView linie in dv)
                textBox1.Text += linie["nume"] + " " + linie["forma"] +
                    Environment.NewLine;
        }
    }
}
