using Foundation;
using System;
using UIKit;

namespace CourseiOS
{
    public partial class ViewController : UIViewController
    {
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            lblTitle.Text = "Hello World";

            btnPrev.TouchUpInside += BtnPrev_TouchUpInside;
            btnNext.TouchUpInside += BtnNext_TouchUpInside;


		}

        private void BtnNext_TouchUpInside(object sender, EventArgs e) {

            lblTitle.Text = "Next Clicked";
            txtDescription.Text = "This is description for Next";
            imgView.Image = UIImage.FromBundle("p1.jpeg");


        }

        private void BtnPrev_TouchUpInside(object sender, EventArgs e) {

            lblTitle.Text = "Previous Clicked";
            txtDescription.Text = "This is description for Previous";
            imgView.Image = UIImage.FromBundle("p2.jpg");


        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
    }
}