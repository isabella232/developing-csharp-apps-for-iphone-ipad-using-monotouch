using System;
using MonoTouch.UIKit;

namespace Example_TableAndCellStyles
{
	public class Application// : UIApplication
	{
		public static void Main (string[] args)
		{
			try
			{
				UIApplication.Main (args, null, "AppDelegate");
			}
			catch (Exception e)
			{
				Console.WriteLine (e.ToString ());
			}
		}
	}
}
