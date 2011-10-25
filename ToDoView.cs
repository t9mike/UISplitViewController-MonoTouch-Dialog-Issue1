using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace SplitViewAndMTDialog1
{
	public class ToDoView : UIView
	{
		public ToDoView(string caption)
		{
			BackgroundColor = UIColor.LightGray;
			var label = new UILabel(new RectangleF(5, 5, 100, 20));
			label.Text = caption;
			AddSubview(label);
			
		}
	}
}

