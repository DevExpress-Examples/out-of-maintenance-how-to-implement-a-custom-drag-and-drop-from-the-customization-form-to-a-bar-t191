using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace T191208
{
	internal sealed class Program
	{

		private Program()
		{
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			SkinManager.EnableFormSkins();
			UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
			Application.Run(new Form1());
		}
	}
}
