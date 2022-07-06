using System;
using System.Windows.Forms;

namespace VirtualProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1, 0, button1.Height);
        }

        private void ContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var curItem = e.ClickedItem.Text;
            switch (curItem)
            {
                case "MCMXC A.D.":
                    label1.Text = "Loading album cover, please wait...";

                    // Synchronously
                    try
                    {                
                        pictureBox1.Load("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");
                        pictureBox1.Width = 800;
                        pictureBox1.Height = 600;
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException(ex.Message);
                    }

                    label1.Text = "";
                    return;
                default:
                    pictureBox1.Image = null;
                    pictureBox1.Width = 0;
                    pictureBox1.Height = 0;
                    label1.Text = "Not available...";
                    return;
            }


        }

        
    }
}
