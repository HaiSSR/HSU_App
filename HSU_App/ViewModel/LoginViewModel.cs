using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HSU_App.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? usernameEntry;

        [ObservableProperty]
        private string? passwordEntry;

        public ICommand LoginCommand { get; }
        public ICommand ForgotPasswordCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            ForgotPasswordCommand = new RelayCommand(ForgotPassword);
        }

        private async void Login()
        {
            if (IsCredentialCorrect(usernameEntry, passwordEntry))
            {
                await Application.Current.MainPage.DisplayAlert("Đăng Nhập Thành Công", "", "OK");
                //await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Sai mật khẩu", "Mật khẩu của bạn vừa nhập chưa\r\nchính xác. Vui lòng thử lại.", "OK");
            }
        }

        private static bool IsCredentialCorrect(string username, string password)
        {
            //Authen logic 

            //hardcoded login
            return username == "asd" && password == "asd";
        }

        private async void ForgotPassword()
        {
            await Application.Current.MainPage.DisplayAlert("Not yet", "To be implemented", "OK");
            //await Application.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage());
        }
    }

}
