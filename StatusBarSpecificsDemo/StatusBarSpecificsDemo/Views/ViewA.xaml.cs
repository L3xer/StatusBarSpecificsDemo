using Xamarin.Forms;

namespace StatusBarSpecificsDemo.Views
{
    public partial class ViewA : ContentPage
    {
        public ViewA()
        {
            InitializeComponent();            
        }

        protected override void OnAppearing()
        {
            if (Parent is NavigationPage navPage) {
                navPage.BarBackgroundColor = Color.FromHex("#99cc33");
            }            

            base.OnAppearing();
        }
    }
}
