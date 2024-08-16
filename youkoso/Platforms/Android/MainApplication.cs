using Android.App;
using Android.Runtime;
using Android.Graphics;
using Android.Media;
using Android.Util;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;

namespace youkoso
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}