using System;
using System.Windows.Forms;
using log4net.Config;
using log4net;
using InputTracker.Tracking;

namespace InputTracker.Service
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            XmlConfigurator.Configure();

            var log = LogManager.GetLogger(typeof(Program));

            try
            {
                var keyboard = new LogKeyboardGlobalHook();
                var mouse = new LogMouseGlobalHook();

                Application.Run();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("exception while starting: {0}", ex.ToString());
            }
        }
    }
}