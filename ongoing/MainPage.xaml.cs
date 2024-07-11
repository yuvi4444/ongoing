using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ongoing
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void next_page_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pages.PageOne());
        }

        async void Weather_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pages.WeatherPage());
        }
    }
}
