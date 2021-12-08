using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Foundation;
using UIKit;

namespace UITestDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            // Crashes.GenerateTestCrash();

#if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
#endif
            
            //AppCenter.Start("7c8a10af-023f-4e29-8285-ccaf669da49e", typeof(Analytics), typeof(Crashes));
            return base.FinishedLaunching(app, options);



        }

        
    }
}
