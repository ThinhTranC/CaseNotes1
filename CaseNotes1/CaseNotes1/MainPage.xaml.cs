using CaseNotes1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CaseNotes1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("CaseNotes1.Assets.logo.png", assembly);
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool canLogin = User.Login(emailEntry.Text, passwordEntry.Text);
            if (canLogin)
                Navigation.PushAsync(new HomePage());
            else DisplayAlert("Error", "Email/password was not right", "Ok");
        }
    }
}
