using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Issue_SingletonRegistrationIssue.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager _regionManager;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _loadACommand;
        public DelegateCommand LoadACommand =>
            _loadACommand ?? (_loadACommand = new DelegateCommand(ExecuteLoadACommand));

        void ExecuteLoadACommand()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewA");
        }

        private DelegateCommand _fieldName;
        public DelegateCommand LoadBCommand =>
            _fieldName ?? (_fieldName = new DelegateCommand(ExecuteLoadBCommand));

        void ExecuteLoadBCommand()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewB");
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
