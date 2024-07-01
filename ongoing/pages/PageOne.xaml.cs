using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ongoing.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageOne : ContentPage
    {
        public PageOne()
        {
            InitializeComponent();
        }

        private void New_User_Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("helo", "you clicked!", "bye");
        }

        private async void Next_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pages.SecondPage());
        }

        private async void Pop_Button_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Text_Submitted(object sender, EventArgs e)
        {
            display_text.Text = "hello " + textbox.Text + "\nBye.";
        }

    }
}