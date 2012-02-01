using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace MediaServer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private FormSysTray iFormSysTray;

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            iFormSysTray = new FormSysTray();
            iFormSysTray.Show();
        }

        private void ApplicationExit(object sender, ExitEventArgs e)
        {
            if (iFormSysTray != null)
            {
                iFormSysTray.Close();
            }
        }
    }
}
