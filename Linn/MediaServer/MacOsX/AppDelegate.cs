using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace Linn.MediaServer
{
	public partial class AppDelegate : NSApplicationDelegate, IView
	{
		public AppDelegate ()
		{
		}

		public override void FinishedLaunching (NSObject notification)
		{
			// load image for the status item
			string imageFile = NSBundle.MainBundle.PathForImageResource("SysTrayIcon.png");
			NSImage image = new NSImage(imageFile);
			
			// creating the status item with a length of -2 is equivalent to the call
			// [[NSStatusBar systemStatusBar] statusItemWithLength:NSSquareStatusItemLength]
			iStatusItem = NSStatusBar.SystemStatusBar.CreateStatusItem(-2);
			iStatusItem.HighlightMode = true;
			iStatusItem.Menu = StatusMenu;
			iStatusItem.Image = image;
			
			// create the main configuration window
			iWindow = new ConfigurationWindowController();
			iWindow.LoadWindow();

			// create the controller for the application
			iController = new Controller(this);
		}
		
		partial void OpenConfiguration(NSObject aSender)
		{
			iController.OpenConfigurationClicked();
		}

		void IView.SetUri(string aUri)
		{
			iWindow.SetUri(aUri);
		}
		
		void IView.Show()
		{
			NSApplication.SharedApplication.ActivateIgnoringOtherApps(true);
			iWindow.Window.MakeKeyAndOrderFront(this);
		}
		
		bool IView.IsVisible()
		{
			return iWindow.Window.IsVisible;
		}
		
		private NSStatusItem iStatusItem;
		private ConfigurationWindowController iWindow;
		private Controller iController;
	}
}

