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
    public partial class Form2 : Form
    {
        public Form2(List<Credit> lista)
        {
            InitializeComponent();
            foreach (Credit c in lista)
                textBox1.Text += c.ToString() + Environment.NewLine;
        }
    }
}
