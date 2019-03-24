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
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://aka.ms/xf-shell-docs")));
        }

        public ICommand OpenWebCommand { get; }

    }
}