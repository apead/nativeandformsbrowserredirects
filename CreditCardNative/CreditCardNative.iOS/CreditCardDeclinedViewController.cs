using System;
using CoreGraphics;
using UIKit;

namespace CreditCardNative.iOS
{
    public partial class CreditCardDeclinedViewController : UIViewController
    {
        public CreditCardDeclinedViewController() : base("CreditCardDeclinedViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var frame = new CGRect(10, 100, 300, 300);
            var imageView = new UIImageView(frame);
            imageView.Image = UIImage.FromBundle("declined");

            imageView.ContentMode = UIViewContentMode.ScaleAspectFit;
            
            View.AddSubview(imageView);

        }
    }
}