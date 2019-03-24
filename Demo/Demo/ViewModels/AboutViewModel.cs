using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Demo.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            Test = "Test";
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://aka.ms/xf-shell-docs")));
        }

        public ICommand OpenWebCommand { get; }

        public string Test { get; set; }
    }
}