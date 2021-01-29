using Inclass2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Inclass2.Views
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