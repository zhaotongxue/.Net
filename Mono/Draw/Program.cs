using System;
using Gtk;

namespace Draw
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			//MainWindow win = new MainWindow ();
			//win.Show ();
			InitDraw win = new InitDraw ();
			win.Show ();
			Application.Run ();
		}
	}
}
