using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMobileApp.DataModel;

namespace XamarinFormsMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLLiteCRUD : ContentPage
    {
        public SQLLiteCRUD()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            try
            {

                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployeesAsync();
            }
            catch
            {

            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmployeeDetail());
        }

        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var employee = item.CommandParameter as EmployeeModel;
            await Navigation.PushAsync(new EmployeeDetail(employee));
        }

        private async void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var employee = item.CommandParameter as EmployeeModel;
            var result=await DisplayAlert("Delete", $"Are you sure you want to delete this employee? ({employee.Name})", "Yes", "No");

            if (result)
            {
                await App.MyDatabase.DeleteEmployeesAsync(employee);
                myCollectionView.ItemsSource = await App.MyDatabase.ReadEmployeesAsync();
                await DisplayAlert("Success", "Employee deleted successfully", "OK");
            }
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myCollectionView.ItemsSource=await App.MyDatabase.Search(e.NewTextValue);
        }
    }
}