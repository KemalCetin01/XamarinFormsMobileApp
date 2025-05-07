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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            string uriImage = @"https://i0.wp.com/semihcelikol.com/wp-content/uploads/2017/10/XamarinLogo.png?fit=600%2C251&amp;ssl=1";
            myImage.Source = new UriImageSource
            {
                Uri = new Uri(uriImage),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(3,0,0,0),
            };

          myImageCat1.Source=ImageSource.FromResource("XamarinFormsMobileApp.Images.cat1.jpg");
          myImageDog1.Source=ImageSource.FromResource("XamarinFormsMobileApp.Images.dog1.jpg");
        }
    }
}