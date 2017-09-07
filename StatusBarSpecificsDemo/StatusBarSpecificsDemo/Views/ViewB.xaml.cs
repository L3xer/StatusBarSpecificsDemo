using Xamarin.Forms;

namespace StatusBarSpecificsDemo.Views
{
    public partial class ViewB : ContentPage
    {
        public ViewB()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (Parent is NavigationPage navPage) {
                navPage.BarBackgroundColor = Color.FromHex("#3399ff");
            }

            base.OnAppearing();
        }
    }
}
