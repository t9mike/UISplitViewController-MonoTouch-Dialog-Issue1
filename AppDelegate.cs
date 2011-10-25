using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace SplitViewAndMTDialog1
{

    [Register ("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        UIWindow App_Window;
		UISplitViewController SV_Controller;
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {   
            // Create the main window and add the navigation controller as a subview
            App_Window = new UIWindow (UIScreen.MainScreen.Bounds);
		
			SV_Controller = new MySplitViewController();
			SV_Controller.Delegate = new UISplitViewControllerDelegate();
			SV_Controller.ViewControllers = new UIViewController[] { new MyNavigationController(), new DetailViewController("Hello World") };
			App_Window.RootViewController = SV_Controller;
			
			App_Window.MakeKeyAndVisible();
						
			return true;
        }		
    }
} 