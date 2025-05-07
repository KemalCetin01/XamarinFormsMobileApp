using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpMain : ContentPage
    {
        public PopUpMain()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is a pop-up alert", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool result =await DisplayAlert("Question", "Would you like Play?", "Yes","No");
            Button2.Text=result.ToString();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
        string action= await DisplayActionSheet("Action Sheet : Send To?","Cancel",null,"Copy Link", "Email","Twitter","Facebook");
            Button3.Text = action;
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Queations","What is yopur age?",maxLength:2,keyboard:Keyboard.Numeric);
            Button4.Text = result;
        }
    }
}