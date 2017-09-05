using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;

namespace StatusBarSpecificsDemo.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }


        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string name)
        {
            _navigationService.NavigateAsync(name);
        }
    }
}
