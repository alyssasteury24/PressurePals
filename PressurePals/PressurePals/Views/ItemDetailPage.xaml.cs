using PressurePals.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PressurePals.Views
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