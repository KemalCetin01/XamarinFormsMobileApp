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
    public partial class EmployeeDetail : ContentPage
    {
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        EmployeeModel _employee;
        public EmployeeDetail(EmployeeModel employee)
        {
            InitializeComponent();

            Title = "Edit İnfo";
            _employee = employee;
            nameEntry.Text = employee.Name;
            addressEntry.Text = employee.Address;
            nameEntry.Focus();
        }
        private async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(addressEntry.Text))
            {
                await DisplayAlert("Error", "Please fill in all fields", "OK");
            }
            else if (_employee != null)
            {
                EditEmployee();
            }
            else
                AddNewEmployee();

        }
        async void AddNewEmployee()
        {
            await App.MyDatabase.CreateEmployeesAsync(new DataModel.EmployeeModel
            {
                Name = nameEntry.Text,
                Address = addressEntry.Text
            });
            await Navigation.PopAsync();
        }


        private async void EditEmployee()
        {
            _employee.Name = nameEntry.Text;
            _employee.Address = addressEntry.Text;
            await App.MyDatabase.UpdateEmployeesAsync(_employee);
            await Navigation.PopAsync();
        }
    }
}