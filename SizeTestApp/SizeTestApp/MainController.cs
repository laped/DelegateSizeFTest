using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TestBinding;

namespace SizeTestApp
{
	public partial class MainController : UIViewController
	{
		public MainController () : base ()
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.White;

			View.Add (new UILabel (new RectangleF (10, 10, 300, 40)){ Text = "This is a delegate test" });

			DelegateTestLibrary testLib = new DelegateTestLibrary ();
			testLib.DataSource = new TestDataSource ();

			SizeF sizeFromObjC = testLib.ExecuteSizeTest ();
			Console.WriteLine ("Size received from Obj-C - width: " + sizeFromObjC.Width + " height: " + sizeFromObjC.Height);
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		class TestDataSource : MyTestDataSource
		{
			public override SizeF GetSizeForMyTest ()
			{
				Console.WriteLine ("GetSizeForMyTest");
				return new SizeF (80, 80);
			}
		}
	}
}

