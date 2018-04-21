using Acr.UserDialogs;
using SmartHotel2.Services;
using SmartHotel2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartHotel2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private LoginViewModel LoginViewModel { get; }
        public Login()
        {  
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           // LoginViewModel = new LoginViewModel { Username="ABC",Password="123" };
            this.BindingContext = LoginViewModel;
           // LoginViewModel.Username="Abcd";
        }
        private async void SignIn_Click(object sender, EventArgs e)
        {
          //  LoginViewModel.Username="ABC";
            DialogService a = new DialogService();
            a.ShowToast("aaaa",1000);
            if (UsernameEntry.Text == "ABC" && PasswordEntry.Text == "123")
            {            
                UserDialogs.Instance.ShowLoading();
                                            
                await Task.Delay(2000);
                UserDialogs.Instance.HideLoading();

                //    // Navigation.PushAsync(new MainView());
                //    //DisplayAlert("Thông báo","True","Đóng"); 
                //    // MainView mv = new MainView();
                //    //App.Current.MainPage = new NavigationPage(new SmartHotel2.Views.MainView());
                Application.Current.MainPage = new SmartHotel2.Views.MainView();
            }
        }
    }
}