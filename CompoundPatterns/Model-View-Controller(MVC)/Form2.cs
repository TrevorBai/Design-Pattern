using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    // Form2 is our main view console
    // Form2 is observables which can be observed
    public partial class Form2 : Form
    {
        private readonly IBeatModel _beatModel;
        private readonly IController _controller;
        private Form _displayForm;

        public Form2(IBeatModel beatModel, IController controller)
        {
            _beatModel = beatModel;
            _controller = controller;
            InitializeComponent();
        }

        // Show button to delecate display feature to Form1
        private void btn_show_Click(object sender, EventArgs e)
        {
            //if (_displayForm != null)
            //{
            //    _displayForm.Show();
            //    return;
            //}
            GenerateDisplayForm();
            _displayForm.Show();
            BPMNumber.Text = _beatModel.GetBPM().ToString();
        }

        private void GenerateDisplayForm()
        {
            _displayForm = new Form1(_beatModel, _controller);
        }

        // DJ Control button
        private void btn_DJ_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btn_DJ, 0, btn_DJ.Height);
        }

        // Set bpm button
        private void btn_setBPM_Click(object sender, EventArgs e)
        {
            var bpm = int.Parse(BPMNumber.Text);
            _controller.SetBPM(bpm);
        }

        // Increase bpm button
        private void btn_incBPM_Click(object sender, EventArgs e)
        {
            int bpm;
            if (string.IsNullOrEmpty(BPMNumber.Text))
            {
                bpm = 120;
            }
            else
            {
                bpm = int.Parse(BPMNumber.Text);
            }
            bpm++;
            BPMNumber.Text = bpm.ToString();
            _controller.IncreaseBPM();
        }

        // Decrease bmp button
        private void btn_decBPM_Click(object sender, EventArgs e)
        {
            int bpm;
            if (string.IsNullOrEmpty(BPMNumber.Text))
            {
                bpm = 120;
            } else
            {
                bpm = int.Parse(BPMNumber.Text);
            }
            bpm--;
            BPMNumber.Text = bpm.ToString();
            _controller.DecreaseBPM();
        }

        // Main application control
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var curItem = e.ClickedItem.Text;
            switch (curItem)
            {
                case "Start":
                    // Disable start item
                    contextMenuStrip1.Items[0].Enabled = false;

                    // Let the heart model run in a new thread
                    // Since it has an infinite loop to run,
                    // Running it in a separate thread would not 
                    // block the main thread (UI thread).
                    Task.Run(() => _beatModel.On());
                    // Enable stop item
                    contextMenuStrip1.Items[1].Enabled = true;
                    return;
                case "Stop":
                    // Disable stop item
                    contextMenuStrip1.Items[1].Enabled = false;
                    if (_displayForm != null) _displayForm.Close();
                    // Enable start item
                    contextMenuStrip1.Items[0].Enabled = true;
                    return;
                case "Quit":
                    Close();
                    return;
            }
        }
    }
}
