using System;
using CoreFoundation;
using Foundation;
using UIKit;

namespace TompiTest
{
    public class SecondViewController : UIViewController
    {
        private UIButton _btn;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _btn = new UIButton();
            _btn.SetTitle("Gå til side 1", UIControlState.Normal);
            _btn.TitleLabel.Font = UIFont.FromName("Helvetica", 30);
            _btn.TitleLabel.TextAlignment = UITextAlignment.Center;
            _btn.Frame = View.Frame;
            _btn.TitleLabel.SizeToFit();
            _btn.TouchUpInside += (sender, e) =>
            {
                DismissViewController(true, null);
            };
            View.AddSubview(_btn);
        }

        public override void ViewWillLayoutSubviews()
        {
            _btn.Frame = View.Frame;
            base.ViewWillLayoutSubviews();
        }

        public override UIInterfaceOrientation PreferredInterfaceOrientationForPresentation()
        {
            return UIInterfaceOrientation.LandscapeLeft;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.LandscapeLeft;
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

    }
}
