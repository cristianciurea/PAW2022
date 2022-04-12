﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem5PAW_1052
{
    public partial class Form1 : Form
    {
        float procentDobanda = 0.08f;
        float gradIndatorare = 0.7f;
        List<Credit> listaCredite = new List<Credit>();

        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbPerioada.Text = vScrollBar1.Value.ToString();
        }

        private void tbPerioada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                vScrollBar1.Value = Convert.ToInt32(tbPerioada.Text);
            }
            catch
            {
                vScrollBar1.Value = 1;
            }
        }

        private void procentDobandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                procentDobanda = 0.03f;
            else
                procentDobanda = 0.08f;
            MessageBox.Show("Procent dobanda: " + procentDobanda);
        }

        private void gradIndatorareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false &&
                radioButton2.Checked == false)
                MessageBox.Show("Selectati starea civila!");
            else
            {
                if (radioButton1.Checked)
                    gradIndatorare = 0.5f;
                else
                if (radioButton2.Checked)
                    gradIndatorare = 0.7f;
                MessageBox.Show("Grad indatorare: " + gradIndatorare);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Introduceti suma!");
            else
                if (tbVenit.Text == "")
                errorProvider1.SetError(tbVenit, "Introduceti venitul!");
            else
                if (tbPerioada.Text == "")
                errorProvider1.SetError(tbPerioada, "Selectati perioada!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int suma = Convert.ToInt32(tbSuma.Text);
                    int venit = Convert.ToInt32(tbVenit.Text);
                    int perioada = Convert.ToInt32(tbPerioada.Text);
                    float creditMax = venit * perioada * 12 * gradIndatorare *
                        (1 + procentDobanda);
                    if (suma > creditMax)
                        MessageBox.Show("Suma solicitata este prea mare!");
                    else
                    {
                        float rata = suma / perioada /
                            12 * (1 + procentDobanda);
                        tbRata.Text = rata.ToString();

                        Credit credit = new Credit(suma, perioada, procentDobanda, rata);
                        listaCredite.Add(credit);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaCredite);
            frm.ShowDialog();
        }
    }
}