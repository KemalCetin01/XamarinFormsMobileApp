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
    public partial class StudentInfoPage : ContentPage
    {
        public StudentInfoPage(StudentInfo selectedStudent)
        {
            InitializeComponent();
            lblName.Text = selectedStudent.Name;
        }
    }
}