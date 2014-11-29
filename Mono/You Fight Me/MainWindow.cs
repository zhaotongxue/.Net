using System;
using Gtk;
using System.Text;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		iDialog i = new iDialog ();
		i.showMess (MyName.Text + "\t说：\n" + Mess.Text);
		i.Show ();
	}
}
