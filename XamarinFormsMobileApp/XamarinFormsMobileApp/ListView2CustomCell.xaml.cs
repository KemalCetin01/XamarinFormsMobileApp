using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMobileApp.DataModel;

namespace XamarinFormsMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView2CustomCell : ContentPage
    {
        private const string BaseImageUrl = "https://wallpaperaccess.com/full/";

        ObservableCollection<StudentInfo> myList; // Gözlemlenebilir Liste
        public ListView2CustomCell()
        {
            InitializeComponent();
            myList = new ObservableCollection<StudentInfo>
            {
             new StudentInfo("John Doe","Enrolled",$"{BaseImageUrl}54669.jpg"),
             new StudentInfo("Jane Smith","Enrolled",$"{BaseImageUrl}54676.jpg"),
             new StudentInfo("Sam Brown","Rolled",$"{BaseImageUrl}54678.jpg"),
             new StudentInfo("Adnan Çelik","Enrolled",$"{BaseImageUrl}4681.jpg"),
             new StudentInfo("Selma Hünel","Enrolled",$"{BaseImageUrl}54686.jpg")
            };
            myListView2.ItemsSource = myList;
        }

        private async void myListView2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedStudent = e.SelectedItem as StudentInfo;

            await Navigation.PushAsync(new StudentInfoPage(selectedStudent));
        }


        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as ImageButton;
            var student = menuItem.BindingContext as StudentInfo;
            myList.Remove(student);
        }

        private void btnEdit_Clicked(object sender, EventArgs e)
        {

            var menuItem = sender as ImageButton;
            var student = menuItem.BindingContext as StudentInfo;

            var newName = "Updated Name"; 
            var newStatus = "Updated Status"; 
            student.Name = newName;
            student.Status = newStatus;

        }

        private void myListView2_Refreshing(object sender, EventArgs e)
        {
            myListView2.ItemsSource=null;
            myListView2.ItemsSource = myList;
            myListView2.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //myListView2.ItemsSource = myList.Where(s=>s.Name.StartsWith(e.NewTextValue);
            myListView2.ItemsSource = myList.Where(s=>s.Name.ToLower().Contains(e.NewTextValue.ToLower()));
        }
    }
}