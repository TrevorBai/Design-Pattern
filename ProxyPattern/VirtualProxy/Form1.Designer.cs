using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace VirtualProxy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new Container();
            this.lbl_1 = new Label();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.BuddhaStripMenuItem = new ToolStripMenuItem();
            this.SelectedStripMenuItem = new ToolStripMenuItem();
            this.NorthernStripMenuItem = new ToolStripMenuItem();
            this.ImaStripMenuItem = new ToolStripMenuItem();
            this.MCMXCStripMenuItem = new ToolStripMenuItem();
            this.KarmaStripMenuItem = new ToolStripMenuItem();
            this.button1 = new Button();
            this.label1 = new Label();
            this.pictureBox1 = new PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new Point(347, 254);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new Size(0, 13);
            this.lbl_1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
            this.BuddhaStripMenuItem,
            this.SelectedStripMenuItem,
            this.NorthernStripMenuItem,
            this.ImaStripMenuItem,
            this.MCMXCStripMenuItem,
            this.KarmaStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(238, 136);
            this.contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.ContextMenuStrip1_ItemClicked);
            // 
            // BuddhaStripMenuItem
            // 
            this.BuddhaStripMenuItem.Name = "BuddhaStripMenuItem";
            this.BuddhaStripMenuItem.Size = new Size(237, 22);
            this.BuddhaStripMenuItem.Text = "Buddha Bar";
            // 
            // SelectedStripMenuItem
            // 
            this.SelectedStripMenuItem.Name = "SelectedStripMenuItem";
            this.SelectedStripMenuItem.Size = new Size(237, 22);
            this.SelectedStripMenuItem.Text = "Selected Ambient Works. Vol. 2";
            // 
            // NorthernStripMenuItem
            // 
            this.NorthernStripMenuItem.Name = "NorthernStripMenuItem";
            this.NorthernStripMenuItem.Size = new Size(237, 22);
            this.NorthernStripMenuItem.Text = "Northern Exposure";
            // 
            // ImaStripMenuItem
            // 
            this.ImaStripMenuItem.Name = "ImaStripMenuItem";
            this.ImaStripMenuItem.Size = new Size(237, 22);
            this.ImaStripMenuItem.Text = "Ima";
            // 
            // MCMXCStripMenuItem
            // 
            this.MCMXCStripMenuItem.Name = "MCMXCStripMenuItem";
            this.MCMXCStripMenuItem.Size = new Size(237, 22);
            this.MCMXCStripMenuItem.Text = "MCMXC A.D.";
            // 
            // KarmaStripMenuItem
            // 
            this.KarmaStripMenuItem.Name = "KarmaStripMenuItem";
            this.KarmaStripMenuItem.Size = new Size(237, 22);
            this.KarmaStripMenuItem.Text = "Karma";
            // 
            // button1
            // 
            this.button1.ForeColor = SystemColors.ControlText;
            this.button1.Location = new Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(164, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Favorite Albums";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = SystemColors.ControlText;
            this.label1.Location = new Point(257, 241);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 25);
            this.label1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(247, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_1);
            this.ForeColor = SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem BuddhaStripMenuItem;
        private Button button1;
        private ToolStripMenuItem SelectedStripMenuItem;
        private ToolStripMenuItem NorthernStripMenuItem;
        private ToolStripMenuItem ImaStripMenuItem;
        private ToolStripMenuItem MCMXCStripMenuItem;
        private ToolStripMenuItem KarmaStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

