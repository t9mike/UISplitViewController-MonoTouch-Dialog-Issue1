using System;
using MonoTouch.UIKit;

namespace SplitViewAndMTDialog1
{
	public class MySplitViewController : UISplitViewController
	{
		public MySplitViewController ()
		{
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}

