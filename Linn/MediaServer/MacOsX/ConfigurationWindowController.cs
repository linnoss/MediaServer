using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace Linn.MediaServer
{
	public partial class ConfigurationWindowController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors
		
		// Called when created from unmanaged code
		public ConfigurationWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public ConfigurationWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public ConfigurationWindowController () : base ("ConfigurationWindow")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}
		
		#endregion
		
		//strongly typed window accessor
		public new ConfigurationWindow Window {
			get {
				return (ConfigurationWindow)base.Window;
			}
		}
		
		public void SetUri(string aUri)
		{
			WebView.MainFrameUrl = aUri;
		}
	}
}

