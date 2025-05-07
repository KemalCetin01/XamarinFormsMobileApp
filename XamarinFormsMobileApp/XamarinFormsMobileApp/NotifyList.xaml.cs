using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMobileApp.DataModel;
using XamarinFormsMobileApp.Enums;

namespace XamarinFormsMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifyList : ContentPage
    {
        private const string BaseImageUrl = "https://wallpaperaccess.com/full/";

        ObservableCollection<NotifyDetail> myList=new ObservableCollection<NotifyDetail>(); // Gözlemlenebilir Liste
        public NotifyList()
        {
            InitializeComponent();
            var detail1 = new NotifyDetail(
                $"{BaseImageUrl}54669.jpg",
                 "Ali Veli",
                 "Math",
                 "ali@example.com",
                 "5551234567",
                 "sifre123",
                 "Başarılı öğrenci",
                 "Aktif",
                 MessageTypeEnum.WhatsApp,
                 NotifyTypeEnum.automatic);

            var detail2 = new NotifyDetail(
                $"{BaseImageUrl}54676.jpg",
                "Ayşe Yılmaz",
                "Physics",
                "ayse@example.com",
                "5559876543",
                "pass456",
                "Sınavdan yüksek not aldı",
                "Pasif",
                MessageTypeEnum.Teams,
                NotifyTypeEnum.manual);
            myList.Add(detail1);
            myList.Add(detail2);
            myListView2.ItemsSource = myList;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TestAndEditor());
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {

        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {

        }

        private void myListView2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void myListView2_Refreshing(object sender, EventArgs e)
        {

        }
    }
}