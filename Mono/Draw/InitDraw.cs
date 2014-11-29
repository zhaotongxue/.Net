using System;
using System.IO;
using Gtk;
using Microsoft.CSharp;
using Gdk;
using Atk;
using Microsoft.Win32;
namespace Draw
{
	public partial class InitDraw : Gtk.Window
	{
		public InitDraw () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();

			Image myImage = new Gtk.Image ("/home/zhaotongxue/Desktop/a.jpg");
			DrawingArea thisArea = new DrawingArea ();
		}
	}
}

