using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Graphics;
using Android.Media;
using Android.Util;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui.Views;

namespace youkoso
{
//    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[Activity(Theme = "@style/Maui.SplashTheme", ResizeableActivity = true, MainLauncher = true, LaunchMode = LaunchMode.SingleTask)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}