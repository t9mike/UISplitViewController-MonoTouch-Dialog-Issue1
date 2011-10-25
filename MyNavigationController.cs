using System;
using Com.Muegel.MonoTouch;
using MonoTouch.Dialog;
using MonoTouch.UIKit;

namespace SplitViewAndMTDialog1
{
	public class MyNavigationController : UINavigationController
	{
		public MyNavigationController ()
		{
			PushViewController(new Level1DialogViewController(), false);
		}
				
		public override bool ShouldAutorotateToInterfaceOrientation(MonoTouch.UIKit.UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}

