using System;
using Foundation;
using Plugin.DeviceOrientation;
using UIKit;

namespace TompiTest
{
    public class FirstViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            //UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
            base.ViewDidLoad();

            var _btn = new UIButton();
            _btn.SetTitle("Gå til side 2", UIControlState.Normal);
            _btn.TitleLabel.Font = UIFont.FromName("Helvetica", 30);
            _btn.TitleLabel.TextAlignment = UITextAlignment.Center;
            _btn.Frame = View.Frame;
            _btn.TitleLabel.SizeToFit();
            _btn.TouchUpInside += (sender, e) => 
            {
                PresentViewController(new SecondViewController(), false, null);
            };
            View.AddSubview(_btn);
        }

        public override UIInterfaceOrientation PreferredInterfaceOrientationForPresentation()
        {
            return UIInterfaceOrientation.Portrait;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.Portrait;
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

    }
}
