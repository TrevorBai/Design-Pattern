using System.Windows.Forms;

namespace MVC
{
    // Form1 is a display view model
    // Form1 is observers which observe form2
    public partial class Form1 : Form, IBeatObserver, IBPMObserver
    {
        private readonly IBeatModel _beatModel;
        private readonly IController _controller;

        //IBeatModel beatModel, IController controller
        public Form1(IBeatModel beatModel, IController controller)
        {
            _beatModel = beatModel;
            _controller = controller;
            _beatModel.RegisterObserver((IBeatObserver)this);
            _beatModel.RegisterObserver((IBPMObserver)this);

            InitializeComponent();
            Text = "View";
            UpdateBPM();
            UpdateBeat();
        }

        public void UpdateBPM()
        {
            var bpm = _beatModel.GetBPM();
            if (bpm == 0)
            {
                label1.Text = "offline";
                return;
            }
            label1.Text = "Current BPM: " + bpm;
            // Update the beat progress bar as well
            UpdateBeat();
        }

        public void UpdateBeat()
        {
            var bpm = _beatModel.GetBPM();

            // Clamp bpm
            if (bpm < 0)
            {
                bpm = 0;
                progressBar1.Value = bpm;
            } else if (bpm > 120)
            {
                bpm = 120;
                progressBar1.Value = 100;
            } else
            {
                var ratio = bpm / 120d;
                var increment = (int)(100 * ratio);
                // Avoid checking cross thread calls
                CheckForIllegalCrossThreadCalls = false;
                progressBar1.Value = increment;
            }
        }
    }
}
