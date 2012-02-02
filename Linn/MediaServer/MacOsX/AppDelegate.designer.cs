// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;

namespace Linn.MediaServer
{
	[Register ("AppDelegate")]
	partial class AppDelegate
	{
		[Outlet]
		MonoMac.AppKit.NSMenu StatusMenu { get; set; }

		[Action ("OpenConfiguration:")]
		partial void OpenConfiguration (MonoMac.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (StatusMenu != null) {
				StatusMenu.Dispose ();
				StatusMenu = null;
			}
		}
	}
}
