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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
            string connString = "Data Source = student3.db; Version=3";
            //OleDbConnection conexiune = new OleDbConnection(connString);
            SQLiteConnection conexiune = new SQLiteConnection(connString);
            try
            {
                conexiune.Open();
                //OleDbCommand comanda = new OleDbCommand();
                SQLiteCommand comanda = new SQLiteCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT MAX(cod) FROM studenti";
                int cod = Convert.ToInt32(comanda.ExecuteScalar());
                comanda.CommandText = "INSERT INTO studenti(cod,nume,varsta,nota,forma) VALUES(@cod,@nume,@varsta,@nota,@forma)";
                //comanda.CommandText = "INSERT INTO studenti VALUES(?,?,?,?,?)";
                //comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod + 1;
                //comanda.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                //comanda.Parameters.Add("varsta", OleDbType.Integer).Value = Convert.ToInt32(tbVarsta.Text);
                //comanda.Parameters.Add("nota", OleDbType.Integer).Value = Convert.ToInt32(tbMedie.Text);
                //comanda.Parameters.Add("forma", OleDbType.Char, 2).Value = cbForma.Text;
                comanda.Parameters.Add(new SQLiteParameter("@cod", DbType.UInt32));
                comanda.Parameters["@cod"].Value = cod + 1;
                comanda.Parameters.Add(new SQLiteParameter("@nume", DbType.String, 20));
                comanda.Parameters["@nume"].Value = tbNume.Text;
                comanda.Parameters.Add(new SQLiteParameter("@varsta", DbType.UInt32));
                comanda.Parameters["@varsta"].Value = Convert.ToInt32(tbVarsta.Text);
                comanda.Parameters.Add(new SQLiteParameter("@nota", DbType.UInt32));
                comanda.Parameters["@nota"].Value = Convert.ToInt32(tbMedie.Text);
                comanda.Parameters.Add(new SQLiteParameter("@forma", DbType.String, 2));
                comanda.Parameters["@forma"].Value = cbForma.Text;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbVarsta.Clear();
                tbMedie.Clear();
                cbForma.Text = "";
            }
        }
    }
}
