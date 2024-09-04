using AppsFlyerXamarinBinding;
using Foundation;
using UIKit;

namespace mauiiosloggingissue;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
		AppsFlyerLib.Shared.IsDebug = true;
		AppsFlyerLib.Shared.Start();

        return base.FinishedLaunching(application, launchOptions);
    }
}
