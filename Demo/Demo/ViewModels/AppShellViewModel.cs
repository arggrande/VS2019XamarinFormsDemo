using Demo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class AppShellViewModel : BaseViewModel
    {
        public AppShellViewModel()
        {

            //Routing.RegisterRoute("about", typeof(AboutPage));
        }
        public ICommand NavigateCommand  => new Command<string>(NavigateTo);

        private static void NavigateTo(string uri)
        {
            try
            {
                //Shell.CurrentShell.GoToAsync(new ShellNavigationState(new Uri($"app://www.microsoft.com/{uri}")));
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("OH NO", ex.Message, "OH NO");
            }
            
            //(App.Current.MainPage as Xamarin.Forms.Shell).GoToAsync($"app://vs2019.demo.com/demo/{uri}");
        }
    }
}
