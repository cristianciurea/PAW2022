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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            }
            catch(Exception ex)
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
}
