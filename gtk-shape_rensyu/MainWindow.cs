using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{

	private int count;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		this.count = 0;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		this.count += 1;
		this.label2.Text = this.count.ToString();
	}
}
