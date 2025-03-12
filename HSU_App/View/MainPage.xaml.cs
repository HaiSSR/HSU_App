using Microsoft.Maui.Controls;
using System.ComponentModel;
using System.Windows.Input;

namespace HSU_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void OnTogglePasswordClicked(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;

            // Optionally, toggle the icon image
            /*
             * if (passwordEntry.IsPassword)
            {
                togglePasswordButton.Source = "eye_on";
            }
            else
            {
                togglePasswordButton.Source = "eye_off";
            }
            */
        }

    }
}

