using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3PAW_1052
{
    public partial class Form1 : Form
    {
        List<Student> listaStud = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCod.Text == "")
                errorProvider1.SetError(tbCod, "Introduceti codul!");
            else
                  if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Selectati sexul!");
            else
                  if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta!");
            else
                  if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                  if (tbNote.Text == "")
                errorProvider1.SetError(tbNote, "Introduceti notele!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int cod = Convert.ToInt32(tbCod.Text);
                    char sex = Convert.ToChar(cbSex.Text);
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    string nume = tbNume.Text;
                    string[] noteS = tbNote.Text.Trim().Split(',');
                    int[] note = new int[noteS.Length];
                    for (int i = 0; i < noteS.Length; i++)
                        note[i] = Convert.ToInt32(noteS[i]);

                    Student s = new Student(cod, sex, varsta, nume, note);
                    MessageBox.Show(s.ToString());
                    listaStud.Add(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCod.Clear();
                    cbSex.Text = "";
                    tbVarsta.Clear();
                    tbNume.Clear();
                    tbNote.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaStud);
            frm.ShowDialog();
        }
    }
}
