﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem6PAW_1052
{
    public partial class Form2 : Form
    {
        public Form2(List<Produs> lista)
        {
            InitializeComponent();
            foreach (Produs p in lista)
                textBox1.Text += p.ToString() + Environment.NewLine;
        }
    }
}
