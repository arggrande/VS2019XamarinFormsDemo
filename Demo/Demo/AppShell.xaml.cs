using Demo.ViewModels;
using Demo.Views;
using System;
using Xamarin.Forms;

namespace Demo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

            Routing.RegisterRoute("about", typeof(AboutPage));

            InitializeComponent();

            BindingContext = new AppShellViewModel();
        }

        private void TheShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            // Used to capture when the app is in transition between pages.
            var current = e.Current;
            var target = e.Target;
            

            Console.WriteLine(current?.Location.ToString() ?? "No current location");
            Console.WriteLine(target?.Location.ToString() ?? "No target location");
        }

        private void TheShell_Navigated(object sender, ShellNavigatedEventArgs e)
        {
            // Used to capture when the app has transitioned to a new page.
            var current = e.Current;
            var previous = e.Previous;


            Console.WriteLine(current?.Location.ToString() ?? "No current location");
            Console.WriteLine(previous?.Location.ToString() ?? "No target location");
        }
    }
}
