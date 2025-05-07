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
    public partial class GridPageCodeBehind : ContentPage
    {
        public GridPageCodeBehind()
        {
            InitializeComponent();

            Grid grid = new Grid()
            {
                BackgroundColor = Color.Green,
                RowSpacing = 1,
                ColumnSpacing = 3,
                RowDefinitions = {
                new RowDefinition{ Height=new GridLength(1,GridUnitType.Auto)},
                new RowDefinition{ Height=new GridLength(75)},
                new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{ Height=new GridLength(150)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition  { Width=new GridLength (75) },
                    new ColumnDefinition (),
                    new ColumnDefinition  { Width=new GridLength (2,GridUnitType.Star) },
                }
            };
            Label lbl1 = new Label { Text = "Label 1", BackgroundColor = Color.White };
            Label lbl2 = new Label { Text = "Label 2", BackgroundColor = Color.White };
            Label lbl3 = new Label { Text = "Label 3", BackgroundColor = Color.White };
            Label lbl4 = new Label { Text = "Label 4", BackgroundColor = Color.White };
            Label lbl5 = new Label { Text = "Label 5", BackgroundColor = Color.White };
            Label lbl6 = new Label { Text = "Label 6", BackgroundColor = Color.White };
            Label lbl7 = new Label { Text = "Label 7", BackgroundColor = Color.White };
            Label lbl8 = new Label { Text = "Label 8", BackgroundColor = Color.White };

            grid.Children.Add(lbl1, 0, 0);
            grid.Children.Add(lbl2, 0, 1);
            grid.Children.Add(lbl3, 0, 2);
            grid.Children.Add(lbl4, 0, 3);
            grid.Children.Add(lbl5, 1, 0);
            grid.Children.Add(lbl6, 1, 1);
            grid.Children.Add(lbl7, 1, 2);
            grid.Children.Add(lbl8, 2, 0);

            Grid.SetRowSpan(lbl8, 3);
            Grid.SetColumnSpan(lbl4,3);
            Content=grid;

        }
    }
}