using System.ComponentModel;
using Xamarin.Forms;

namespace NeomorphismSmartHomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await progressBar.AnimateProgress(.4f, 2500, Easing.SinIn);
        }
    }
}
