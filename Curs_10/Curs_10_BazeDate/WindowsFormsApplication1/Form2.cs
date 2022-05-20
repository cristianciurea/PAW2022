using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.SQLite;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string Provider;

        public Form2()
        {
            InitializeComponent();
            Provider = "Data Source=web.ase.ro,60231;Initial Catalog=WebccDB;Persist Security Info=True;User ID=cristian.ciurea;Password=MKI(*&ujn";
            //Provider = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = student.accdb";
            //Provider = "Data Source=student.db; Version=3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLiteConnection conexiune = new SQLiteConnection(Provider);
            //OleDbConnection conexiune = new OleDbConnection(Provider);
            SqlConnection conexiune = new SqlConnection(Provider);
            //SQLiteCommand comanda = new SQLiteCommand();
            //OleDbCommand comanda = new OleDbCommand();
            SqlCommand comanda = new SqlCommand();
            comanda.Connection = conexiune;
            int cod = 999;
            string nume = tbNume.Text;
            string cnp = tbCNP.Text;
            int varsta = 0;
            int inaltime = 0;
            try
            {
                varsta = Convert.ToInt32(tbVarsta.Text);
                inaltime = Convert.ToInt32(tbInaltime.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string sex = cbSex.Text;
            string forma = cbForma.Text;
            try
            {
                conexiune.Open();
                comanda.Transaction = conexiune.BeginTransaction();
                comanda.CommandText = "SELECT MAX(cod) FROM student";
                cod = Convert.ToInt32(comanda.ExecuteScalar());
                //comanda.CommandText = "INSERT INTO student VALUES(?,?,?,?,?,?,?)";
                //comanda.CommandText = "INSERT INTO student VALUES(@cod,@nume,@varsta,@inaltime,@CNP,@sex,@forma)";
                comanda.CommandText = "INSERT INTO student(cod,nume,varsta,inaltime,CNP,sex,forma) VALUES(@cod,@nume,@varsta,@inaltime,@CNP,@sex,@forma)";
                //comanda.Parameters.Add("cod", OleDbType.Integer).Value = cod+1;
                //comanda.Parameters.Add("@cod", SqlDbType.Int).Value = cod+1;
                //comanda.Parameters.Add(new SQLiteParameter("@cod", DbType.Int32));
                //comanda.Parameters["@cod"].Value = cod + 1;
                comanda.Parameters.AddWithValue("@cod", cod + 1);

                //comanda.Parameters.Add("nume", OleDbType.Char, 10).Value = nume;
                //comanda.Parameters.Add("@nume", SqlDbType.Char, 10).Value = nume;
                //comanda.Parameters.Add(new SQLiteParameter("@nume", DbType.String, 10));
                //comanda.Parameters["@nume"].Value = nume;
                comanda.Parameters.AddWithValue("@nume", nume);

                //comanda.Parameters.Add("varsta", OleDbType.Integer).Value = varsta;
                //comanda.Parameters.Add("@varsta", SqlDbType.Int).Value = varsta;
                //comanda.Parameters.Add(new SQLiteParameter("@varsta", DbType.Int32));
                //comanda.Parameters["@varsta"].Value = varsta;
                comanda.Parameters.AddWithValue("@varsta", varsta);

                //comanda.Parameters.Add("inaltime", OleDbType.Integer).Value = inaltime;
                //comanda.Parameters.Add("@inaltime", SqlDbType.Int).Value = inaltime;
                //comanda.Parameters.Add(new SQLiteParameter("@inaltime", DbType.Int32));
                //comanda.Parameters["@inaltime"].Value = inaltime;
                comanda.Parameters.AddWithValue("@inaltime", inaltime);

                //comanda.Parameters.Add("CNP", OleDbType.Char, 13).Value = cnp;
                //comanda.Parameters.Add("@CNP", SqlDbType.Char, 13).Value = cnp;
                //comanda.Parameters.Add(new SQLiteParameter("@CNP", DbType.String, 13));
                //comanda.Parameters["@CNP"].Value = cnp;
                comanda.Parameters.AddWithValue("@CNP", cnp);

                //comanda.Parameters.Add("sex", OleDbType.Char, 2).Value = sex;
                //comanda.Parameters.Add("@sex", SqlDbType.Char, 2).Value = sex;
                //comanda.Parameters.Add(new SQLiteParameter("@sex", DbType.String, 2));
                //comanda.Parameters["@sex"].Value = sex;
                comanda.Parameters.AddWithValue("@sex", sex);

                //comanda.Parameters.Add("forma", OleDbType.Char, 10).Value = forma;
                //comanda.Parameters.Add("@forma", SqlDbType.Char, 10).Value = forma;
                //comanda.Parameters.Add(new SQLiteParameter("@forma", DbType.String, 10));
                //comanda.Parameters["@forma"].Value = forma;
                comanda.Parameters.AddWithValue("@forma", forma);
                
                comanda.ExecuteNonQuery();
                comanda.Transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comanda.Transaction.Rollback();
            }
            finally
            {
                conexiune.Close();
                tbNume.Clear();
                tbCNP.Clear();
                tbVarsta.Clear();
                tbInaltime.Clear();
                cbSex.Text = "";
                cbForma.Text = "";
            }
        }
    }
}
