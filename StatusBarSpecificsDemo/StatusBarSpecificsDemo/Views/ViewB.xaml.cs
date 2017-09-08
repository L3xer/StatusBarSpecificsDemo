using Xamarin.Forms;
using StatusBarSpecificsDemo.PlatformConfiguration.Android;


namespace StatusBarSpecificsDemo.Views
{
    public partial class ViewB : ContentPage
    {
        private Color _pageBarColor = Color.FromHex("#3399ff");

        public ViewB()
        {
            InitializeComponent();

            this.On<Xamarin.Forms.PlatformConfiguration.Android>().SetStatusBarColor(_pageBarColor);
        }

        protected override void OnAppearing()
        {
            if (Parent is NavigationPage navPage) {
                navPage.BarBackgroundColor = _pageBarColor;
            }

            base.OnAppearing();
        }
    }
}
