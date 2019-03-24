using System;
using Xamarin.Forms;

namespace Demo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void TheShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            // Used to capture when the app is in transition between pages.
            var current = e.Current;
            var target = e.Target;


            Console.WriteLine($"Current Location: {current?.Location.ToString()}");
            Console.WriteLine($"Target Location: {target?.Location.ToString()}");
        }

        private void TheShell_Navigated(object sender, ShellNavigatedEventArgs e)
        {
            // Used to capture when the app has transitioned to a new page.
            var current = e.Current;
            var previous = e.Previous;


            Console.WriteLine($"Current Location: {current?.Location.ToString()}");
            Console.WriteLine($"Previous Location: {previous?.Location.ToString()}");
        }
    }
}
