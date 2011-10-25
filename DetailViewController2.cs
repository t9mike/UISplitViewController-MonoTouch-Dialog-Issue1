using System;
using MonoTouch.UIKit;

namespace TabPlusNav1
{
	public class DetailViewController2 : UIViewController
	{		
		public DetailViewController2(string caption)
		{
			Add(new ToDoView(caption));
			Title = caption;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return true;
		}
	}
}

