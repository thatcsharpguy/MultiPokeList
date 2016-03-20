using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace MultiPokeListView.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

			UINavigationBar.Appearance.BarTintColor = UIColor.Red;
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
            {
                TextColor = UIColor.White
            });

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

