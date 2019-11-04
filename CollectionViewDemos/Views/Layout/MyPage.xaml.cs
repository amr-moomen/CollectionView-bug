using CollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace CollectionViewDemos.Views
{
    public partial class myPage : ContentPage
    {
        public myPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}
