using Xamarin.Forms;
using Demo.Models;
using Demo.ViewModels;

namespace Demo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Movie
            {

            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}