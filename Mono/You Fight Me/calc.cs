using System;

namespace Gtk
{
	public partial class calc : Gtk.Window
	{
		public calc () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

