using System;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace Com.Muegel.MonoTouch
{
	/// <summary>
	/// Custom tab bar controller. Call Add() any number of times and then call Done().
	/// </summary>
	public class MuegelUITabBarController : UITabBarController
	{
		// EVENTS I FIRE ///////////////////////////////////////////////
		
		// PUBLIC INNER TYPES //////////////////////////////////////////
		
		// PRIVATE INNER TYPES /////////////////////////////////////////
		
		// PUBLIC FIELDS, PROPERTIES, AND CONSTANTS ////////////////////
		public List<UITabBarItem> Items { get; private set; }
		
		// PRIVATE FIELDS, PROPERTIES, AND CONSTANTS ///////////////////
		private List<UIViewController> Controllers = new List<UIViewController>();
		private bool Need_To_Call_Done = false;
		
		// CONSTRUCTORS ////////////////////////////////////////////////
		public MuegelUITabBarController ()
		{
			Items = new List<UITabBarItem>();
			
			// Disable editing of tabs/order
			CustomizableViewControllers = new UIViewController[]{};
		}
		
		// PUBLIC METHODS //////////////////////////////////////////////
		
		/// <summary>
		/// Add a standard system icon. The label for a system icon cannot be
		/// changed, and thus there is no "string label" argument.
		/// </summary>
		public void Add(UITabBarSystemItem system_icon, UIViewController view_controller)
		{
			Add(new UITabBarItem(system_icon, 0), view_controller);
		}

		/// <summary>
		/// Add a custom icon.
		/// </summary>
		public void Add(string label, UIImage icon_image, UIViewController view_controller)
		{
			Add(new UITabBarItem(label, icon_image, 0), view_controller);
		}

		public void Done()
		{
			this.ViewControllers = Controllers.ToArray();
			Need_To_Call_Done = false;
		}
		
		// EVENTS I HANDLE /////////////////////////////////////////////
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			if (Need_To_Call_Done)
				throw new Exception("you must call Done() after using one of the Add() routines");
		}
		
		// PRIVATE METHODS /////////////////////////////////////////////
		private void Add(UITabBarItem item, UIViewController view_controller)
		{
			Need_To_Call_Done = true;
			item.Tag = Items.Count + 1;
			view_controller.TabBarItem = item;
			Items.Add(item);
			Controllers.Add(view_controller);
		}
						
	}
}

