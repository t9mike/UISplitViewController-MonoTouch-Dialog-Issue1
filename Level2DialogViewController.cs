using System;
using System.Linq;
using Com.Muegel.MonoTouch;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace SplitViewAndMTDialog1
{
	public class Level2DialogViewController : DialogViewController
	{	
		// EVENTS I FIRE ///////////////////////////////////////////////
		
		// PUBLIC INNER TYPES //////////////////////////////////////////
		
		// PRIVATE INNER TYPES /////////////////////////////////////////
		
		// PUBLIC FIELDS, PROPERTIES, AND CONSTANTS ////////////////////
		
		// PRIVATE FIELDS, PROPERTIES, AND CONSTANTS ///////////////////

		// CONSTRUCTORS ////////////////////////////////////////////////
		public Level2DialogViewController() : base(UITableViewStyle.Plain, null, true)
		{
			Root = new RootElement("Level 2")
			{
				new Section()
				{
					new StyledStringElement("A"),
					new StyledStringElement("B")
				}
			};						
		}
		
		// PUBLIC METHODS //////////////////////////////////////////////
		
		// EVENTS I HANDLE /////////////////////////////////////////////
		
		// PRIVATE METHODS /////////////////////////////////////////////

	}
}