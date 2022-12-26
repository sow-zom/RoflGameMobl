using RoflGame.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RoflGame.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}