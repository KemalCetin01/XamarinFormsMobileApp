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
    public partial class CarouselPage1 : CarouselPage
    {
        private const string BaseImageUrl = "https://wallpaperaccess.com/full/";
        ObservableCollection<StudentInfo> myList;
        public CarouselPage1()
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
            ItemsSource = myList;
        }
    }
}