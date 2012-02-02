using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace Linn.MediaServer
{
	public partial class AppDelegate : NSApplicationDelegate
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
		}
		
		partial void OpenConfiguration(NSObject aSender)
		{
			Console.WriteLine("Open configuration window");
		}

		private NSStatusItem iStatusItem;
	}
}

