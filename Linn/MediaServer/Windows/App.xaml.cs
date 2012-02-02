using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Linn.MediaServer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, IView
    {
        private FormSysTray iFormSysTray;
        private ConfigurationWindow iWindow;
        private Controller iController;

        private void ApplicationStartup(object sender, StartupEventArgs e)
        {
            // create the configuration window
            iWindow = new ConfigurationWindow();
            iWindow.Closing += EventWindowClosing;

            // create the controller for the app
            iController = new Controller(this);

            // create and show the sys tray icon
            iFormSysTray = new FormSysTray(iController);
            iFormSysTray.Show();
        }

        private void ApplicationExit(object sender, ExitEventArgs e)
        {
            if (iFormSysTray != null)
            {
                iFormSysTray.Close();
            }

            if (iWindow != null)
            {
                iWindow.Close();
            }
        }

        private void EventWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // prevent the configuration window from being closed - just hide it
            e.Cancel = true;
            iWindow.Hide();
        }

        void IView.SetUri(string aUri)
        {
            iWindow.WebBrowser.Navigate(aUri);
        }

        void IView.Show()
        {
            iWindow.Show();
            iWindow.Focus();
            iWindow.WindowState = WindowState.Normal;
        }

        bool IView.IsVisible()
        {
            return iWindow.IsVisible;
        }
    }
}
