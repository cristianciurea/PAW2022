using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "ceva";

            listView1.Columns.Add("Observatii");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = toolStripTextBox1.Text;
                string cnp = toolStripTextBox2.Text;
                string sex = toolStripComboBox1.Text;
                int nota = Convert.ToInt32(toolStripTextBox3.Text);

                Student s = new Student(nume, cnp, sex, nota);
                MessageBox.Show(s.ToString());
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                //this.BackColor = dlg.Color;
                contextMenuStrip1.SourceControl.BackColor = dlg.Color;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void tbNota_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int nota = Convert.ToInt32(tbNota.Text);
                if (nota < 1 || nota > 10)
                    MessageBox.Show("Nota trebuie intre 1 si 10!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbNota_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Am validat!");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti numele!");
            else
                if (tbCnp.Text == "")
                errorProvider1.SetError(tbCnp, "Introduceti cnp-ul!");
            else
                if ((tbCnp.Text.Substring(0, 1) == "1" ||
                tbCnp.Text.Substring(0, 1) == "5") &&
                cbSex.Text == "Feminin")
            {
                errorProvider1.SetError(tbCnp, "CNP nu corespunde cu sex");
                errorProvider1.SetError(cbSex, "Sex nu corespunde cu CNP");
            }
            else
             if ((tbCnp.Text.Substring(0, 1) == "2" ||
                tbCnp.Text.Substring(0, 1) == "6") &&
                cbSex.Text == "Masculin")
            {
                errorProvider1.SetError(tbCnp, "CNP nu corespunde cu sex");
                errorProvider1.SetError(cbSex, "Sex nu corespunde cu CNP");
            }
            else
            {
                try
                {
                    string nume = tbNume.Text;
                    string cnp = tbCnp.Text;
                    string sex = cbSex.Text;
                    int nota = Convert.ToInt32(tbNota.Text);

                    Student s = new Student(nume, cnp, sex, nota);
                    MessageBox.Show(s.ToString());

                    ListViewItem itm = new ListViewItem(nume);
                    itm.SubItems.Add(cnp);
                    itm.SubItems.Add(sex);
                    itm.SubItems.Add(nota.ToString());
                    listView1.Items.Add(itm);

                    throw new ExceptiaMea("Am declansat exceptia mea!");
                }
                catch(ExceptiaMea ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                    tbNume.Clear();
                    tbCnp.Clear();
                    cbSex.Text = "";
                    tbNota.Clear();
                }
            }
        }
    }

    public class ExceptiaMea: ApplicationException
    {
        public ExceptiaMea(): base()
        {

        }

        public ExceptiaMea(string mesaj) : base(mesaj)
        {

        }
    }
}
