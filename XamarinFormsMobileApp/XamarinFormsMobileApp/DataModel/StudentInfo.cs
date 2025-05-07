using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsMobileApp.DataModel
{
    //INotifyPropertyChanged : Sayfa yenilenmeden güncellenen itemler hemen gösterilir
    public class StudentInfo: INotifyPropertyChanged
    {
        public string name { get; set; }
        public string status { get; set; }
        public string ImageUrl { get; set; }
        public StudentInfo(string Name, string Status, string imageUrl)
        {
            name = Name;
            status = Status;
            ImageUrl = imageUrl;
        }
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}