
namespace Sem8PAW_1052
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deseneazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previzualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseneazaToolStripMenuItem,
            this.incarcaDateToolStripMenuItem,
            this.previzualizareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deseneazaToolStripMenuItem
            // 
            this.deseneazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dreptunghiToolStripMenuItem,
            this.elipsaToolStripMenuItem});
            this.deseneazaToolStripMenuItem.Name = "deseneazaToolStripMenuItem";
            this.deseneazaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.deseneazaToolStripMenuItem.Text = "Deseneaza";
            // 
            // dreptunghiToolStripMenuItem
            // 
            this.dreptunghiToolStripMenuItem.Name = "dreptunghiToolStripMenuItem";
            this.dreptunghiToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dreptunghiToolStripMenuItem.Text = "Dreptunghi";
            this.dreptunghiToolStripMenuItem.Click += new System.EventHandler(this.dreptunghiToolStripMenuItem_Click);
            // 
            // elipsaToolStripMenuItem
            // 
            this.elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            this.elipsaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.elipsaToolStripMenuItem.Text = "Elipsa";
            this.elipsaToolStripMenuItem.Click += new System.EventHandler(this.elipsaToolStripMenuItem_Click);
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.incarcaDateToolStripMenuItem.Text = "Incarca date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareToolStripMenuItem,
            this.schimbaFontToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 70);
            // 
            // schimbaCuloareToolStripMenuItem
            // 
            this.schimbaCuloareToolStripMenuItem.Name = "schimbaCuloareToolStripMenuItem";
            this.schimbaCuloareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schimbaCuloareToolStripMenuItem.Text = "Schimba culoare";
            this.schimbaCuloareToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareToolStripMenuItem_Click);
            // 
            // schimbaFontToolStripMenuItem
            // 
            this.schimbaFontToolStripMenuItem.Name = "schimbaFontToolStripMenuItem";
            this.schimbaFontToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schimbaFontToolStripMenuItem.Text = "Schimba font";
            this.schimbaFontToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 401);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // previzualizareToolStripMenuItem
            // 
            this.previzualizareToolStripMenuItem.Name = "previzualizareToolStripMenuItem";
            this.previzualizareToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.previzualizareToolStripMenuItem.Text = "Previzualizare";
            this.previzualizareToolStripMenuItem.Click += new System.EventHandler(this.previzualizareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 425);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deseneazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dreptunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem previzualizareToolStripMenuItem;
    }
}

