using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RegisterPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtUserPassword.Text == "1234")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Ошибка!", "Неверный логин пароль!","OK");
            }
        }
    }
}