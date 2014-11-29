using System;
using Gtk;
using System.Drawing;
using System.Timers;
using System.Text;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Timer iTimer = new Timer ();
		iTimer.Enabled = true;
		iTimer.Interval =1000;
		//Add (iTimer);

	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
