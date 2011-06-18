using System;
using MonoMac.AppKit;
using MonoMac.Foundation;
using Eto.Forms;

namespace Notedown
{
	public partial class AppDelegate : Eto.Platform.Mac.AppDelegate
	{
        // show the main window when the application button is clicked
		public override bool ApplicationShouldHandleReopen(NSApplication sender, bool hasVisibleWindows)
		{
			if (!hasVisibleWindows)
            {
				if (Application.Instance.MainForm != null) Application.Instance.MainForm.Show();
			}
			return true;
		}
        
        // close the application when the main window is closed
        public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
        {
            return true;
        }
        
        // save all notes when the application is closed
        public override void WillTerminate (NSNotification notification)
        {
            ((MainForm)Application.Instance.MainForm).Notes.Save();
        }
	}
}

