using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click pe buton!");
        }

        private void Suma(object sender, EventArgs e)
        {
            try
            {
                int val1 = Convert.ToInt32(textBox1.Text);
                int val2 = Convert.ToInt32(textBox2.Text);
                int suma = val1 + val2;
                textBox3.Text = suma.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
