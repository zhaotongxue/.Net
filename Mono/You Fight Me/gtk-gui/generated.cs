
// This file has been generated by the GUI designer. Do not modify.
namespace Stetic
{
	internal class Gui
	{
		private static bool initialized;

		internal static void Initialize (Gtk.Widget iconRenderer)
		{
			if ((Stetic.Gui.initialized == false)) {
				Stetic.Gui.initialized = true;
			}
		}
	}

	internal class ActionGroups
	{
		private static global::Gtk.ActionGroup group1;

		public static Gtk.ActionGroup GetActionGroup (System.Type type)
		{
			return Stetic.ActionGroups.GetActionGroup (type.FullName);
		}

		public static Gtk.ActionGroup GetActionGroup (string name)
		{
			if ((name == "Gtk.abc")) {
				if ((global::Stetic.ActionGroups.group1 == null)) {
					global::Stetic.ActionGroups.group1 = new Gtk.abc ();
				}
				return global::Stetic.ActionGroups.group1;
			} else {
				return null;
			}
		}
	}
}