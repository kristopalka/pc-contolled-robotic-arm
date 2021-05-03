using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S = RoboticArm.Properties.Settings;

namespace RoboticArm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            if (!Arduino.Conect(S.Default.DefaultPort))
            {
                Settings settings_form = new Settings();
                settings_form.ShowDialog();
            }
            Application.Run(new Window());



            RoboticArm.Properties.Settings.Default.Save();
            Arduino.Disconnect();
        }


    }
}
