using System;
using System.Linq;
using Com.Muegel.MonoTouch;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using SplitViewAndMTDialog1;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace SplitViewAndMTDialog1
{
	public class Level1DialogViewController : DialogViewController
	{	
		// EVENTS I FIRE ///////////////////////////////////////////////
		
		// PUBLIC INNER TYPES //////////////////////////////////////////
		public class Level1Element : StyledStringElement
		{			
			public Level1Element(DialogViewController parent_dvc, string caption) : 
				base(caption)
			{
				Accessory = UITableViewCellAccessory.DisclosureIndicator;
				this.Tapped += delegate {
					var dlv2 = new Level2DialogViewController();
					parent_dvc.NavigationController.PushViewController(dlv2, true);
 ;
				};
			}			
		}
		
		// PRIVATE INNER TYPES /////////////////////////////////////////
		
		// PUBLIC FIELDS, PROPERTIES, AND CONSTANTS ////////////////////
		
		// PRIVATE FIELDS, PROPERTIES, AND CONSTANTS ///////////////////

		// CONSTRUCTORS ////////////////////////////////////////////////
		public Level1DialogViewController() : base(UITableViewStyle.Plain, null, false)
		{
			Root = new RootElement("Level 1")
			{
				new Section()
				{
					new Level1Element(this, "1"),
					new Level1Element(this, "2"),
				}
			};			
		}
		
		// PUBLIC METHODS //////////////////////////////////////////////
		
		// EVENTS I HANDLE /////////////////////////////////////////////
		
		// PRIVATE METHODS /////////////////////////////////////////////
		
	}
}

