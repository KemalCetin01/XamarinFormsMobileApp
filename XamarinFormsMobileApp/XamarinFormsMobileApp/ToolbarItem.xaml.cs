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
    public partial class ToolbarItem : ContentPage
    {
        public ToolbarItem()
        {
            InitializeComponent();
        }


        private void Add_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Add", "Add button clicked","accept", "OK",FlowDirection.MatchParent);//????geliştirilecek
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Add", "Profile button clicked", "OK");

        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Add", "Logout button clicked", "OK");

        }
    }
}