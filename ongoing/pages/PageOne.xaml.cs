using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Existing_User_Button_Clicked(Object sender, EventArgs e)
        {
            DisplayAlert("helo", "you clicked!", "bye");
        }

    }
}