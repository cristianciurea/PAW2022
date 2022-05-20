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
using System.Data.SQLite;

namespace curs10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
            string connString = "Data Source=student3.db; Version=3";
            //OleDbConnection conexiune = new OleDbConnection(connString);
            SQLiteConnection conexiune = new SQLiteConnection(connString);
            //OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM studenti", conexiune);
            SQLiteDataAdapter adaptor = new SQLiteDataAdapter("SELECT * FROM studenti", conexiune);

            DataSet ds = new DataSet();
            adaptor.Fill(ds, "studenti");

            DataTable tabela = ds.Tables["studenti"];
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
    }
}
