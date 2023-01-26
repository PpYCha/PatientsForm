using System;
using System.Threading;
using System.Windows.Forms;

namespace PatientsForm
{
    static class Program
    {
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "PatientsForm";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                //app is already running! Exiting the application
                MessageBox.Show("App is already runnning! Exiting the application...");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DashboardForm());
            Application.Run(new DashboardForm());
        }
    }
}
