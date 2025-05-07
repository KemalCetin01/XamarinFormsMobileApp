using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMobileApp.DataModel;

namespace XamarinFormsMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestAndEditor : ContentPage
    {
        List<CompanyModel> companyList = new List<CompanyModel>();
        public TestAndEditor()
        {
            InitializeComponent();
            CeopPicker.Items.Add("Elon Musk");
            CeopPicker.Items.Add("Bill Gates");
            CeopPicker.Items.Add("Steve Jobs");

            companyList.Add(new CompanyModel
            {
                Name = "Apple",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Apple_logo_black.svg/1200px-Apple_logo_black.svg.png",
                Description = "Apple Inc. is an American multinational technology company headquartered in Cupertino, California, that designs, develops, and sells consumer electronics, computer software, and online services."
            });
            companyList.Add(new CompanyModel
            {
                Name = "Microsoft",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Microsoft_logo.svg/1200px-Microsoft_logo.svg.png",
                Description = "Microsoft Corporation is an American multinational technology corporation that produces computer software, consumer electronics, personal computers, and related services."
            });

            companyList.Add(new CompanyModel
            {
                Name = "Tesla",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Tesla_Motors.svg/640px-Tesla_Motors.svg.png",
                Description = "Google LLC is an American multinational conglomerate specializing in various services and products, including online advertising technologies, search engine, cloud computing, software, and hardware."
            });

            CompanyPicker.ItemsSource = companyList;
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            NotifyDetail notifyDetail = new NotifyDetail()
            {
                Name = name.Text,
                Course = course.Text,
                EmailAdd = email.Text,
                MobileNumber = contract.Text,
                Remarks = remarks.Text,
            };

            // Access List statically
            NotifyDetail.List.Add(notifyDetail);
            await Navigation.PopAsync();
        }

        private void CompanyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCompany = CompanyPicker.SelectedIndex;
            Logo.Source=companyList[selectedCompany].Logo;
            lblDescription.Text = companyList[selectedCompany].Description;
        }
    }
}