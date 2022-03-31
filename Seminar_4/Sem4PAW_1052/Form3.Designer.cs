
namespace Sem3PAW_1052
{
    partial class Form3
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGbp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbXau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(237, 56);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 22);
            this.tbData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data curs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "EUR:";
            // 
            // tbEur
            // 
            this.tbEur.Location = new System.Drawing.Point(237, 106);
            this.tbEur.Name = "tbEur";
            this.tbEur.Size = new System.Drawing.Size(100, 22);
            this.tbEur.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "USD:";
            // 
            // tbUsd
            // 
            this.tbUsd.Location = new System.Drawing.Point(237, 160);
            this.tbUsd.Name = "tbUsd";
            this.tbUsd.Size = new System.Drawing.Size(100, 22);
            this.tbUsd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "GBP:";
            // 
            // tbGbp
            // 
            this.tbGbp.Location = new System.Drawing.Point(237, 215);
            this.tbGbp.Name = "tbGbp";
            this.tbGbp.Size = new System.Drawing.Size(100, 22);
            this.tbGbp.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "XAU:";
            // 
            // tbXau
            // 
            this.tbXau.Location = new System.Drawing.Point(237, 267);
            this.tbXau.Name = "tbXau";
            this.tbXau.Size = new System.Drawing.Size(100, 22);
            this.tbXau.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Parsare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbXau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGbp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbData);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGbp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbXau;
        private System.Windows.Forms.Button button1;
    }
}