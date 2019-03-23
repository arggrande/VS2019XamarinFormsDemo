using System;

using Demo.Models;

namespace Demo.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Movie Item { get; set; }
        public ItemDetailViewModel(Movie item = null)
        {
            Title = item?.Title;
            Item = item;
        }
    }
}
