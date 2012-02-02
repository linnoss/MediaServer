using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Linn.MediaServer
{
    public partial class FormSysTray : Form
    {
        public FormSysTray(Controller aController)
        {
            InitializeComponent();

            iController = aController;
            iNotifyIcon.Icon = Linn.MediaServer.Properties.Resources.SysTrayIcon;
        }

        private void NotifyIconClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                System.Reflection.MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                mi.Invoke(iNotifyIcon, null);
            }
        }

        private void MenuItemQuitMediaServerClick(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MenuItemOpenMediaServerConfigurationClick(object sender, EventArgs e)
        {
            iController.OpenConfigurationClicked();
        }

        private Controller iController;
    }
}
