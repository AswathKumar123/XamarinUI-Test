using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatformTest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            // TODO: If the iOS or Android app being tested is included in the solution 
            // then open the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            //
            // The iOS project should have the Xamarin.TestCloud.Agent NuGet package
            // installed. To start the Test Cloud Agent the following code should be
            // added to the FinishedLaunching method of the AppDelegate:
            //
#if ENABLE_TEST_CLOUD
              Xamarin.Calabash.Start();
#endif
            if (platform == Platform.iOS)
            {
                return ConfigureApp
                    .iOS
                    // TODO: Update this path to point to your Android app and uncomment the
                    // code if the app is not included in the solution.
                    //.ApkFile (@"/Users/aswathkumarkulasekarapandian/Desktop/Appium Learn Mobile Automation Testing_v5332.0_apkpure.com.apk")
                    .DeviceIdentifier("32D0FA54-CD0E-4C1D-861D-F3916560C5A7")
                    .InstalledApp("com.companyname.eaxamarin")
                    .StartApp();
            }
else
            return ConfigureApp
                    .Android
                    // TODO: Update this path to point to your iOS app and uncomment the
                    // code if the app is not included in the solution.
                    //.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/XamarinForms.iOS.app")
                    .InstalledApp("com.companyname.eaxamarin")
                    .StartApp();
            }
        }
    }
    