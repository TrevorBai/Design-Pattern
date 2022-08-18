using System;
using System.Windows.Forms;

namespace MVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test beat model
            //var beatModel = new BeatModel();
            //var controller = new BeatController(beatModel);
            //Application.Run(new Form2(beatModel, controller));

            // Test heart model
            var heartModel = new HeartModel();
            var controller = new HeartController(heartModel);
            var heartAdapter = new HeartAdapter(heartModel);
            Application.Run(new Form2(heartAdapter, controller));
        }
    }
}
