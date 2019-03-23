using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Demo.Models;

namespace Demo.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Movie Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Movie
            {
                

            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}