namespace MVC
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_setBPM = new System.Windows.Forms.Button();
            this.BPMNumber = new System.Windows.Forms.TextBox();
            this.btn_decBPM = new System.Windows.Forms.Button();
            this.btn_incBPM = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DJ = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter BPM: ";
            // 
            // btn_setBPM
            // 
            this.btn_setBPM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_setBPM.Location = new System.Drawing.Point(12, 74);
            this.btn_setBPM.Name = "btn_setBPM";
            this.btn_setBPM.Size = new System.Drawing.Size(146, 23);
            this.btn_setBPM.TabIndex = 3;
            this.btn_setBPM.Text = "Set";
            this.btn_setBPM.UseVisualStyleBackColor = false;
            this.btn_setBPM.Click += new System.EventHandler(this.btn_setBPM_Click);
            // 
            // BPMNumber
            // 
            this.BPMNumber.Location = new System.Drawing.Point(103, 44);
            this.BPMNumber.Name = "BPMNumber";
            this.BPMNumber.Size = new System.Drawing.Size(55, 20);
            this.BPMNumber.TabIndex = 4;
            // 
            // btn_decBPM
            // 
            this.btn_decBPM.Location = new System.Drawing.Point(12, 103);
            this.btn_decBPM.Name = "btn_decBPM";
            this.btn_decBPM.Size = new System.Drawing.Size(64, 21);
            this.btn_decBPM.TabIndex = 5;
            this.btn_decBPM.Text = "<<";
            this.btn_decBPM.UseVisualStyleBackColor = true;
            this.btn_decBPM.Click += new System.EventHandler(this.btn_decBPM_Click);
            // 
            // btn_incBPM
            // 
            this.btn_incBPM.Location = new System.Drawing.Point(82, 103);
            this.btn_incBPM.Name = "btn_incBPM";
            this.btn_incBPM.Size = new System.Drawing.Size(76, 21);
            this.btn_incBPM.TabIndex = 6;
            this.btn_incBPM.Text = ">>";
            this.btn_incBPM.UseVisualStyleBackColor = true;
            this.btn_incBPM.Click += new System.EventHandler(this.btn_incBPM_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(42, 139);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 7;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            this.contextMenuStrip1.Text = "DJ Control";
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // btn_DJ
            // 
            this.btn_DJ.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DJ.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_DJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DJ.Location = new System.Drawing.Point(12, 12);
            this.btn_DJ.Name = "btn_DJ";
            this.btn_DJ.Size = new System.Drawing.Size(121, 26);
            this.btn_DJ.TabIndex = 8;
            this.btn_DJ.Text = "DJ Control";
            this.btn_DJ.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_DJ.UseVisualStyleBackColor = false;
            this.btn_DJ.Click += new System.EventHandler(this.btn_DJ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(268, 200);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btn_DJ);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_incBPM);
            this.Controls.Add(this.btn_decBPM);
            this.Controls.Add(this.BPMNumber);
            this.Controls.Add(this.btn_setBPM);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Control";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_setBPM;
        private System.Windows.Forms.TextBox BPMNumber;
        private System.Windows.Forms.Button btn_decBPM;
        private System.Windows.Forms.Button btn_incBPM;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btn_DJ;
    }
}

