using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ongoing.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}

		private async void Back_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}

		private async void Home_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainPage ());
		}

		private async void Login_Clicked(object sender, EventArgs e)
		{
			if (email.Text == "yuvi@gmail.com" && password.Text == "123")
			{
				await Navigation.PushAsync (new MainPage());
			}
			else
			{
				DisplayAlert("failed", "try again", "back");
			}
		}

        private void New_User_Clicked(object sender, EventArgs e)
        {

        }

        private async void New_Page_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new PageOne());
        }
    }
}