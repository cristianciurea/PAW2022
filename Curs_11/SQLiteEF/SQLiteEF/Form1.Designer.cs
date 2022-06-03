namespace SQLiteEF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tb_denumire = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.tb_prenume = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userControl11 = new SQLiteEF.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adauga curs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_denumire
            // 
            this.tb_denumire.Location = new System.Drawing.Point(165, 68);
            this.tb_denumire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_denumire.Name = "tb_denumire";
            this.tb_denumire.Size = new System.Drawing.Size(148, 26);
            this.tb_denumire.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 205);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Afisare cursuri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(165, 205);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 144);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Denumire curs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID student:";
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(752, 68);
            this.tb_nume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(148, 26);
            this.tb_nume.TabIndex = 8;
            // 
            // tb_prenume
            // 
            this.tb_prenume.Location = new System.Drawing.Point(752, 129);
            this.tb_prenume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_prenume.Name = "tb_prenume";
            this.tb_prenume.Size = new System.Drawing.Size(148, 26);
            this.tb_prenume.TabIndex = 9;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(752, 191);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(148, 26);
            this.tb_id.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(946, 68);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Adauga student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(752, 252);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 144);
            this.listBox2.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(946, 252);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "Afisare studenti";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(165, 132);
            this.tb_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(148, 26);
            this.tb_url.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "URL curs:";
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(81, 406);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(353, 82);
            this.userControl11.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 537);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_prenume);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_denumire);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_denumire;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.TextBox tb_prenume;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label5;
        private UserControl1 userControl11;
    }
}

