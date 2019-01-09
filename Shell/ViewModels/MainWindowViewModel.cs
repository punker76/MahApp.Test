using Infrastructure;
using Prism.Commands;
using Prism.Regions;

namespace Shell.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int _badgeValue;
        public int BadgeValue
        {
            get { return _badgeValue; }
            set { SetProperty(ref _badgeValue, value); }
        }

        private string _parameterInput;
        private IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            Title = "MahApps Demo Programm";
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }
        
        public DelegateCommand<string> NavigateCommand { get; set; }

        private void Navigate(string navigationPath)
        {
            _regionManager.RequestNavigate("TabRegion", navigationPath);
        }
    }
}
