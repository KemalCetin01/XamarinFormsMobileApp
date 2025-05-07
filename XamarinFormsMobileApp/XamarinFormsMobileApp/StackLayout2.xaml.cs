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
    public partial class StackLayout2 : ContentPage
    {
        public StackLayout2()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(20, 30, 0, 10),
                Children =
                {
                    new Button
                    {
                        Text = "Button 1",
                        BackgroundColor = Color.Red
                    },
                    new Button
                    {
                        Text = "Button 2",
                        BackgroundColor = Color.Yellow
                    },
                    new Button
                    {
                        Text = "Button 3",
                        BackgroundColor = Color.Red
                    },
                    new StackLayout
                    {
                        BackgroundColor = Color.Blue,
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            new Button
                            {
                                Text = "Button 4",
                                BackgroundColor = Color.Red
                            },
                            new Button
                            {
                                Text = "Button 5",
                                BackgroundColor = Color.Yellow
                            },
                            new Button
                            {
                                Text = "Button 6",
                                BackgroundColor = Color.Red
                            }
                        }
                    }
        }
            };
        }
    }
}