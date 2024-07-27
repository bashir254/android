using youkoso.Models;
using youkoso.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices.Sensors;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace youkoso.Views;

public partial class Katakana2Page : ContentPage
{

    public Katakana2Page()
	{
		InitializeComponent();
            BindingContext = new Katakana2ViewModel();
    }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
//App.Current.MainPage.DisplayAlert("", "videoUrl", "OK");
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var item = e.CurrentSelection[0] as Items;
string url = item.Url;
        // Stop the media element to reset it before setting a new source
        amedia.Stop();
        // Ensure media source is set before playing
        amedia.Source = new Uri(url);
        // Ensure the media is loaded before playing
        amedia.MediaOpened += (s, args) => 
        {
            amedia.Play();
        };
        // Reset selection to enable re-selection of the same item
        ((CollectionView)sender).SelectedItem = null;
}
}

}