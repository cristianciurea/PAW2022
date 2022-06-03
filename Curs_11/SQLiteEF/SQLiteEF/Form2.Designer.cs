
namespace SQLiteEF
{
    partial class Form2
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
            this.userControl11 = new SQLiteEF.UserControl1();
            this.controlDataNastere1 = new WindowsFormsControlLibrary1.ControlDataNastere();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(129, 45);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(353, 82);
            this.userControl11.TabIndex = 0;
            // 
            // controlDataNastere1
            // 
            this.controlDataNastere1.Location = new System.Drawing.Point(129, 149);
            this.controlDataNastere1.Name = "controlDataNastere1";
            this.controlDataNastere1.Size = new System.Drawing.Size(533, 94);
            this.controlDataNastere1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlDataNastere1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private WindowsFormsControlLibrary1.ControlDataNastere controlDataNastere1;
    }
}