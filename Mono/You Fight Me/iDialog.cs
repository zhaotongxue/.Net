using System;

namespace Gtk
{
	public partial class iDialog : Gtk.Dialog
	{
		public iDialog ()
		{
			this.Build ();
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
        //protected void OnButtonCancelClicked(object sender,EventArgs e){
        //    this.Hide();
        //    MainWindow iMW = new MainWindow ();
        //    iMW.Show ();
        //}
		public void showMess(string str){
			label1.Text=str;
		}

	}

}

